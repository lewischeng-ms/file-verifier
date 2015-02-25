using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace FileVerifier
{
    public partial class MainForm : Form
    {
        #region 成员变量
        private List<MyFileInfo> files;
        private HashSet<string> fileNames;
        private Queue<int> taskPool;
        private Queue<DataRow> abortedRows;

        private long verifiedItems;
        private long maxWorkers;
        private long usingWorkers;
        private long activeWorkers;
        private Thread[] workers;
        private bool started;
        #endregion

        #region 事件处理程序
        private void MainForm_Load(object sender, EventArgs e)
        {
            DivideLabels();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            DivideLabels();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbortAllWorkers();
        }

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                    AddItem(fileName);
            }
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearAllItems();
        }

        private void startVerifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnqueueAllItems();
            StartVerifying();
        }

        private void stopVerifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbortAllWorkers();
            StatVerifiedItems();
        }

        private void resetVerifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetAllItems();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbortAllWorkers();
            Close();
        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = topToolStripMenuItem.Checked;
        }

        private void multiThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiThreadToolStripMenuItem.Checked)
                usingWorkers = maxWorkers;
            else
                usingWorkers = 1;
        }

        private void mD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Columns[2].Visible = mD5ToolStripMenuItem.Checked;
            ResetAllItems();
        }

        private void sHA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Columns[3].Visible = sHA1ToolStripMenuItem.Checked;
            ResetAllItems();
        }

        private void cRC32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Columns[4].Visible = cRC32ToolStripMenuItem.Checked;
            ResetAllItems();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("文件校验器 2.0    作者：成立    日期：2011/5/23", "关于");
        }

        private void dataGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dataGridView_DragDrop(object sender, DragEventArgs e)
        {
            Array fileStrings = (System.Array)e.Data.GetData(DataFormats.FileDrop);
            foreach (object o in fileStrings)
                AddItem(o.ToString());
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView.SelectedRows.Count < 1)
                e.Cancel = true;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedItems();
        }

        private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnqueueSelectedItems();
            StartVerifying();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSelectedItems();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchListForSelectedItem();
        }
        #endregion

        #region 公有方法
        public MainForm()
        {
            InitializeComponent();

            files = new List<MyFileInfo>();
            fileNames = new HashSet<string>();
            taskPool = new Queue<int>();
            abortedRows = new Queue<DataRow>();

            maxWorkers = Registry
                .LocalMachine
                .OpenSubKey("HARDWARE")
                .OpenSubKey("DESCRIPTION")
                .OpenSubKey("System")
                .OpenSubKey("CentralProcessor")
                .SubKeyCount;
            usingWorkers = maxWorkers;
            activeWorkers = 0;

            workers = new Thread[maxWorkers];
        }
        #endregion

        #region 私有方法
        #region 列表方法
        private void AddItem(string fileName)
        {
            // 检查是否重复添加。
            if (fileNames.Contains(fileName))
                return;
            else
                fileNames.Add(fileName);

            MyFileInfo file = new MyFileInfo();
            file.FullName = fileName;
            files.Add(file);

            DataRow row = dataTable.NewRow();
            row[0] = file.FileName;
            row[1] = file.Exists ? "等待校验" : "文件不存在";
            dataTable.Rows.Add(row);
        }

        private void RemoveItem(int index)
        {
            if (index < 0) return;

            MyFileInfo file = files[index];
            fileNames.Remove(file.FullName);
            if (file.Verified) --verifiedItems;
            files.RemoveAt(index);
            dataTable.Rows.RemoveAt(index);
        }

        private void RemoveSelectedItems()
        {
            DataGridViewSelectedRowCollection rows = dataGridView.SelectedRows;
            foreach (DataGridViewRow row in rows)
                RemoveItem(row.Index);
        }

        private void ClearAllItems()
        {
            files.Clear();
            fileNames.Clear();
            dataTable.Rows.Clear();
            verifiedItems = 0;
        }

        private void SearchListForSelectedItem()
        {
            DataGridViewSelectedRowCollection rows = dataGridView.SelectedRows;
            if (rows.Count > 1)
            {
                MessageBox.Show("只能选择一个基准文件进行比较！", "错误");
                return;
            }
            DataGridViewRow selectedRow = rows[0];
            SearchListForSelectedIndex(selectedRow.Index);
        }

        private void SearchListForSelectedIndex(int selectedIndex)
        {
            MyFileInfo selectedFile = files[selectedIndex];
            for (int i = 0; i < files.Count; ++i)
            {
                if (i == selectedIndex)
                    continue;
                MyFileInfo file = files[i];
                if (!file.Verified)
                    continue;

                bool notMatch =
                    mD5ToolStripMenuItem.Checked && !selectedFile.MD5.Equals(file.MD5) ||
                    sHA1ToolStripMenuItem.Checked && !selectedFile.SHA1.Equals(file.SHA1) ||
                    cRC32ToolStripMenuItem.Checked && !selectedFile.CRC32.Equals(file.CRC32);
                if (!notMatch)
                    dataGridView.Rows[i].Selected = true;
            }
        }
        #endregion

        #region 窗口辅助方法
        private void DivideLabels()
        {
            int meanLabelWidth = (statusStrip.Width - 20) / 2;
            multiThreadLabel.Width = meanLabelWidth;
            verifiedLabel.Width = meanLabelWidth;
        }

        private void SetMenuEnabled()
        {
            startVerifyToolStripMenuItem.Enabled = !started;
            stopVerifyToolStripMenuItem.Enabled = started;
            resetStatusToolStripMenuItem1.Enabled = !started;
            multiThreadToolStripMenuItem.Enabled = !started;

            removeToolStripMenuItem.Enabled = !started;
            verifyToolStripMenuItem.Enabled = !started;
            resetStatusToolStripMenuItem2.Enabled = !started;
            searchToolStripMenuItem.Enabled = !started;

            mD5ToolStripMenuItem.Enabled = !started;
            sHA1ToolStripMenuItem.Enabled = !started;
            cRC32ToolStripMenuItem.Enabled = !started;

            addFilesToolStripMenuItem.Enabled = !started;
            clearToolStripMenuItem.Enabled = !started;
        }

        private void UpdateRowStatus(DataRow row, string status)
        {
            Invoke((MethodInvoker)delegate
            {
                row[1] = status;
            });
        }

        private void UpdateRowHash(DataRow row, MyFileInfo file)
        {
            Invoke((MethodInvoker)delegate
            {
                row[1] = "校验成功";
                row[2] = file.MD5;
                row[3] = file.SHA1;
                row[4] = file.CRC32;
            });
        }

        private void AddAbortedRows(DataRow row)
        {
            lock (abortedRows)
            {
                abortedRows.Enqueue(row);
            }
        }

        private void UpdateAbortedRows()
        {
            while (abortedRows.Count > 0)
            {
                DataRow row = abortedRows.Dequeue();
                row[1] = "异常终止";
                row[2] = "";
                row[3] = "";
                row[4] = "";
            }
        }
        #endregion

        #region 任务队列方法
        private void EnqueueSelectedItems()
        {
            taskPool.Clear();
            DataGridViewSelectedRowCollection rows = dataGridView.SelectedRows;
            foreach (DataGridViewRow row in rows)
                if (row.Index >= 0)
                    taskPool.Enqueue(row.Index);
        }

        private void EnqueueAllItems()
        {
            taskPool.Clear();
            for (int i = 0; i < files.Count; ++i)
            {
                if (files[i].Verified)
                    continue;
                taskPool.Enqueue(i);
            }
        }

        private int DequeueItem()
        {
            lock (taskPool)
            {
                if (taskPool.Count > 0)
                    return taskPool.Dequeue();
                else
                    return -1;
            }
        }
        #endregion

        #region 线程方法
        private void AbortAllWorkers()
        {
            for (int i = 0; i < usingWorkers; ++i)
                if (workers[i] != null)
                {
                    workers[i].Abort();
                    workers[i].Join();
                }
            UpdateAbortedRows();
        }

        private void WorkerEnter()
        {
            Interlocked.Increment(ref activeWorkers);
        }

        private void WorkerLeave()
        {
            Interlocked.Decrement(ref activeWorkers);
        }

        private void WorkerThreshold()
        {
            WorkerEnter();

            MyFileInfo file = null;
            DataRow row = null;
            FileStream stream = null;

            try
            {
                while (true)
                {
                    try
                    {
                        int index = DequeueItem();
                        if (index < 0) break;
                        file = files[index];
                        row = dataTable.Rows[index];

                        UpdateRowStatus(row, "校验中……");

                        stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
                        if (mD5ToolStripMenuItem.Checked && file.MD5 == null)
                            file.MD5 = Hasher.GetMD5Hash(stream);
                        if (sHA1ToolStripMenuItem.Checked && file.SHA1 == null)
                            file.SHA1 = Hasher.GetSHA1Hash(stream);
                        if (cRC32ToolStripMenuItem.Checked && file.CRC32 == null)
                            file.CRC32 = Hasher.GetCRC32Hash(stream);

                        file.Verified = true;
                        Interlocked.Increment(ref verifiedItems);
                        UpdateRowHash(row, file);
                    }
                    catch (FileNotFoundException)
                    {
                        UpdateRowStatus(row, "文件不存在");
                    }
                    catch (IOException)
                    {
                        UpdateRowStatus(row, "读取错误");
                    }
                    finally
                    {
                        if (stream != null)
                            stream.Close();
                    }
                }
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
                file.Verified = false;
                AddAbortedRows(row);
            }

            WorkerLeave();
        }
        #endregion

        #region 校验方法
        private void ResetItem(int index)
        {
            MyFileInfo file = files[index];
            DataRow row = dataTable.Rows[index];

            row[1] = file.Exists ? "等待校验" : "文件不存在";
            if (file.Verified)
            {
                --verifiedItems;
                file.Verified = false;

                file.MD5 = null;
                file.SHA1 = null;
                file.CRC32 = null;

                row[2] = "";
                row[3] = "";
                row[4] = "";
            }
        }

        private void ResetAllItems()
        {
            for (int i = 0; i < files.Count; ++i)
                ResetItem(i);
        }

        private void ResetSelectedItems()
        {
            DataGridViewSelectedRowCollection rows = dataGridView.SelectedRows;
            foreach (DataGridViewRow row in rows)
                if (row.Index >= 0)
                    ResetItem(row.Index);
        }

        private void StartVerifying()
        {
            if (taskPool.Count < 1)
                return;

            started = true;
            SetMenuEnabled();

            long workersToStart = taskPool.Count < usingWorkers ? taskPool.Count : usingWorkers;
            for (int i = 0; i < workersToStart; ++i)
            {
                workers[i] = new Thread(WorkerThreshold);
                workers[i].Start();
            }
        }

        /// <summary>
        /// 由于异常终止时，已校验文件数可能是错误的
        /// 所以用本函数重新统计。
        /// </summary>
        private void StatVerifiedItems()
        {
            verifiedItems = 0;
            for (int i = 0; i < files.Count; ++i)
            {
                if (files[i].Verified)
                    ++verifiedItems;
            }
        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            multiThreadLabel.Text = "工作线程数：" + activeWorkers + "/" + usingWorkers;
            verifiedLabel.Text = "已校验文件数：" + verifiedItems + "/" + files.Count;
            if (started && activeWorkers < 1)
            {
                started = false;
                SetMenuEnabled();
            }
        }
        #endregion
    }
}
