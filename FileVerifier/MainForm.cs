using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileVerifier
{
    public partial class MainForm : Form
    {
        private MyFile myFile1 = null;
        private MyFile myFile2 = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdlg.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                LoadFile1(ofdlg.FileName);
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdlg.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                LoadFile2(ofdlg.FileName);
        }

        private void LoadFile1(string fileName)
        {
            txtFile1Path.Text = fileName;
            if (myFile1 != null)
                myFile1.Close();
            myFile1 = new MyFile(txtFile1Path.Text);
            Compute();
        }

        private void LoadFile2(string fileName)
        {
            txtFile2Path.Text = fileName;
            if (myFile2 != null)
                myFile2.Close();
            myFile2 = new MyFile(txtFile2Path.Text);
            Compute();
        }

        private void Compute()
        {
            txtResult.Text = "";

            if (myFile1 != null)
                ProcessMyFile(1, myFile1);
            if (myFile2 != null)
                ProcessMyFile(2, myFile2);
            if (chkCompare.Checked && myFile1 != null && myFile2 != null)
                txtResult.Text += "文件" + (myFile1.MD5Hash == myFile2.MD5Hash ? "相同。" : "不相同。");
        }

        private void ProcessMyFile(int index, MyFile myFile)
        {
            if (!myFile.Opened)
            {
                try
                {
                    myFile.Open();
                }
                catch (Exception e)
                {
                    txtResult.Text += "错误：" + e.Message + "。" + Environment.NewLine;
                    return;
                }
            }

            String txt = "文件" + index.ToString() + "：" + Environment.NewLine;
            if (chkMD5.Checked)
                txt += "MD5：" + myFile.MD5Hash + Environment.NewLine;
            if (chkSHA1.Checked)
                txt += "SHA1：" + myFile.SHA1Hash + Environment.NewLine;
            if (chkCRC32.Checked)
                txt += "CRC32：" + myFile.CRC32Hash + Environment.NewLine;

            txtResult.Text += txt + Environment.NewLine;
        }

        private void txtFile1Path_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None; 
        }

        private void txtFile2Path_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtFile1Path_DragDrop(object sender, DragEventArgs e)
        {
            LoadFile1(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
        }

        private void txtFile2Path_DragDrop(object sender, DragEventArgs e)
        {
            LoadFile2(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
        }
    }
}
