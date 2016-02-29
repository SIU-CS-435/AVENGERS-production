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
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int valid1 = 0;
                if (cbgen.Text == "Select Gender" || cbssn.Text == "Select SSN type")
                {
                    valid = 1;
                }
                foreach (Control tb in this.Controls)
                {
                    if (tb is TextBox)
                    {
                        valid1 = bussiness_accesslayer.null_validation(tb.Text);
                        if (valid1==1 ||valid == 1)
                        {
                            MessageBox.Show("Empty Fields Not Allowed", "Error");
                            break;
                        }
                        if (valid == 2)
                        {
                            MessageBox.Show("Validations Not Satisfied", "Error");
                            break;
                        }
                    }
                }
                if (valid == 0 && valid1 == 0)
                {
                    string encrpyt = "10101010"+tbpass.Text;

                    string q = "INSERT INTO CUSTOMER_INFO (CNAME,DOB,ADDRESS,PHONE,EMAIL,PASSWORD,SSN_TYPE,SSN_NO,GENDER) VALUES ('" + tbname.Text + "','" + dob.Value.Date.ToShortDateString() + "','" + tbadd.Text + "','" + tbphone.Text + "','" + tbemail.Text + "','" + encrpyt + "','" + cbssn.Text + "','" + tbssn.Text + "','" + cbgen.Text + "')";
                    dataaccess_layer.ProcessQuery(q);
                    MessageBox.Show("Registration is Successful", "Congrats");
                    MessageBox.Show("Your Email will be user ID", "Remember");
                    btnclear_Click(btnclear, null);
                    this.Close();
                    USER_LOGIN ul = new USER_LOGIN();
                    ul.Show();
                }
                valid = 0;
            }

            catch (Exception ex)
            {
                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                MessageBox.Show("Internal Error Occured", "Sorry");
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }
        private void Customer_Registration_Load(object sender, EventArgs e)
        {  
            
            dob.MaxDate = DateTime.Now.Date;
            cbgen.Text = "Select Gender";
            cbgen.Items.Add("Male");
            cbgen.Items.Add("Female");
            cbssn.Text = "Select SSN type";
            cbssn.Items.Add("Driving License");
            cbssn.Items.Add("Voter Id");
            cbssn.Items.Add("Pancard");
            cbssn.Items.Add("Aadhar Card");
        }

        private void tbemail_Leave(object sender, EventArgs e)
        {
            eemail.Clear();
            int email_validate = bussiness_accesslayer.tbemail_Validating(tbemail.Text);
            if (email_validate == 1)
            {
                eemail.SetError(tbemail, "Enter Valid Email");
                valid = 2;
            }
            if (email_validate == 2)
            {
                eemail.SetError(tbemail, "Email already Registered");
                valid = 2;
            }
        }

        private void tbname_Leave(object sender, EventArgs e)
        {
            ename.Clear();
            int name_validate = bussiness_accesslayer.name_validation(tbname.Text);
            if (name_validate == 1)
            {
                ename.SetError(tbname, "Name cannot be alphanumberic && Special Characters Not allowed");
                valid = 2;
            }
        }