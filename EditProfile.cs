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
    public partial class EditProfile : Form
    {
        string un = "";
        public EditProfile()
        {
            InitializeComponent();
        }

        public EditProfile(string u)
        {
            un = u;
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            try
            {
               
                cmbgen.Items.Clear();
                cmbgen.Items.Add("Male");
                cmbgen.Items.Add("Female");
                cmbssn.Items.Clear();
                cmbssn.Items.Add("Driving License");
                cmbssn.Items.Add("Voter Id");
                cmbssn.Items.Add("Pancard");
                cmbssn.Items.Add("Aadhar Card");
                tbemail.Text = un;
                string q3 = "SELECT * FROM CUSTOMER_INFO WHERE EMAIL='" + un + "'";
                
                DataTable dt = new DataTable();
                
                dt = dataaccess_layer.GetRecords(q3);
                string pass = dt.Rows[0]["password"].ToString().Substring(8);
                lbcval.Text = dt.Rows[0]["cid"].ToString();
                tbname.Text = dt.Rows[0]["cname"].ToString();
                tbadd.Text = dt.Rows[0]["address"].ToString();
                tbpass.Text = pass;
                tbemail.Text = dt.Rows[0]["email"].ToString();
                tbphone.Text = dt.Rows[0]["phone"].ToString();
                cmbssn.Text = dt.Rows[0]["ssn_type"].ToString();
                tbssn.Text = dt.Rows[0]["ssn_no"].ToString();
                cmbgen.Text = dt.Rows[0]["gender"].ToString();
                dob.Text = dt.Rows[0]["dob"].ToString();
            }
            catch (Exception ex)
            {
                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                MessageBox.Show("Internal Error Occured");
               this.BeginInvoke(new MethodInvoker(Close));
            
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int valid1 = 0;

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int valid = 0;
                foreach (Control tb in this.Controls)
                {
                    if (tb is TextBox)
                    {
                        valid = bussiness_accesslayer.null_validation(tb.Text);
                        if (valid == 1)
                        {
                            MessageBox.Show("Empty Fields Not Allowed", "ERROR");
                            break;
                        }
                        if (valid1 == 2)
                        {
                            MessageBox.Show("Validations Not satisfied", "ERROR");
                            break;
                        }
                    }
                }
                if (valid == 0 && valid1 == 0)
                {
                    int count = 0, count1 = 0;
                    DataTable dt = new DataTable();
                    string q1 = "SELECT EMAIL,SSN_NO FROM CUSTOMER_INFO WHERE CID NOT LIKE '" + lbcval.Text + "'";
                    dt = dataaccess_layer.GetRecords(q1);
                    string encrypt = "10101010" + tbpass.Text;
                    string q = "UPDATE CUSTOMER_INFO SET CNAME='" + tbname.Text + "',DOB='" + dob.Value.Date.ToShortDateString() + "',ADDRESS='" + tbadd.Text + "',PHONE='" + tbphone.Text + "',EMAIL='" + tbemail.Text + "',PASSWORD='" + encrypt + "',SSN_TYPE='" + cmbssn.Text + "',SSN_NO='" + tbssn.Text + "' WHERE CID='" + lbcval.Text + "'";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][0].ToString() == tbemail.Text)
                        {
                            count++;
                        }
                        if (dt.Rows[i][1].ToString() == tbssn.Text)
                        {
                            count1++;
                        }
                    }
                    if (count == 0 && count1 == 0)
                    {
                        dataaccess_layer.ProcessQuery(q);
                        MessageBox.Show(tbname.Text + "'s Profile Updated Successfully", "Congrats");
                    }
                    else
                    {
                        if (count > 0)
                        {
                            MessageBox.Show("Email Already Exits", "Sorry");
                        }

                        if (count1 > 0)
                        {
                            MessageBox.Show("SSN Number Already Exits", "Sorry");
                        }
                    }
                }
                valid1 = 0;
            }
        
        catch (Exception ex)
            {
                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
            }
}
        private void tbname_Leave(object sender, EventArgs e)
        {
            enameedit.Clear();
            int name_valid = bussiness_accesslayer.name_validation(tbname.Text);
            if (name_valid == 1)
            {
                enameedit.SetError(tbname, "Name Cannot Be Alphanumberic && Special Characters Not Allowed");
                valid1 = 2;
            }
        }

        private void tbemail_Leave(object sender, EventArgs e)
        {
            eemailedit.Clear();
            int email_valid = bussiness_accesslayer.tbemail_Validating(tbemail.Text);
            if (email_valid == 1)
            {
                eemailedit.SetError(tbemail, "Enter Valid Email");
                valid1 = 2;
            }
        }

        private void tbpass_Leave(object sender, EventArgs e)
        {
            epasswordedit.Clear();
            int pass_valid = bussiness_accesslayer.tbpass_Validating(tbpass.Text);
            if (pass_valid == 1)
            {
                epasswordedit.SetError(tbpass, "Password Should Be Alphanumeric With a Special Character");
                valid1 = 2;
            }
        }

        private void tbphone_Leave(object sender, EventArgs e)
        {
            ephoneedit.Clear();
            int phone_valid = bussiness_accesslayer.phone_validation(tbphone.Text);
            if (phone_valid == 1)
            {
                ephoneedit.SetError(tbphone, "Phone Number Must Be Numeric");
                valid1 = 2;
            }
            if (phone_valid == 2)
            {
                ephoneedit.SetError(tbphone, "Phone Number Length Should Be 10");
                valid1 = 2;
            }
        }

       
       

    }
}
