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
    public partial class USER_LOGIN : Form
    {
        public USER_LOGIN()
        {
            InitializeComponent();
        }
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                int x = bussiness_accesslayer.null_validation(tbuser.Text);
                int y = bussiness_accesslayer.null_validation(tbpassword.Text);
                if (x == 1 || y == 1)
                {
                    MessageBox.Show("Username or Password Blank", "Error");
                }
                else
                {
                    string decrypt = "10101010" + tbpassword.Text; 
                    string q = "SELECT * FROM CUSTOMER_INFO WHERE EMAIL collate Latin1_general_cs_as ='" + tbuser.Text + "' AND PASSWORD collate Latin1_general_cs_as = '" + decrypt  + "'";
                    DataTable dt = new DataTable();
                    dt = dataaccess_layer.GetRecords(q);
                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        air_tic_rs at = new air_tic_rs(tbuser.Text);
                        at.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials", "Error");
                        tbpassword.Text = "";
                        tbuser.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                MessageBox.Show("Internal Error Occured");
                this.BeginInvoke(new MethodInvoker(Close));
            }

        }

       

        private void lbnewuser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Customer_Registration cr = new Customer_Registration();
            cr.Show();
        }

        private void USER_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

     
       
        

       
        
    }
}
