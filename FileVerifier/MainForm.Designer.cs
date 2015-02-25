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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblFile1Path = new System.Windows.Forms.Label();
            this.txtFile1Path = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.ofdlg = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.txtFile2Path = new System.Windows.Forms.TextBox();
            this.lblFile2Path = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkCRC32 = new System.Windows.Forms.CheckBox();
            this.chkCompare = new System.Windows.Forms.CheckBox();
            this.chkSHA1 = new System.Windows.Forms.CheckBox();
            this.chkMD5 = new System.Windows.Forms.CheckBox();
            this.grpResult.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFile1Path
            // 
            this.lblFile1Path.AutoSize = true;
            this.lblFile1Path.Location = new System.Drawing.Point(12, 9);
            this.lblFile1Path.Name = "lblFile1Path";
            this.lblFile1Path.Size = new System.Drawing.Size(71, 12);
            this.lblFile1Path.TabIndex = 0;
            this.lblFile1Path.Text = "文件1路径：";
            // 
            // txtFile1Path
            // 
            this.txtFile1Path.AllowDrop = true;
            this.txtFile1Path.Location = new System.Drawing.Point(83, 6);
            this.txtFile1Path.Name = "txtFile1Path";
            this.txtFile1Path.ReadOnly = true;
            this.txtFile1Path.Size = new System.Drawing.Size(269, 21);
            this.txtFile1Path.TabIndex = 1;
            this.txtFile1Path.Text = "请点击右侧按钮或者将文件拖放至本框中。";
            this.txtFile1Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFile1Path_DragDrop);
            this.txtFile1Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile1Path_DragEnter);
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(358, 7);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(33, 20);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Location = new System.Drawing.Point(14, 148);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(377, 189);
            this.grpResult.TabIndex = 3;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "校验结果";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 20);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(365, 163);
            this.txtResult.TabIndex = 0;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(358, 34);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(33, 20);
            this.btnBrowse2.TabIndex = 9;
            this.btnBrowse2.Text = "...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // txtFile2Path
            // 
            this.txtFile2Path.AllowDrop = true;
            this.txtFile2Path.Location = new System.Drawing.Point(83, 33);
            this.txtFile2Path.Name = "txtFile2Path";
            this.txtFile2Path.ReadOnly = true;
            this.txtFile2Path.Size = new System.Drawing.Size(269, 21);
            this.txtFile2Path.TabIndex = 8;
            this.txtFile2Path.Text = "请点击右侧按钮或者将文件拖放至本框中。";
            this.txtFile2Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFile2Path_DragDrop);
            this.txtFile2Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile2Path_DragEnter);
            // 
            // lblFile2Path
            // 
            this.lblFile2Path.AutoSize = true;
            this.lblFile2Path.Location = new System.Drawing.Point(12, 36);
            this.lblFile2Path.Name = "lblFile2Path";
            this.lblFile2Path.Size = new System.Drawing.Size(71, 12);
            this.lblFile2Path.TabIndex = 7;
            this.lblFile2Path.Text = "文件2路径：";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkCRC32);
            this.grpOptions.Controls.Add(this.chkCompare);
            this.grpOptions.Controls.Add(this.chkSHA1);
            this.grpOptions.Controls.Add(this.chkMD5);
            this.grpOptions.Location = new System.Drawing.Point(14, 60);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(377, 82);
            this.grpOptions.TabIndex = 10;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "选项";
            // 
            // chkCRC32
            // 
            this.chkCRC32.AutoSize = true;
            this.chkCRC32.Checked = true;
            this.chkCRC32.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCRC32.Location = new System.Drawing.Point(96, 20);
            this.chkCRC32.Name = "chkCRC32";
            this.chkCRC32.Size = new System.Drawing.Size(90, 16);
            this.chkCRC32.TabIndex = 3;
            this.chkCRC32.Text = "显示CRC32值";
            this.chkCRC32.UseVisualStyleBackColor = true;
            // 
            // chkCompare
            // 
            this.chkCompare.AutoSize = true;
            this.chkCompare.Checked = true;
            this.chkCompare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompare.Location = new System.Drawing.Point(96, 51);
            this.chkCompare.Name = "chkCompare";
            this.chkCompare.Size = new System.Drawing.Size(96, 16);
            this.chkCompare.TabIndex = 2;
            this.chkCompare.Text = "比较两个文件";
            this.chkCompare.UseVisualStyleBackColor = true;
            // 
            // chkSHA1
            // 
            this.chkSHA1.AutoSize = true;
            this.chkSHA1.Checked = true;
            this.chkSHA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSHA1.Location = new System.Drawing.Point(6, 51);
            this.chkSHA1.Name = "chkSHA1";
            this.chkSHA1.Size = new System.Drawing.Size(84, 16);
            this.chkSHA1.TabIndex = 1;
            this.chkSHA1.Text = "显示SHA1值";
            this.chkSHA1.UseVisualStyleBackColor = true;
            // 
            // chkMD5
            // 
            this.chkMD5.AutoSize = true;
            this.chkMD5.Checked = true;
            this.chkMD5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMD5.Location = new System.Drawing.Point(6, 20);
            this.chkMD5.Name = "chkMD5";
            this.chkMD5.Size = new System.Drawing.Size(78, 16);
            this.chkMD5.TabIndex = 0;
            this.chkMD5.Text = "显示MD5值";
            this.chkMD5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 341);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.txtFile2Path);
            this.Controls.Add(this.lblFile2Path);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.txtFile1Path);
            this.Controls.Add(this.lblFile1Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件校验器 by Lewis Cheng @2010/8/26";
            this.TopMost = true;
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile1Path;
        private System.Windows.Forms.TextBox txtFile1Path;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.OpenFileDialog ofdlg;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.TextBox txtFile2Path;
        private System.Windows.Forms.Label lblFile2Path;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkCRC32;
        private System.Windows.Forms.CheckBox chkCompare;
        private System.Windows.Forms.CheckBox chkSHA1;
        private System.Windows.Forms.CheckBox chkMD5;
    }
}

