namespace atm
{
    partial class Customer_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Registration));
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbssn = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.cbssn = new System.Windows.Forms.ComboBox();
            this.cbgen = new System.Windows.Forms.ComboBox();
            this.lbssnno = new System.Windows.Forms.Label();
            this.lbssnt = new System.Windows.Forms.Label();
            this.lbgen = new System.Windows.Forms.Label();
            this.lbph = new System.Windows.Forms.Label();
            this.lbad = new System.Windows.Forms.Label();
            this.lbdob = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbhead = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.ename = new System.Windows.Forms.ErrorProvider(this.components);
            this.eemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epass = new System.Windows.Forms.ErrorProvider(this.components);
            this.ephone = new System.Windows.Forms.ErrorProvider(this.components);
            this.essn = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbhead1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.essn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dob
            // 
            this.dob.CustomFormat = "dd-MMM-yyyy";
            this.dob.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(506, 307);
            this.dob.MaxDate = new System.DateTime(2012, 9, 18, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(286, 25);
            this.dob.TabIndex = 32;
            this.dob.Value = new System.DateTime(1992, 1, 1, 0, 0, 0, 0);
            // 
            // tbadd
            // 
            this.tbadd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbadd.Location = new System.Drawing.Point(506, 350);
            this.tbadd.MaxLength = 100;
            this.tbadd.Multiline = true;
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(286, 27);
            this.tbadd.TabIndex = 33;
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.Location = new System.Drawing.Point(506, 390);
            this.tbphone.MaxLength = 10;
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(286, 25);
            this.tbphone.TabIndex = 34;
            this.tbphone.Leave += new System.EventHandler(this.tbphone_Leave);
            // 
            // tbssn
            // 
            this.tbssn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbssn.Location = new System.Drawing.Point(506, 516);
            this.tbssn.Name = "tbssn";
            this.tbssn.Size = new System.Drawing.Size(286, 25);
            this.tbssn.TabIndex = 37;
            this.tbssn.Leave += new System.EventHandler(this.tbssn_Leave);
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(506, 264);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(286, 25);
            this.tbpass.TabIndex = 31;
            this.tbpass.Leave += new System.EventHandler(this.tbpass_Leave);
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(506, 223);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(286, 25);
            this.tbemail.TabIndex = 30;
            this.tbemail.Leave += new System.EventHandler(this.tbemail_Leave);
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(506, 182);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(286, 25);
            this.tbname.TabIndex = 29;
            this.tbname.Leave += new System.EventHandler(this.tbname_Leave);
            // 
            // cbssn
            // 
            this.cbssn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbssn.FormattingEnabled = true;
            this.cbssn.Location = new System.Drawing.Point(506, 473);
            this.cbssn.Name = "cbssn";
            this.cbssn.Size = new System.Drawing.Size(286, 25);
            this.cbssn.TabIndex = 36;
            // 
            // cbgen
            // 
            this.cbgen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgen.FormattingEnabled = true;
            this.cbgen.Location = new System.Drawing.Point(506, 432);
            this.cbgen.Name = "cbgen";
            this.cbgen.Size = new System.Drawing.Size(286, 25);
            this.cbgen.TabIndex = 35;
            // 
            // lbssnno
            // 
            this.lbssnno.AutoSize = true;
            this.lbssnno.BackColor = System.Drawing.Color.Transparent;
            this.lbssnno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbssnno.ForeColor = System.Drawing.Color.Black;
            this.lbssnno.Location = new System.Drawing.Point(374, 521);
            this.lbssnno.Name = "lbssnno";
            this.lbssnno.Size = new System.Drawing.Size(117, 22);
            this.lbssnno.TabIndex = 26;
            this.lbssnno.Text = "SSN Number";
            // 
            // lbssnt
            // 
            this.lbssnt.AutoSize = true;
            this.lbssnt.BackColor = System.Drawing.Color.Transparent;
            this.lbssnt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbssnt.ForeColor = System.Drawing.Color.Black;
            this.lbssnt.Location = new System.Drawing.Point(374, 479);
            this.lbssnt.Name = "lbssnt";
            this.lbssnt.Size = new System.Drawing.Size(91, 22);
            this.lbssnt.TabIndex = 25;
            this.lbssnt.Text = "SSN Type";
            // 
            // lbgen
            // 
            this.lbgen.AutoSize = true;
            this.lbgen.BackColor = System.Drawing.Color.Transparent;
            this.lbgen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgen.ForeColor = System.Drawing.Color.Black;
            this.lbgen.Location = new System.Drawing.Point(374, 434);
            this.lbgen.Name = "lbgen";
            this.lbgen.Size = new System.Drawing.Size(71, 22);
            this.lbgen.TabIndex = 24;
            this.lbgen.Text = "Gender";
            // 
            // lbph
            // 
            this.lbph.AutoSize = true;
            this.lbph.BackColor = System.Drawing.Color.Transparent;
            this.lbph.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbph.ForeColor = System.Drawing.Color.Black;
            this.lbph.Location = new System.Drawing.Point(374, 395);
            this.lbph.Name = "lbph";
            this.lbph.Size = new System.Drawing.Size(61, 22);
            this.lbph.TabIndex = 23;
            this.lbph.Text = "Phone";
            // 
            // lbad
            // 
            this.lbad.AutoSize = true;
            this.lbad.BackColor = System.Drawing.Color.Transparent;
            this.lbad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbad.ForeColor = System.Drawing.Color.Black;
            this.lbad.Location = new System.Drawing.Point(374, 355);
            this.lbad.Name = "lbad";
            this.lbad.Size = new System.Drawing.Size(76, 22);
            this.lbad.TabIndex = 22;
            this.lbad.Text = "Address";
            // 
            // lbdob
            // 
            this.lbdob.AutoSize = true;
            this.lbdob.BackColor = System.Drawing.Color.Transparent;
            this.lbdob.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdob.ForeColor = System.Drawing.Color.Black;
            this.lbdob.Location = new System.Drawing.Point(374, 307);
            this.lbdob.Name = "lbdob";
            this.lbdob.Size = new System.Drawing.Size(52, 22);
            this.lbdob.TabIndex = 21;
            this.lbdob.Text = "DOB";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.BackColor = System.Drawing.Color.Transparent;
            this.lbpass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.ForeColor = System.Drawing.Color.Black;
            this.lbpass.Location = new System.Drawing.Point(374, 266);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(90, 22);
            this.lbpass.TabIndex = 20;
            this.lbpass.Text = "Password";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BackColor = System.Drawing.Color.Transparent;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ForeColor = System.Drawing.Color.Black;
            this.lbemail.Location = new System.Drawing.Point(374, 225);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(58, 22);
            this.lbemail.TabIndex = 19;
            this.lbemail.Text = "Email";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.Transparent;
            this.lbname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.Black;
            this.lbname.Location = new System.Drawing.Point(374, 184);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(58, 22);
            this.lbname.TabIndex = 18;
            this.lbname.Text = "Name";
            // 
            // lbhead
            // 
            this.lbhead.AutoSize = true;
            this.lbhead.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhead.Location = new System.Drawing.Point(111, -28);
            this.lbhead.Name = "lbhead";
            this.lbhead.Size = new System.Drawing.Size(252, 22);
            this.lbhead.TabIndex = 17;
            this.lbhead.Text = "MEMBER REGISTRATION";
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(506, 583);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(100, 28);
            this.btnregister.TabIndex = 38;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(411, 583);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(76, 28);
            this.btnclear.TabIndex = 39;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(625, 583);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(86, 28);
            this.btncancel.TabIndex = 40;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // ename
            // 
            this.ename.ContainerControl = this;
            // 
            // eemail
            // 
            this.eemail.ContainerControl = this;
            // 
            // epass
            // 
            this.epass.ContainerControl = this;
            // 
            // ephone
            // 
            this.ephone.ContainerControl = this;
            // 
            // essn
            // 
            this.essn.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 90);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            //this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbhead1
            // 
            this.lbhead1.AutoSize = true;
            this.lbhead1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbhead1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhead1.ForeColor = System.Drawing.Color.White;
            this.lbhead1.Location = new System.Drawing.Point(38, 67);
            this.lbhead1.Name = "lbhead1";
            this.lbhead1.Size = new System.Drawing.Size(309, 26);
            this.lbhead1.TabIndex = 42;
            this.lbhead1.Text = "MEMBER REGISTRATION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 385);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // Customer_Registration
            // 
            this.AcceptButton = this.btnregister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1021, 712);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbhead1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.tbadd);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbssn);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.cbssn);
            this.Controls.Add(this.cbgen);
            this.Controls.Add(this.lbssnno);
            this.Controls.Add(this.lbssnt);
            this.Controls.Add(this.lbgen);
            this.Controls.Add(this.lbph);
            this.Controls.Add(this.lbad);
            this.Controls.Add(this.lbdob);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbhead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.essn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbssn;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ComboBox cbssn;
        private System.Windows.Forms.ComboBox cbgen;
        private System.Windows.Forms.Label lbssnno;
        private System.Windows.Forms.Label lbssnt;
        private System.Windows.Forms.Label lbgen;
        private System.Windows.Forms.Label lbph;
        private System.Windows.Forms.Label lbad;
        private System.Windows.Forms.Label lbdob;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbhead;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ErrorProvider ename;
        private System.Windows.Forms.ErrorProvider eemail;
        private System.Windows.Forms.ErrorProvider epass;
        private System.Windows.Forms.ErrorProvider ephone;
        private System.Windows.Forms.ErrorProvider essn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbhead1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}