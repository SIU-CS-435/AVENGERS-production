 namespace atm.USER_FORMS
{
    partial class USER_LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_LOGIN));
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbpasword = new System.Windows.Forms.Label();
            this.lbuserid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnewuser = new System.Windows.Forms.LinkLabel();
            this.enulluser = new System.Windows.Forms.ErrorProvider(this.components);
            this.enullpassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.enulluser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enullpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(756, 103);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(189, 25);
            this.tbpassword.TabIndex = 17;
            // 
            // tbuser
            // 
            this.tbuser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.Location = new System.Drawing.Point(756, 68);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(189, 25);
            this.tbuser.TabIndex = 16;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(823, 134);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(122, 29);
            this.btnlogin.TabIndex = 18;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbpasword
            // 
            this.lbpasword.AutoSize = true;
            this.lbpasword.BackColor = System.Drawing.Color.Transparent;
            this.lbpasword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpasword.ForeColor = System.Drawing.Color.White;
            this.lbpasword.Location = new System.Drawing.Point(663, 102);
            this.lbpasword.Name = "lbpasword";
            this.lbpasword.Size = new System.Drawing.Size(72, 19);
            this.lbpasword.TabIndex = 14;
            this.lbpasword.Text = "Password";
            // 
            // lbuserid
            // 
            this.lbuserid.AutoSize = true;
            this.lbuserid.BackColor = System.Drawing.Color.Transparent;
            this.lbuserid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuserid.ForeColor = System.Drawing.Color.White;
            this.lbuserid.Location = new System.Drawing.Point(663, 67);
            this.lbuserid.Name = "lbuserid";
            this.lbuserid.Size = new System.Drawing.Size(63, 19);
            this.lbuserid.TabIndex = 13;
            this.lbuserid.Text = "User-ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(762, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOGIN";
            // 
            // lbnewuser
            // 
            this.lbnewuser.AutoSize = true;
            this.lbnewuser.BackColor = System.Drawing.Color.Transparent;
            this.lbnewuser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnewuser.ForeColor = System.Drawing.Color.White;
            this.lbnewuser.LinkColor = System.Drawing.Color.White;
            this.lbnewuser.Location = new System.Drawing.Point(862, 179);
            this.lbnewuser.Name = "lbnewuser";
            this.lbnewuser.Size = new System.Drawing.Size(83, 19);
            this.lbnewuser.TabIndex = 20;
            this.lbnewuser.TabStop = true;
            this.lbnewuser.Text = "New User?";
            this.lbnewuser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbnewuser_LinkClicked);
            // 
            // enulluser
            // 
            this.enulluser.ContainerControl = this;
            // 
            // enullpassword
            // 
            this.enullpassword.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Developed By ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(640, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 211);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // USER_LOGIN
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbnewuser);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbpasword);
            this.Controls.Add(this.lbuserid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "USER_LOGIN";
            this.Text = "USER_LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.USER_LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enulluser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enullpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbpasword;
        private System.Windows.Forms.Label lbuserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbnewuser;
        public System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.ErrorProvider enulluser;
        private System.Windows.Forms.ErrorProvider enullpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}