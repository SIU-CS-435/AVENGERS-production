using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace atm.USER_FORMS
{
    public partial class CancelFrm : Form
    {
        //float x;
        string a;
        int nofseats = 0;
        string fare =string.Empty;
        int noofdays = 0;
        //int selectedseats = 0;

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
            try
            {
                if (tbbid.Text == "")
                {
                    MessageBox.Show("Enter Booking ID", "Error");
                    
                }
                else
                {
                    string conn = "Data Source=DESKTOP-OPN87JD\\SQLEXPRESS;Initial Catalog=ExpDB;Integrated Security=True";
                    SqlConnection sc = null;
                    sc = new SqlConnection(conn);
                    sc.Open();
                    SqlCommand cmd = new SqlCommand("get_doj", sc);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Booking_id", tbbid.Text);
                    cmd.Parameters.AddWithValue("@email", a);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (sdr.FieldCount == 1)
                        {

                            if (Convert.ToDateTime(sdr["DOJ"]) > DateTime.Now.Date)
                            {
                                pnlconfirm.Show();
                                //SqlCommand cmd1 = new SqlCommand("get_datediff", sc);
                                //cmd1.CommandType = CommandType.StoredProcedure;
                                //cmd1.Parameters.AddWithValue("@Booking_id", tbbid.Text);
                                //SqlDataReader sdr1 = cmd1.ExecuteReader();
                                string q1 = "SELECT DATEDIFF(DAY,GETDATE(),DOJ) FROM BOOKING_INFO WHERE BOOKING_ID='" + tbbid.Text + "'";
                                DataTable dt2 = new DataTable();
                                dt2 = dataaccess_layer.GetRecords(q1);
                                noofdays = int.Parse(dt2.Rows[0][0].ToString());
                                DataTable dt = new DataTable();
                                string q5 = "SELECT b.BOOKING_ID,b.F_NO,b.BOOKING_DT,b.DOJ,f.SRC,f.DEST,b.SEAT_BOOK,b.PRICE FROM BOOKING_INFO b JOIN FLIGHT_MASTER f ON b.F_NO=f.F_NO WHERE b.BOOKING_ID='" + tbbid.Text + "'";
                                dt = dataaccess_layer.GetRecords(q5);
                                lbtcbid.Text = dt.Rows[0][0].ToString();
                                lbtcfid.Text = dt.Rows[0][1].ToString();
                                lbtcbookdat.Text = dt.Rows[0][2].ToString();
                                lbtcjdat.Text = dt.Rows[0][3].ToString();
                                lbtcfrm.Text = dt.Rows[0][4].ToString();
                                lbtcto.Text = dt.Rows[0][5].ToString();
                                //lbtcnoseats.Text = dt.Rows[0][6].ToString();
                                nofseats=int.Parse(dt.Rows[0][6].ToString());
                                cmbnoofseats.Text = nofseats.ToString();
                                for (int i = nofseats; i > 0; i--)
                                {
                                    cmbnoofseats.Items.Add(i);
                                }
                                fare = dt.Rows[0][7].ToString();
                                lbtctotfare.Text = dt.Rows[0][7].ToString();
                                if (noofdays >= 10)
                                {
                                    lbtccanchrg.Text = (0.1 * (float.Parse(lbtctotfare.Text))).ToString();
                                }
                                else if (noofdays >= 5 && noofdays < 10)
                                {
                                    lbtccanchrg.Text = (0.2 * (float.Parse(lbtctotfare.Text))).ToString();
                                }
                                else if (noofdays >= 1 && noofdays < 5)
                                {
                                    lbtccanchrg.Text = (0.5 * (float.Parse(lbtctotfare.Text))).ToString();
                                }
                                lbtcrefund.Text = ((float.Parse(lbtctotfare.Text)) - (float.Parse(lbtccanchrg.Text))).ToString();
                            }
                            else if (Convert.ToDateTime(sdr["DOJ"]) < DateTime.Now.Date)
                            {
                                MessageBox.Show("Journey Date already Passed", "Error");
                                tbbid.Text = "";
                            }
                            else if (Convert.ToDateTime(sdr["DOJ"]) == DateTime.Now.Date)
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
                }
            }
            catch (Exception ex)
            {
                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                MessageBox.Show("Internal Error Occured");
                this.BeginInvoke(new MethodInvoker(Close));
            }

            
        }

        private void CancelFrm_Load(object sender, EventArgs e)
        {
            pnlconfirm.Hide();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string q1 = "UPDATE s SET No_of_Seats=No_of_Seats+" + cmbnoofseats.SelectedItem + " FROM SEATS_AVAILABLE s JOIN BOOKING_INFO b ON b.F_NO=s.F_NO";
            if (nofseats.ToString() == cmbnoofseats.Text)
            {
                string q = "DELETE FROM BOOKING_INFO WHERE BOOKING_ID='" + lbtcbid.Text + "'";
                dataaccess_layer.ProcessQuery(q);
                MessageBox.Show("Cancellation Successful");
                MessageBox.Show("Refunded Amount is: " + lbtcrefund.Text);
                this.Close();
            }
            else
            {
                try
                {
                    string q = "update Booking_info set SEAT_BOOK='" + (nofseats - int.Parse(cmbnoofseats.Text)) + "',price='" + (float.Parse(fare) - float.Parse(lbtccanchrg.Text)) + "'where Booking_id='" + lbtcbid.Text+"'";
                    dataaccess_layer.ProcessQuery(q);
                    MessageBox.Show("Cancellation Successful");
                    MessageBox.Show("Refunded Amount is: " + lbtcrefund.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                    MessageBox.Show("Internal Error Occured");
                    this.BeginInvoke(new MethodInvoker(Close));
                }
            }
        }

        private void btncncl_Click(object sender, EventArgs e)
        {
            pnlconfirm.Hide();
        }

        private void cmbnoofseats_Leave(object sender, EventArgs e)
        {
            float singleticket = float.Parse(fare) / nofseats;
            float selectedticketprice = singleticket * (int.Parse(cmbnoofseats.Text));
            lbtctotfare.Text = selectedticketprice.ToString();
            if (noofdays >= 10)
            {
                lbtccanchrg.Text = (0.1 * (float.Parse(lbtctotfare.Text))).ToString();
            }
            else if (noofdays >= 5 && noofdays < 10)
            {
                lbtccanchrg.Text = (0.2 * (float.Parse(lbtctotfare.Text))).ToString();
            }
            else if (noofdays >= 1 && noofdays < 5)
            {
                lbtccanchrg.Text = (0.5 * (float.Parse(lbtctotfare.Text))).ToString();
            }
            lbtcrefund.Text = ((float.Parse(lbtctotfare.Text)) - (float.Parse(lbtccanchrg.Text))).ToString();
        }

       

       

       
    }
}
