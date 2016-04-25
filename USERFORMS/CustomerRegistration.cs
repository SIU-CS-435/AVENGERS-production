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
        int valid3 = 0;
        int valid4 = 0;
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
                cbssn.Text = "Select ID proof type";
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
                if (cbgen.Text == "Select Gender" || cbssn.Text == "Select ID proof type")
                {
                    valid = 1;
                }
                if(lblcaptcha.Text!=tbcaptcha.Text)
                {
                    MessageBox.Show("Incorrect Captcha");
                    Random random = new Random();
                    string combination = "0123456789ABCDEFGHIJKJLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                    StringBuilder captcha = new StringBuilder();
                    for (int i = 0; i < 6; i++)
                    {
                        captcha.Append(combination[random.Next(combination.Length)]);
                    }
                    lblcaptcha.Text = captcha.ToString();
                }
                foreach (Control tb in this.Controls)
                {
                    if (tb is TextBox)
                    {
                        valid1 = bussiness_accesslayer.null_validation(tb.Text);
                        if (valid1 == 1 || valid == 1)
                        {
                            MessageBox.Show("Empty Fields Not Allowed", "Error");
                            break;
                        }
                        if (valid == 2 || valid3 == 2 || valid4 == 2)
                        {
                            MessageBox.Show("Validations Not Satisfied", "Error");
                            break;
                        }
                        else
                        {
                            valid4 =0;
                        }
                    }
                }
                

                if (valid == 0 && valid1 == 0 && valid3==0&&valid4==0&&lblcaptcha.Text==tbcaptcha.Text)
                {
                    string encrpyt = bussiness_accesslayer.Encrypt(tbpass.Text);
                    SqlDataReader sdr = null;
                    string conn="Data Source=DESKTOP-OPN87JD\\SQLEXPRESS;Initial Catalog=ExpDB;Integrated Security=True";
                    SqlConnection sc = null;
                    sc = new SqlConnection(conn);
                    try
                    {
                        sc.Open();
                        SqlCommand cmd = new SqlCommand("Cust_Reg", sc);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Cname", tbname.Text);
                        cmd.Parameters.AddWithValue("@DOB", dob.Value.Date.ToShortDateString());
                        cmd.Parameters.AddWithValue("@Address", tbadd.Text);
                        cmd.Parameters.AddWithValue("@Phone", tbphone.Text);
                        cmd.Parameters.AddWithValue("@Email", tbemail.Text);
                        cmd.Parameters.AddWithValue("@Password", encrpyt);
                        cmd.Parameters.AddWithValue("@SSNType", cbssn.Text);
                        cmd.Parameters.AddWithValue("@SSNNumber", tbssn.Text);
                        cmd.Parameters.AddWithValue("@Gender", cbgen.Text);
                        cmd.Parameters.AddWithValue("@Security1", cmbsecurity1.Text);
                        cmd.Parameters.AddWithValue("@Security2", cmbsecurity2.Text);
                        cmd.Parameters.AddWithValue("@Security3", cmbsecurity3.Text);
                        cmd.Parameters.AddWithValue("@Answer1", tbanswer1.Text);
                        cmd.Parameters.AddWithValue("@Answer2", tbanswer2.Text);
                        cmd.Parameters.AddWithValue("@Answer3", tbanswer3.Text);
                        sdr = cmd.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                        MessageBox.Show("Internal Error Occured", "Sorry");
                        this.BeginInvoke(new MethodInvoker(Close));
                    }
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
            Random random = new Random();
            string combination = "0123456789ABCDEFGHIJKJLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder captcha = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                captcha.Append(combination[random.Next(combination.Length)]);
            }
            lblcaptcha.Text = captcha.ToString();
            pnlnext.Hide();
            dob.MaxDate = DateTime.Now.Date;
            cbgen.Text = "Select Gender";
            cbgen.Items.Add("Male");
            cbgen.Items.Add("Female");
            cbssn.Text = "Select ID proof type";
            cbssn.Items.Add("Driving License");
            cbssn.Items.Add("Voter Id");
            cbssn.Items.Add("Pancard");
            cbssn.Items.Add("Aadhar Card");
            cmbsecurity1.Text="Security Question 1";
            cmbsecurity2.Text="Security Question 2";
            cmbsecurity3.Text="Security Question 3";
            string s = "select * from Security_questions";
            DataTable dt = new DataTable();
            dt=dataaccess_layer.GetRecords(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbsecurity1.Items.Add(dt.Rows[i][0].ToString());
                cmbsecurity2.Items.Add(dt.Rows[i][0].ToString());
                cmbsecurity3.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        private void tbemail_Leave(object sender, EventArgs e)
        {
            eemail.Clear();
            int email_validate = bussiness_accesslayer.tbemail_Validating(tbemail.Text);
            if (email_validate == 1)
            {
                eemail.SetError(tbemail, "Enter Valid Email");
                valid3 = 2;
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

        private void tbpass_Leave(object sender, EventArgs e)
        {
            epass.Clear();
            int pass_validate = bussiness_accesslayer.tbpass_Validating(tbpass.Text);
            if (pass_validate == 1)
            {
                epass.SetError(tbpass, "Password should be alphanumeric with a  special character");
                valid4 = 2;
            } 
        }

        private void tbphone_Leave(object sender, EventArgs e)
        {
            ephone.Clear();
            int phone_validate = bussiness_accesslayer.phone_validation(tbphone.Text);
            if (phone_validate == 1)
            {
                ephone.SetError(tbphone, "Phone No must be numeric");
                valid = 2;
            }
            if (phone_validate == 2)
            {
                ephone.SetError(tbphone, "Length must be 10");
                valid = 2;
            } 
        }

        private void tbssn_Leave(object sender, EventArgs e)
        {
            essn.Clear();
            int ssn_validate = bussiness_accesslayer.ssn_validation(tbssn.Text);
            if (ssn_validate == 1)
            {
                essn.SetError(tbssn, "SSN number already registered");
                valid = 2;
            } 
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (valid == 0 && valid3 == 0 && valid4 == 0)
            {
                pnlnext.Show();
            }
            else
                MessageBox.Show("Validations are not satisfied");
        }

        private void tbcaptcha_Click(object sender, EventArgs e)
        {
            tbcaptcha.Text = string.Empty;
        }

        private void cmbsecurity1_Leave(object sender, EventArgs e)
        {
            cmbsecurity2.Items.Clear();
            string s = "select * from Security_Questions where Security_Questions not like '"+cmbsecurity1.Text+"'";
            DataTable dt = new DataTable();
            dt = dataaccess_layer.GetRecords(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbsecurity2.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cmbsecurity2_Leave(object sender, EventArgs e)
        {
            cmbsecurity3.Items.Clear();
            string s = "select * from Security_Questions where Security_Questions not like'" + cmbsecurity1.Text + "'and Security_questions not like '"+cmbsecurity2.Text+"'";
            DataTable dt = new DataTable();
            dt = dataaccess_layer.GetRecords(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbsecurity3.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void linklblrefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random random = new Random();
            string combination = "0123456789ABCDEFGHIJKJLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder captcha = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                captcha.Append(combination[random.Next(combination.Length)]);
            }
            lblcaptcha.Text = captcha.ToString();
        }
    }
}