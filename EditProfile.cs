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
        
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int valid1 = 0;

        private void btnupdate_Click(object sender, EventArgs e)
        {
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

       
       

