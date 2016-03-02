namespace atm.USER_FORMS
{
    partial class BOOKED_TICKET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOOKED_TICKET));
            this.dgviewbooked = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewbooked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgviewbooked
            // 
            this.dgviewbooked.AllowUserToAddRows = false;
            this.dgviewbooked.AllowUserToDeleteRows = false;
            this.dgviewbooked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewbooked.Location = new System.Drawing.Point(12, 110);
            this.dgviewbooked.Name = "dgviewbooked";
            this.dgviewbooked.ReadOnly = true;
            this.dgviewbooked.Size = new System.Drawing.Size(992, 281);
            this.dgviewbooked.TabIndex = 0;
            this.dgviewbooked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewbooked_CellContentClick);