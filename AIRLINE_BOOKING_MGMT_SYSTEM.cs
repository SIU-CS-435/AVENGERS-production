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
    public partial class air_tic_rs : Form
    {
        string uname = "";
        public air_tic_rs()
        {
            InitializeComponent();
        }
        public air_tic_rs(string s )
        {
            uname = s;
            InitializeComponent();
        }

      

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            Search sc = new Search(lbshwuser.Text);
            sc.MdiParent = this;
            sc.Show();
        }

        private void eDITPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            EditProfile EP = new EditProfile(lbshwuser.Text);
            EP.MdiParent = this;
            EP.Show();
        }

        private void bOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            Booking b = new Booking(lbshwuser.Text);
            b.MdiParent = this;
            b.Show();
        }

        private void cANCELLATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            atm.USER_FORMS.CancelFrm cf = new atm.USER_FORMS.CancelFrm(lbshwuser.Text,"");
            cf.MdiParent = this;
            cf.Show();
           
        }

        private void air_tic_rs_Load(object sender, EventArgs e)
        {
            lbshwuser.Text = uname;
            gb1.Hide();
            gb2.Hide();
            gb3.Hide();
            gb4.Hide();
            string s="select R_id,Reservation_date from Reserve_Info where cust_email='"+uname+"'";
            DataTable dt = dataaccess_layer.GetRecords(s);
            if (dt.Rows.Count == 1)
            {
                gb1.Show();
                TimeSpan ts = DateTime.Now.Date.Subtract(Convert.ToDateTime(dt.Rows[0][1]).Date);
                if (ts.Days <= 7)
                {
                    lblreservation1.Text = dt.Rows[0][0].ToString();
                    lbldate1.Text = dt.Rows[0][1].ToString();
                }
            }
            if (dt.Rows.Count > 1)
            {
                gb1.Show();
                gb2.Show();
                TimeSpan ts = DateTime.Now.Date.Subtract(Convert.ToDateTime(dt.Rows[0][1]).Date);
                TimeSpan ts1 = DateTime.Now.Date.Subtract(Convert.ToDateTime(dt.Rows[1][1]).Date);
                if (ts.Days <= 7)
                {
                    lblreservation1.Text = dt.Rows[0][0].ToString();
                    lbldate1.Text = dt.Rows[0][1].ToString();
                }
                if (ts1.Days <= 7)
                {
                    lblreservation2.Text = dt.Rows[1][0].ToString();
                    lbldate2.Text = dt.Rows[1][1].ToString();
                }
            }
            string s1 = "SELECT a.src, a.dest, b.DOJ FROM Flight_master AS a INNER JOIN BOOKING_INFO AS b ON a.F_No = b.F_NO WHERE (b.CID =(SELECT cid FROM Customer_Info WHERE (Email = '"+uname+"')))";
            DataTable dt1 = dataaccess_layer.GetRecords(s1);
            if (dt1.Rows.Count == 1)
            {
                gb3.Show();
                lbsrc.Text = dt1.Rows[0][0].ToString();
                lbdest.Text = dt1.Rows[0][1].ToString();
                TimeSpan ts2 = (Convert.ToDateTime(dt1.Rows[0][2]).Date).Subtract(DateTime.Now.Date);
                lbdays.Text = ts2.Days.ToString();
            }
            if (dt1.Rows.Count > 1)
            {
                gb3.Show();
                lbsrc.Text = dt1.Rows[0][0].ToString();
                lbdest.Text = dt1.Rows[0][1].ToString();
                TimeSpan ts2 = (Convert.ToDateTime(dt1.Rows[0][2]).Date).Subtract(DateTime.Now.Date);
                lbdays.Text = ts2.Days.ToString();
                gb4.Show();
                lblsrc1.Text = dt1.Rows[1][0].ToString();
                lbldest1.Text = dt1.Rows[1][1].ToString();
                TimeSpan ts3 = (Convert.ToDateTime(dt1.Rows[1][2]).Date).Subtract(DateTime.Now.Date);
                lbldays1.Text = ts3.Days.ToString();
            }
            if ((dt.Rows.Count == 0) && (dt1.Rows.Count == 0))
            {
                gbalerts.Hide();
            }
        }
        public void DisposeAllButThis()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
                return;
            }
        }

        private void bOOKEDTICKETSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            BOOKED_TICKET bt = new BOOKED_TICKET(lbshwuser.Text);
            bt.MdiParent = this;
            bt.Show();
            
        }

        private void lnklblogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            USER_LOGIN ul = new USER_LOGIN();
            ul.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rESERVATIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            Reservations r = new Reservations(lbshwuser.Text);
            r.Show();
        }

        private void btndeactivate_Click(object sender, EventArgs e)
        {
            string s = "delete from customer_info where email='" + uname + "'";
            dataaccess_layer.ProcessQuery(s);
            USER_LOGIN ul = new USER_LOGIN();
            ul.Show();
        }

        
    }
}
