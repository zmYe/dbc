namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BitBtn1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.Chk_agent = new System.Windows.Forms.CheckBox();
            this.cmb_agent = new System.Windows.Forms.ComboBox();
            this.BitBtn_ZS = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkKeepInLocalFile = new System.Windows.Forms.CheckBox();
            this.chk_InIP = new System.Windows.Forms.CheckBox();
            this.chk_OutIP = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BitBtn1
            // 
            this.BitBtn1.Location = new System.Drawing.Point(48, 129);
            this.BitBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.BitBtn1.Name = "BitBtn1";
            this.BitBtn1.Size = new System.Drawing.Size(100, 29);
            this.BitBtn1.TabIndex = 0;
            this.BitBtn1.Text = "正式庫168";
            this.BitBtn1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "用戶名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "密碼：";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(112, 24);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(129, 25);
            this.edtName.TabIndex = 5;
            // 
            // edtPassword
            // 
            this.edtPassword.Location = new System.Drawing.Point(112, 56);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '*';
            this.edtPassword.Size = new System.Drawing.Size(129, 25);
            this.edtPassword.TabIndex = 6;
            this.edtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtPassword_KeyPress);
            // 
            // Chk_agent
            // 
            this.Chk_agent.AutoSize = true;
            this.Chk_agent.Location = new System.Drawing.Point(54, 95);
            this.Chk_agent.Name = "Chk_agent";
            this.Chk_agent.Size = new System.Drawing.Size(56, 19);
            this.Chk_agent.TabIndex = 7;
            this.Chk_agent.Text = "代理";
            this.Chk_agent.UseVisualStyleBackColor = true;
            // 
            // cmb_agent
            // 
            this.cmb_agent.FormattingEnabled = true;
            this.cmb_agent.Location = new System.Drawing.Point(112, 91);
            this.cmb_agent.Name = "cmb_agent";
            this.cmb_agent.Size = new System.Drawing.Size(129, 23);
            this.cmb_agent.TabIndex = 8;
            // 
            // BitBtn_ZS
            // 
            this.BitBtn_ZS.Location = new System.Drawing.Point(48, 166);
            this.BitBtn_ZS.Margin = new System.Windows.Forms.Padding(4);
            this.BitBtn_ZS.Name = "BitBtn_ZS";
            this.BitBtn_ZS.Size = new System.Drawing.Size(100, 29);
            this.BitBtn_ZS.TabIndex = 9;
            this.BitBtn_ZS.Text = "正式庫188";
            this.BitBtn_ZS.UseVisualStyleBackColor = true;
            this.BitBtn_ZS.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(48, 203);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(185, 203);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkKeepInLocalFile
            // 
            this.chkKeepInLocalFile.AutoSize = true;
            this.chkKeepInLocalFile.Checked = true;
            this.chkKeepInLocalFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepInLocalFile.Location = new System.Drawing.Point(171, 127);
            this.chkKeepInLocalFile.Name = "chkKeepInLocalFile";
            this.chkKeepInLocalFile.Size = new System.Drawing.Size(146, 19);
            this.chkKeepInLocalFile.TabIndex = 12;
            this.chkKeepInLocalFile.Text = "自動保存登錄信息";
            this.chkKeepInLocalFile.UseVisualStyleBackColor = true;
            // 
            // chk_InIP
            // 
            this.chk_InIP.AutoSize = true;
            this.chk_InIP.Checked = true;
            this.chk_InIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_InIP.Location = new System.Drawing.Point(171, 152);
            this.chk_InIP.Name = "chk_InIP";
            this.chk_InIP.Size = new System.Drawing.Size(69, 19);
            this.chk_InIP.TabIndex = 13;
            this.chk_InIP.Text = "內部IP";
            this.chk_InIP.UseVisualStyleBackColor = true;
            this.chk_InIP.CheckedChanged += new System.EventHandler(this.chk_InIP_CheckedChanged);
            // 
            // chk_OutIP
            // 
            this.chk_OutIP.AutoSize = true;
            this.chk_OutIP.Location = new System.Drawing.Point(171, 177);
            this.chk_OutIP.Name = "chk_OutIP";
            this.chk_OutIP.Size = new System.Drawing.Size(69, 19);
            this.chk_OutIP.TabIndex = 14;
            this.chk_OutIP.Text = "外部IP";
            this.chk_OutIP.UseVisualStyleBackColor = true;
            this.chk_OutIP.CheckedChanged += new System.EventHandler(this.chk_OutIP_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 242);
            this.Controls.Add(this.chk_OutIP);
            this.Controls.Add(this.chk_InIP);
            this.Controls.Add(this.chkKeepInLocalFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.BitBtn_ZS);
            this.Controls.Add(this.cmb_agent);
            this.Controls.Add(this.Chk_agent);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BitBtn1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登入Victory City Tim 查詢系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BitBtn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.CheckBox Chk_agent;
        private System.Windows.Forms.ComboBox cmb_agent;
        private System.Windows.Forms.Button BitBtn_ZS;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkKeepInLocalFile;
        private System.Windows.Forms.CheckBox chk_InIP;
        private System.Windows.Forms.CheckBox chk_OutIP;
    }
}

