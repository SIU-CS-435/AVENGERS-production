using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using atm.USER_FORMS;

namespace atm
{
    public partial class Customer_Registration : Form
    {
        int valid = 0;
        public Customer_Registration()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            USER_LOGIN ul = new USER_LOGIN();
            ul.Show(); 
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                tbname.Text = tbemail.Text = tbpass.Text = tbadd.Text = tbphone.Text = tbssn.Text = "";
                dob.Value = Convert.ToDateTime("1992-01-01");
                cbgen.Text = "Select Gender";
                cbssn.Text = "Select SSN type";
                epass.Clear();
                ephone.Clear();
                ename.Clear();
                eemail.Clear();
                essn.Clear();
            }
            catch (Exception ex)
            {
                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                MessageBox.Show("Internal Error Occured", "Sorry");
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }