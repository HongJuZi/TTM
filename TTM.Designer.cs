namespace TTM
{
    partial class TTM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTM));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.CommandTab = new System.Windows.Forms.TabPage();
            this.InputTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.VoiceFile = new System.Windows.Forms.TextBox();
            this.SelctFileBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VideoAPIList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ParseVoice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.VoiceDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SearchTab);
            this.tabControl1.Controls.Add(this.CommandTab);
            this.tabControl1.Controls.Add(this.InputTab);
            this.tabControl1.Location = new System.Drawing.Point(8, 373);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 165);
            this.tabControl1.TabIndex = 0;
            // 
            // SearchTab
            // 
            this.SearchTab.Location = new System.Drawing.Point(4, 22);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(531, 139);
            this.SearchTab.TabIndex = 0;
            this.SearchTab.Text = "搜索模式";
            this.SearchTab.UseVisualStyleBackColor = true;
            // 
            // CommandTab
            // 
            this.CommandTab.Location = new System.Drawing.Point(4, 22);
            this.CommandTab.Name = "CommandTab";
            this.CommandTab.Padding = new System.Windows.Forms.Padding(3);
            this.CommandTab.Size = new System.Drawing.Size(527, 139);
            this.CommandTab.TabIndex = 1;
            this.CommandTab.Text = "命令模式";
            this.CommandTab.UseVisualStyleBackColor = true;
            // 
            // InputTab
            // 
            this.InputTab.Location = new System.Drawing.Point(4, 22);
            this.InputTab.Name = "InputTab";
            this.InputTab.Size = new System.Drawing.Size(527, 139);
            this.InputTab.TabIndex = 2;
            this.InputTab.Text = "输入模式";
            this.InputTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择语音文件：";
            // 
            // VoiceFile
            // 
            this.VoiceFile.Location = new System.Drawing.Point(106, 63);
            this.VoiceFile.Name = "VoiceFile";
            this.VoiceFile.Size = new System.Drawing.Size(309, 21);
            this.VoiceFile.TabIndex = 2;
            // 
            // SelctFileBtn
            // 
            this.SelctFileBtn.Location = new System.Drawing.Point(421, 63);
            this.SelctFileBtn.Name = "SelctFileBtn";
            this.SelctFileBtn.Size = new System.Drawing.Size(71, 23);
            this.SelctFileBtn.TabIndex = 3;
            this.SelctFileBtn.Text = "选择文件";
            this.SelctFileBtn.UseVisualStyleBackColor = true;
            this.SelctFileBtn.Click += new System.EventHandler(this.SelctFileBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 355);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "语音识别";
            // 
            // VideoAPIList
            // 
            this.VideoAPIList.FormattingEnabled = true;
            this.VideoAPIList.Items.AddRange(new object[] {
            "Google语音API",
            "微软语音API",
            "科大讯飞API"});
            this.VideoAPIList.Location = new System.Drawing.Point(106, 23);
            this.VideoAPIList.Name = "VideoAPIList";
            this.VideoAPIList.Size = new System.Drawing.Size(309, 20);
            this.VideoAPIList.TabIndex = 4;
            this.VideoAPIList.Text = "Google语音API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "语音API选择：";
            // 
            // ParseVoice
            // 
            this.ParseVoice.Location = new System.Drawing.Point(106, 96);
            this.ParseVoice.Name = "ParseVoice";
            this.ParseVoice.Size = new System.Drawing.Size(95, 32);
            this.ParseVoice.TabIndex = 5;
            this.ParseVoice.Text = "开始识别";
            this.ParseVoice.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 170);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "识别结果";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VoiceFile);
            this.groupBox3.Controls.Add(this.ParseVoice);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.SelctFileBtn);
            this.groupBox3.Controls.Add(this.VideoAPIList);
            this.groupBox3.Location = new System.Drawing.Point(13, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 142);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(10, 23);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(482, 135);
            this.LogBox.TabIndex = 0;
            // 
            // VoiceDialog
            // 
            this.VoiceDialog.DefaultExt = "wav";
            this.VoiceDialog.Filter = "\"WAV文件|*.wav|SPEEX文件|*.speex|FLAC文件|*.flac|所有文件|*.*\"";
            this.VoiceDialog.Title = "请选择需要识别的语音文件";
            // 
            // TTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TTM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TTM";
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SearchTab;
        private System.Windows.Forms.TabPage CommandTab;
        private System.Windows.Forms.TabPage InputTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VoiceFile;
        private System.Windows.Forms.Button SelctFileBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VideoAPIList;
        private System.Windows.Forms.Button ParseVoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.OpenFileDialog VoiceDialog;
    }
}