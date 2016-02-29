using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atm.USER_FORMS
{
    public partial class Search : Form
    {
        string a;
        public Search(string s)
        {
            InitializeComponent();
            a = s;
        }
        public Search()
        {
            InitializeComponent();
        }

 private void Search_Load(object sender, EventArgs e)
 {
     try
     {
         dtpdate.MinDate = DateTime.Now.Date;
         pnlbook.Hide();
         pnlconfirmed.Hide();
         cmbSource.Text = "Select Source";
         cmbDestination.Text = "Select Destination";
         string q = "SELECT SRC FROM FLIGHT_MASTER GROUP BY SRC";
         DataTable dt = new DataTable();
         dt = dataaccess_layer.GetRecords(q);
         for (int i = 0; i < dt.Rows.Count; i++)
         {
             cmbSource.Items.Add(dt.Rows[i][0].ToString());
         }
     }
     catch (Exception ex)
     {
         bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
         MessageBox.Show("Internal Error Occured");
         this.BeginInvoke(new MethodInvoker(Close));
     }

 }

 private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
 {
     if (e.ColumnIndex == 6)
     {
      
         DataGridViewRow row = dgviewsearch.CurrentCell.OwningRow;
         string sou= row.Cells[2].Value.ToString();
         string time = row.Cells[3].Value.ToString();
         string des = row.Cells[4].Value.ToString();
         string airname = row.Cells[1].Value.ToString();
         lbseats.Text = tbseats.Text;
         lbbookingdate.Text = DateTime.Now.ToShortDateString();
         lbdoj.Text = dtpdate.Value.Date.ToShortDateString();
         int pr = ((Convert.ToInt16(row.Cells[5].Value)) * Convert.ToInt16(tbseats.Text));
         lbtotalprice.Text = pr.ToString();
         lbairlinename.Text = airname;
         lbdestination.Text = des;
         lbtime.Text = time;
         lbsource.Text = sou;
         string f = row.Cells[0].Value.ToString();
         lbflightno.Text = f;
         pnlbook.Show();
     }
 }

 private void btncancel_Click(object sender, EventArgs e)
 {
     pnlbook.Hide();
 }
 

 private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
 {
     cmbDestination.Text="Select Destination";
     DataTable dt = new DataTable();
     string q = "SELECT DISTINCT DEST FROM FLIGHT_MASTER WHERE DEST<>'" + cmbSource.Text + "'";
     dt = dataaccess_layer.GetRecords(q);
     cmbDestination.Items.Clear();
     for (int i = 0; i < dt.Rows.Count; i++)
     {
         cmbDestination.Items.Add(dt.Rows[i][0].ToString());
     } 
 }

 private void btnclose_Click(object sender, EventArgs e)
 {
     this.Close();
 }
 
 }        
}

