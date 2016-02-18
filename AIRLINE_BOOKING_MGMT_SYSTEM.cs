using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using atm.USER_FORMS;

namespace atm
{
    public class AIRLINE_BOOKING_MGMT_SYSTEM: Form
    {
        string uname = "";
        public AIRLINE_BOOKING_MGMT_SYSTEM()
        {
            InitializeComponent();
        }
        public AIRLINE_BOOKING_MGMT_SYSTEM(string s)
        {
            uname = s;
            InitializeComponent();
        }

      

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            Search sc = new Search(lbshwuser.Text);
            sc.MdiParent = this;
            sc.Show();
        }
		 private void EditProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            EditProfile EP = new EditProfile(lbshwuser.Text);
            EP.MdiParent = this;
            EP.Show();
           
        }
	private void AIRLINE_BOOKING_MGMT_SYSTEM_LOAD(object sender, EventArgs e)
        {
            lbshwuser.Text = uname;
        }
        public void DisposeAllButThis()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
                return;
            }
        }
        private void lnklbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            USER_LOGIN ul = new USER_LOGIN();
            ul.Show();
        }
    }
}
