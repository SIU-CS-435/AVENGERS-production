namespace atm.USER_FORMS
{
    partial class CancelFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelFrm));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.tbbid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbhead = new System.Windows.Forms.Label();
            this.pnlconfirm = new System.Windows.Forms.Panel();
            this.btncncl = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.lbtcfid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbtcnoseats = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbtcrefund = new System.Windows.Forms.Label();
            this.lbtccanchrg = new System.Windows.Forms.Label();
            this.lbtctotfare = new System.Windows.Forms.Label();
            this.lbtcto = new System.Windows.Forms.Label();
            this.lbtcfrm = new System.Windows.Forms.Label();
            this.lbtcjdat = new System.Windows.Forms.Label();
            this.lbtcbookdat = new System.Windows.Forms.Label();
            this.lbtcbid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlconfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(431, 138);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 32);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(276, 138);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(110, 32);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "SEARCH";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbbid
            // 
            this.tbbid.Location = new System.Drawing.Point(345, 91);
            this.tbbid.Name = "tbbid";
            this.tbbid.Size = new System.Drawing.Size(238, 20);
            this.tbbid.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bookind Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 54);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // lbhead
            // 
            this.lbhead.AutoSize = true;
            this.lbhead.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhead.ForeColor = System.Drawing.Color.White;
            this.lbhead.Location = new System.Drawing.Point(71, 22);
            this.lbhead.Name = "lbhead";
            this.lbhead.Size = new System.Drawing.Size(339, 31);
            this.lbhead.TabIndex = 74;
            this.lbhead.Text = "Ticket Cancellation Form";
            // 
            // pnlconfirm
            // 
            this.pnlconfirm.Controls.Add(this.btncncl);
            this.pnlconfirm.Controls.Add(this.BtnConfirm);
            this.pnlconfirm.Controls.Add(this.lbtcfid);
            this.pnlconfirm.Controls.Add(this.label10);
            this.pnlconfirm.Controls.Add(this.lbtcnoseats);
            this.pnlconfirm.Controls.Add(this.label6);
            this.pnlconfirm.Controls.Add(this.label26);
            this.pnlconfirm.Controls.Add(this.lbtcrefund);
            this.pnlconfirm.Controls.Add(this.lbtccanchrg);
            this.pnlconfirm.Controls.Add(this.lbtctotfare);
            this.pnlconfirm.Controls.Add(this.lbtcto);
            this.pnlconfirm.Controls.Add(this.lbtcfrm);
            this.pnlconfirm.Controls.Add(this.lbtcjdat);
            this.pnlconfirm.Controls.Add(this.lbtcbookdat);
            this.pnlconfirm.Controls.Add(this.lbtcbid);
            this.pnlconfirm.Controls.Add(this.label9);
            this.pnlconfirm.Controls.Add(this.label8);
            this.pnlconfirm.Controls.Add(this.label7);
            this.pnlconfirm.Controls.Add(this.label5);
            this.pnlconfirm.Controls.Add(this.label4);
            this.pnlconfirm.Controls.Add(this.label3);
            this.pnlconfirm.Controls.Add(this.label11);
            this.pnlconfirm.Location = new System.Drawing.Point(53, 176);
            this.pnlconfirm.Name = "pnlconfirm";
            this.pnlconfirm.Size = new System.Drawing.Size(685, 426);
            this.pnlconfirm.TabIndex = 75;
            // 
            // btncncl
            // 
            this.btncncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncncl.Location = new System.Drawing.Point(378, 381);
            this.btncncl.Name = "btncncl";
            this.btncncl.Size = new System.Drawing.Size(110, 42);
            this.btncncl.TabIndex = 99;
            this.btncncl.Text = "CANCEL";
            this.btncncl.UseVisualStyleBackColor = true;
            this.btncncl.Click += new System.EventHandler(this.btncncl_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.Location = new System.Drawing.Point(183, 381);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(127, 42);
            this.BtnConfirm.TabIndex = 98;
            this.BtnConfirm.Text = "CONFIRM";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lbtcfid
            // 
            this.lbtcfid.AutoSize = true;
            this.lbtcfid.Location = new System.Drawing.Point(422, 58);
            this.lbtcfid.Name = "lbtcfid";
            this.lbtcfid.Size = new System.Drawing.Size(41, 13);
            this.lbtcfid.TabIndex = 97;
            this.lbtcfid.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 96;
            this.label10.Text = "Flight ID";
            // 
            // lbtcnoseats
            // 
            this.lbtcnoseats.AutoSize = true;
            this.lbtcnoseats.Location = new System.Drawing.Point(419, 236);
            this.lbtcnoseats.Name = "lbtcnoseats";
            this.lbtcnoseats.Size = new System.Drawing.Size(41, 13);
            this.lbtcnoseats.TabIndex = 95;
            this.lbtcnoseats.Text = "label10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 94;
            this.label6.Text = "No. of seats";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(149, 200);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 20);
            this.label26.TabIndex = 93;
            this.label26.Text = "To";
            // 
            // lbtcrefund
            // 
            this.lbtcrefund.AutoSize = true;
            this.lbtcrefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtcrefund.Location = new System.Drawing.Point(419, 334);
            this.lbtcrefund.Name = "lbtcrefund";
            this.lbtcrefund.Size = new System.Drawing.Size(61, 18);
            this.lbtcrefund.TabIndex = 92;
            this.lbtcrefund.Text = "label25";
            // 
            // lbtccanchrg
            // 
            this.lbtccanchrg.AutoSize = true;
            this.lbtccanchrg.Location = new System.Drawing.Point(419, 301);
            this.lbtccanchrg.Name = "lbtccanchrg";
            this.lbtccanchrg.Size = new System.Drawing.Size(41, 13);
            this.lbtccanchrg.TabIndex = 91;
            this.lbtccanchrg.Text = "label24";
            // 
            // lbtctotfare
            // 
            this.lbtctotfare.AutoSize = true;
            this.lbtctotfare.Location = new System.Drawing.Point(419, 265);
            this.lbtctotfare.Name = "lbtctotfare";
            this.lbtctotfare.Size = new System.Drawing.Size(41, 13);
            this.lbtctotfare.TabIndex = 90;
            this.lbtctotfare.Text = "label23";
            // 
            // lbtcto
            // 
            this.lbtcto.AutoSize = true;
            this.lbtcto.Location = new System.Drawing.Point(419, 200);
            this.lbtcto.Name = "lbtcto";
            this.lbtcto.Size = new System.Drawing.Size(41, 13);
            this.lbtcto.TabIndex = 89;
            this.lbtcto.Text = "label22";
            // 
            // lbtcfrm
            // 
            this.lbtcfrm.AutoSize = true;
            this.lbtcfrm.Location = new System.Drawing.Point(419, 165);
            this.lbtcfrm.Name = "lbtcfrm";
            this.lbtcfrm.Size = new System.Drawing.Size(41, 13);
            this.lbtcfrm.TabIndex = 88;
            this.lbtcfrm.Text = "label21";
            // 
            // lbtcjdat
            // 
            this.lbtcjdat.AutoSize = true;
            this.lbtcjdat.Location = new System.Drawing.Point(419, 125);
            this.lbtcjdat.Name = "lbtcjdat";
            this.lbtcjdat.Size = new System.Drawing.Size(41, 13);
            this.lbtcjdat.TabIndex = 87;
            this.lbtcjdat.Text = "label20";
            // 
            // lbtcbookdat
            // 
            this.lbtcbookdat.AutoSize = true;
            this.lbtcbookdat.Location = new System.Drawing.Point(419, 89);
            this.lbtcbookdat.Name = "lbtcbookdat";
            this.lbtcbookdat.Size = new System.Drawing.Size(41, 13);
            this.lbtcbookdat.TabIndex = 86;
            this.lbtcbookdat.Text = "label19";
            // 
            // lbtcbid
            // 
            this.lbtcbid.AutoSize = true;
            this.lbtcbid.Location = new System.Drawing.Point(423, 23);
            this.lbtcbid.Name = "lbtcbid";
            this.lbtcbid.Size = new System.Drawing.Size(35, 13);
            this.lbtcbid.TabIndex = 85;
            this.lbtcbid.Text = "label6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "Cancellation Charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 81;
            this.label8.Text = "Refund Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Total Fare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Journey Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Booking Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 76;
            this.label11.Text = "Bookind Id";
            // 
            // CancelFrm
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 614);
            this.ControlBox = false;
            this.Controls.Add(this.pnlconfirm);
            this.Controls.Add(this.lbhead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.tbbid);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelFrm";
            this.Load += new System.EventHandler(this.CancelFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlconfirm.ResumeLayout(false);
            this.pnlconfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox tbbid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbhead;
        private System.Windows.Forms.Panel pnlconfirm;
        private System.Windows.Forms.Label lbtcfid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbtcnoseats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbtcrefund;
        private System.Windows.Forms.Label lbtccanchrg;
        private System.Windows.Forms.Label lbtctotfare;
        private System.Windows.Forms.Label lbtcto;
        private System.Windows.Forms.Label lbtcfrm;
        private System.Windows.Forms.Label lbtcjdat;
        private System.Windows.Forms.Label lbtcbookdat;
        private System.Windows.Forms.Label lbtcbid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btncncl;
        private System.Windows.Forms.Button BtnConfirm;
    }
}