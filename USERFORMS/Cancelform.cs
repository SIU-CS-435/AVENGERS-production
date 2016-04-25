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
    public partial class CancelFrm : Form
    {
        string a;
        public CancelFrm()
        {
            InitializeComponent();
        }
        public CancelFrm(string s,string b)
        {
            InitializeComponent();
            a = s;
            tbbid.Text = b;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
                    string q = "SELECT b.DOJ FROM BOOKING_INF b JOIN CUSTOMER_INFO c ON b.CID=c.CID WHERE b.BOOKING_ID='" + tbbid.Text + "' AND c.EMAIL='" + a + "' ";
                    DataTable dt1 = new DataTable();
                    dt1 = dataaccess_layer.GetRecords(q);
                    if (dt1.Rows.Count == 1)
                    {
                        if (Convert.ToDateTime(dt1.Rows[0]["doj"]) > DateTime.Now.Date)
                        {
                            pnlconfirm.Show();
                                DataTable dt = new DataTable();
                                string q5 = "SELECT b.BOOKING_ID,b.F_NO,b.BOOKING_DT,b.DOJ,f.SRC,f.DEST,b.SEAT_BOOK,b.PRICE FROM BOOKING_INF b JOIN FLIGHT_MASTER f ON b.F_NO=f.F_NO WHERE b.BOOKING_ID='" + tbbid.Text + "'";
                                dt = dataaccess_layer.GetRecords(q5);
                                lbtcbid.Text = dt.Rows[0][0].ToString();
                                lbtcfid.Text = dt.Rows[0][1].ToString();
                                lbtcbookdat.Text = dt.Rows[0][2].ToString();
                                lbtcjdat.Text = dt.Rows[0][3].ToString();
                                lbtcfrm.Text = dt.Rows[0][4].ToString();
                                lbtcto.Text = dt.Rows[0][5].ToString();
                                lbtcnoseats.Text = dt.Rows[0][6].ToString();
                                lbtctotfare.Text = dt.Rows[0][7].ToString();
                                lbtccanchrg.Text = (0.1 * (Convert.ToInt32(lbtctotfare.Text))).ToString();
                        }
                        else if (Convert.ToDateTime(dt1.Rows[0]["doj"]) < DateTime.Now.Date)
                        {
                            MessageBox.Show("Journey Date already Passed", "Error");
                            tbbid.Text = "";
                        }
                        else if (Convert.ToDateTime(dt1.Rows[0]["doj"]) == DateTime.Now.Date)
                        {
                            MessageBox.Show("Cannot cancel on the journey day", "Error");
                            tbbid.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Booking Id", "Error");
                        tbbid.Text = "";
                    }   
        }

        private void CancelFrm_Load(object sender, EventArgs e)
        {
            pnlconfirm.Hide();
        }
    }
}
