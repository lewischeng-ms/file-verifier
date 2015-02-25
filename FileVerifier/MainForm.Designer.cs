namespace FileVerifier
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startVerifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopVerifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetStatusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRC32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.multiThreadLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.verifiedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.文件DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mD5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRC32DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetStatusToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet = new System.Data.DataSet();
            this.dataTable = new System.Data.DataTable();
            this.dataColumnFile = new System.Data.DataColumn();
            this.dataColumnStatus = new System.Data.DataColumn();
            this.dataColumnMD5 = new System.Data.DataColumn();
            this.dataColumnSHA1 = new System.Data.DataColumn();
            this.dataColumnCRC32 = new System.Data.DataColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(731, 25);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.startVerifyToolStripMenuItem,
            this.stopVerifyToolStripMenuItem,
            this.resetStatusToolStripMenuItem1,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addFilesToolStripMenuItem.Text = "添加文件";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearToolStripMenuItem.Text = "清空列表";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // startVerifyToolStripMenuItem
            // 
            this.startVerifyToolStripMenuItem.Name = "startVerifyToolStripMenuItem";
            this.startVerifyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.startVerifyToolStripMenuItem.Text = "开始校验";
            this.startVerifyToolStripMenuItem.Click += new System.EventHandler(this.startVerifyToolStripMenuItem_Click);
            // 
            // stopVerifyToolStripMenuItem
            // 
            this.stopVerifyToolStripMenuItem.Enabled = false;
            this.stopVerifyToolStripMenuItem.Name = "stopVerifyToolStripMenuItem";
            this.stopVerifyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.stopVerifyToolStripMenuItem.Text = "停止校验";
            this.stopVerifyToolStripMenuItem.Click += new System.EventHandler(this.stopVerifyToolStripMenuItem_Click);
            // 
            // resetStatusToolStripMenuItem1
            // 
            this.resetStatusToolStripMenuItem1.Name = "resetStatusToolStripMenuItem1";
            this.resetStatusToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.resetStatusToolStripMenuItem1.Text = "重置状态";
            this.resetStatusToolStripMenuItem1.Click += new System.EventHandler(this.resetVerifyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.multiThreadToolStripMenuItem,
            this.toolStripSeparator3,
            this.mD5ToolStripMenuItem,
            this.sHA1ToolStripMenuItem,
            this.cRC32ToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.optionToolStripMenuItem.Text = "选项";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Checked = true;
            this.topToolStripMenuItem.CheckOnClick = true;
            this.topToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.topToolStripMenuItem.Text = "窗口置顶";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // multiThreadToolStripMenuItem
            // 
            this.multiThreadToolStripMenuItem.Checked = true;
            this.multiThreadToolStripMenuItem.CheckOnClick = true;
            this.multiThreadToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.multiThreadToolStripMenuItem.Name = "multiThreadToolStripMenuItem";
            this.multiThreadToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.multiThreadToolStripMenuItem.Text = "多线程优化";
            this.multiThreadToolStripMenuItem.Click += new System.EventHandler(this.multiThreadToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // mD5ToolStripMenuItem
            // 
            this.mD5ToolStripMenuItem.Checked = true;
            this.mD5ToolStripMenuItem.CheckOnClick = true;
            this.mD5ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mD5ToolStripMenuItem.Name = "mD5ToolStripMenuItem";
            this.mD5ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.mD5ToolStripMenuItem.Text = "MD5";
            this.mD5ToolStripMenuItem.Click += new System.EventHandler(this.mD5ToolStripMenuItem_Click);
            // 
            // sHA1ToolStripMenuItem
            // 
            this.sHA1ToolStripMenuItem.CheckOnClick = true;
            this.sHA1ToolStripMenuItem.Name = "sHA1ToolStripMenuItem";
            this.sHA1ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sHA1ToolStripMenuItem.Text = "SHA1";
            this.sHA1ToolStripMenuItem.Click += new System.EventHandler(this.sHA1ToolStripMenuItem_Click);
            // 
            // cRC32ToolStripMenuItem
            // 
            this.cRC32ToolStripMenuItem.CheckOnClick = true;
            this.cRC32ToolStripMenuItem.Name = "cRC32ToolStripMenuItem";
            this.cRC32ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cRC32ToolStripMenuItem.Text = "CRC32";
            this.cRC32ToolStripMenuItem.Click += new System.EventHandler(this.cRC32ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiThreadLabel,
            this.verifiedLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 495);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(731, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // multiThreadLabel
            // 
            this.multiThreadLabel.AutoSize = false;
            this.multiThreadLabel.Name = "multiThreadLabel";
            this.multiThreadLabel.Size = new System.Drawing.Size(100, 17);
            this.multiThreadLabel.Text = "t";
            this.multiThreadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // verifiedLabel
            // 
            this.verifiedLabel.AutoSize = false;
            this.verifiedLabel.Name = "verifiedLabel";
            this.verifiedLabel.Size = new System.Drawing.Size(100, 17);
            this.verifiedLabel.Text = "v";
            this.verifiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "所有文件|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.文件DataGridViewTextBoxColumn,
            this.状态DataGridViewTextBoxColumn,
            this.mD5DataGridViewTextBoxColumn,
            this.sHA1DataGridViewTextBoxColumn,
            this.cRC32DataGridViewTextBoxColumn});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.DataMember = "DataTable";
            this.dataGridView.DataSource = this.dataSet;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(731, 470);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView_DragDrop);
            this.dataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView_DragEnter);
            // 
            // 文件DataGridViewTextBoxColumn
            // 
            this.文件DataGridViewTextBoxColumn.DataPropertyName = "文件";
            this.文件DataGridViewTextBoxColumn.HeaderText = "文件";
            this.文件DataGridViewTextBoxColumn.Name = "文件DataGridViewTextBoxColumn";
            this.文件DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 状态DataGridViewTextBoxColumn
            // 
            this.状态DataGridViewTextBoxColumn.DataPropertyName = "状态";
            this.状态DataGridViewTextBoxColumn.HeaderText = "状态";
            this.状态DataGridViewTextBoxColumn.Name = "状态DataGridViewTextBoxColumn";
            this.状态DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mD5DataGridViewTextBoxColumn
            // 
            this.mD5DataGridViewTextBoxColumn.DataPropertyName = "MD5";
            this.mD5DataGridViewTextBoxColumn.HeaderText = "MD5";
            this.mD5DataGridViewTextBoxColumn.Name = "mD5DataGridViewTextBoxColumn";
            this.mD5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sHA1DataGridViewTextBoxColumn
            // 
            this.sHA1DataGridViewTextBoxColumn.DataPropertyName = "SHA1";
            this.sHA1DataGridViewTextBoxColumn.HeaderText = "SHA1";
            this.sHA1DataGridViewTextBoxColumn.Name = "sHA1DataGridViewTextBoxColumn";
            this.sHA1DataGridViewTextBoxColumn.ReadOnly = true;
            this.sHA1DataGridViewTextBoxColumn.Visible = false;
            // 
            // cRC32DataGridViewTextBoxColumn
            // 
            this.cRC32DataGridViewTextBoxColumn.DataPropertyName = "CRC32";
            this.cRC32DataGridViewTextBoxColumn.HeaderText = "CRC32";
            this.cRC32DataGridViewTextBoxColumn.Name = "cRC32DataGridViewTextBoxColumn";
            this.cRC32DataGridViewTextBoxColumn.ReadOnly = true;
            this.cRC32DataGridViewTextBoxColumn.Visible = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.verifyToolStripMenuItem,
            this.resetStatusToolStripMenuItem2,
            this.searchToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 92);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removeToolStripMenuItem.Text = "移除";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // verifyToolStripMenuItem
            // 
            this.verifyToolStripMenuItem.Name = "verifyToolStripMenuItem";
            this.verifyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.verifyToolStripMenuItem.Text = "校验";
            this.verifyToolStripMenuItem.Click += new System.EventHandler(this.verifyToolStripMenuItem_Click);
            // 
            // resetStatusToolStripMenuItem2
            // 
            this.resetStatusToolStripMenuItem2.Name = "resetStatusToolStripMenuItem2";
            this.resetStatusToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.resetStatusToolStripMenuItem2.Text = "重置状态";
            this.resetStatusToolStripMenuItem2.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.searchToolStripMenuItem.Text = "寻找相同文件";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable});
            // 
            // dataTable
            // 
            this.dataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnFile,
            this.dataColumnStatus,
            this.dataColumnMD5,
            this.dataColumnSHA1,
            this.dataColumnCRC32});
            this.dataTable.TableName = "DataTable";
            // 
            // dataColumnFile
            // 
            this.dataColumnFile.Caption = "";
            this.dataColumnFile.ColumnName = "文件";
            // 
            // dataColumnStatus
            // 
            this.dataColumnStatus.Caption = "";
            this.dataColumnStatus.ColumnName = "状态";
            // 
            // dataColumnMD5
            // 
            this.dataColumnMD5.Caption = "";
            this.dataColumnMD5.ColumnName = "MD5";
            // 
            // dataColumnSHA1
            // 
            this.dataColumnSHA1.Caption = "";
            this.dataColumnSHA1.ColumnName = "SHA1";
            // 
            // dataColumnCRC32
            // 
            this.dataColumnCRC32.Caption = "";
            this.dataColumnCRC32.ColumnName = "CRC32";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 517);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件校验器 2.0";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem startVerifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel multiThreadLabel;
        private System.Windows.Forms.ToolStripStatusLabel verifiedLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dataTable;
        private System.Data.DataColumn dataColumnFile;
        private System.Data.DataColumn dataColumnStatus;
        private System.Data.DataColumn dataColumnMD5;
        private System.Data.DataColumn dataColumnSHA1;
        private System.Data.DataColumn dataColumnCRC32;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stopVerifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRC32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetStatusToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 文件DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mD5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRC32DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetStatusToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Timer timer;

    }
}

