namespace atm.USER_FORMS
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.btncancel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbssn = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.cmbssn = new System.Windows.Forms.ComboBox();
            this.cmbgen = new System.Windows.Forms.ComboBox();
            this.lbssnno = new System.Windows.Forms.Label();
            this.lbssnt = new System.Windows.Forms.Label();
            this.lbgen = new System.Windows.Forms.Label();
            this.lbph = new System.Windows.Forms.Label();
            this.lbad = new System.Windows.Forms.Label();
            this.lbdob = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbcid = new System.Windows.Forms.Label();
            this.lbcval = new System.Windows.Forms.Label();
            this.enameedit = new System.Windows.Forms.ErrorProvider(this.components);
            this.eemailedit = new System.Windows.Forms.ErrorProvider(this.components);
            this.ephoneedit = new System.Windows.Forms.ErrorProvider(this.components);
            this.epasswordedit = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enameedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eemailedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ephoneedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epasswordedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(540, 516);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(86, 32);
            this.btncancel.TabIndex = 61;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(418, 516);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 32);
            this.btnupdate.TabIndex = 60;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dob
            // 
            this.dob.CustomFormat = "dd-MMM-yyyy";
            this.dob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(492, 255);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 26);
            this.dob.TabIndex = 54;
            // 
            // tbadd
            // 
            this.tbadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbadd.Location = new System.Drawing.Point(492, 293);
            this.tbadd.MaxLength = 100;
            this.tbadd.Multiline = true;
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(200, 30);
            this.tbadd.TabIndex = 55;
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.Location = new System.Drawing.Point(492, 335);
            this.tbphone.MaxLength = 10;
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(200, 26);
            this.tbphone.TabIndex = 56;
            this.tbphone.Leave += new System.EventHandler(this.tbphone_Leave);
            // 
            // tbssn
            // 
            this.tbssn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbssn.Location = new System.Drawing.Point(492, 451);
            this.tbssn.Name = "tbssn";
            this.tbssn.Size = new System.Drawing.Size(200, 26);
            this.tbssn.TabIndex = 59;
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(492, 214);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(200, 26);
            this.tbpass.TabIndex = 53;
            this.tbpass.Leave += new System.EventHandler(this.tbpass_Leave);
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(492, 174);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(200, 26);
            this.tbemail.TabIndex = 52;
            this.tbemail.Leave += new System.EventHandler(this.tbemail_Leave);
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(492, 136);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(200, 26);
            this.tbname.TabIndex = 51;
            this.tbname.Leave += new System.EventHandler(this.tbname_Leave);
            // 
            // cmbssn
            // 
            this.cmbssn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbssn.FormattingEnabled = true;
            this.cmbssn.Location = new System.Drawing.Point(492, 413);
            this.cmbssn.Name = "cmbssn";
            this.cmbssn.Size = new System.Drawing.Size(200, 27);
            this.cmbssn.TabIndex = 58;
            // 
            // cmbgen
            // 
            this.cmbgen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgen.FormattingEnabled = true;
            this.cmbgen.Location = new System.Drawing.Point(492, 374);
            this.cmbgen.Name = "cmbgen";
            this.cmbgen.Size = new System.Drawing.Size(200, 27);
            this.cmbgen.TabIndex = 57;
            // 
            // lbssnno
            // 
            this.lbssnno.AutoSize = true;
            this.lbssnno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbssnno.Location = new System.Drawing.Point(360, 456);
            this.lbssnno.Name = "lbssnno";
            this.lbssnno.Size = new System.Drawing.Size(97, 19);
            this.lbssnno.TabIndex = 48;
            this.lbssnno.Text = "SSN Number";
            // 
            // lbssnt
            // 
            this.lbssnt.AutoSize = true;
            this.lbssnt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbssnt.Location = new System.Drawing.Point(360, 419);
            this.lbssnt.Name = "lbssnt";
            this.lbssnt.Size = new System.Drawing.Size(76, 19);
            this.lbssnt.TabIndex = 47;
            this.lbssnt.Text = "SSN Type";
            // 
            // lbgen
            // 
            this.lbgen.AutoSize = true;
            this.lbgen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgen.Location = new System.Drawing.Point(360, 377);
            this.lbgen.Name = "lbgen";
            this.lbgen.Size = new System.Drawing.Size(59, 19);
            this.lbgen.TabIndex = 46;
            this.lbgen.Text = "Gender";
            // 
            // lbph
            // 
            this.lbph.AutoSize = true;
            this.lbph.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbph.Location = new System.Drawing.Point(360, 340);
            this.lbph.Name = "lbph";
            this.lbph.Size = new System.Drawing.Size(50, 19);
            this.lbph.TabIndex = 45;
            this.lbph.Text = "Phone";
            // 
            // lbad
            // 
            this.lbad.AutoSize = true;
            this.lbad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbad.Location = new System.Drawing.Point(360, 298);
            this.lbad.Name = "lbad";
            this.lbad.Size = new System.Drawing.Size(64, 19);
            this.lbad.TabIndex = 44;
            this.lbad.Text = "Address";
            // 
            // lbdob
            // 
            this.lbdob.AutoSize = true;
            this.lbdob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdob.Location = new System.Drawing.Point(360, 255);
            this.lbdob.Name = "lbdob";
            this.lbdob.Size = new System.Drawing.Size(44, 19);
            this.lbdob.TabIndex = 43;
            this.lbdob.Text = "DOB";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(360, 216);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(72, 19);
            this.lbpass.TabIndex = 42;
            this.lbpass.Text = "Password";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(360, 176);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(47, 19);
            this.lbemail.TabIndex = 41;
            this.lbemail.Text = "Email";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(360, 138);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(49, 19);
            this.lbname.TabIndex = 40;
            this.lbname.Text = "Name";
            // 
            // lbcid
            // 
            this.lbcid.AutoSize = true;
            this.lbcid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcid.Location = new System.Drawing.Point(360, 104);
            this.lbcid.Name = "lbcid";
            this.lbcid.Size = new System.Drawing.Size(96, 19);
            this.lbcid.TabIndex = 62;
            this.lbcid.Text = "Customer ID";
            // 
            // lbcval
            // 
            this.lbcval.AutoSize = true;
            this.lbcval.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcval.Location = new System.Drawing.Point(489, 104);
            this.lbcval.Name = "lbcval";
            this.lbcval.Size = new System.Drawing.Size(0, 19);
            this.lbcval.TabIndex = 63;
            // 
            // enameedit
            // 
            this.enameedit.ContainerControl = this;
            // 
            // eemailedit
            // 
            this.eemailedit.ContainerControl = this;
            // 
            // ephoneedit
            // 
            this.ephoneedit.ContainerControl = this;
            // 
            // epasswordedit
            // 
            this.epasswordedit.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(1, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 43);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Edit Profile";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // EditProfile
            // 
            this.AcceptButton = this.btnupdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 573);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbcval);
            this.Controls.Add(this.lbcid);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.tbadd);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbssn);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.cmbssn);
            this.Controls.Add(this.cmbgen);
            this.Controls.Add(this.lbssnno);
            this.Controls.Add(this.lbssnt);
            this.Controls.Add(this.lbgen);
            this.Controls.Add(this.lbph);
            this.Controls.Add(this.lbad);
            this.Controls.Add(this.lbdob);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enameedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eemailedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ephoneedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epasswordedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbssn;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ComboBox cmbssn;
        private System.Windows.Forms.ComboBox cmbgen;
        private System.Windows.Forms.Label lbssnno;
        private System.Windows.Forms.Label lbssnt;
        private System.Windows.Forms.Label lbgen;
        private System.Windows.Forms.Label lbph;
        private System.Windows.Forms.Label lbad;
        private System.Windows.Forms.Label lbdob;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbcid;
        private System.Windows.Forms.Label lbcval;
        private System.Windows.Forms.ErrorProvider enameedit;
        private System.Windows.Forms.ErrorProvider eemailedit;
        private System.Windows.Forms.ErrorProvider ephoneedit;
        private System.Windows.Forms.ErrorProvider epasswordedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}