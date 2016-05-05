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
        int count = 0;
        string a;
        int nofseats = 0;
        string fare = string.Empty;
        int noofdays = 0;
        //int selectedseats = 0;

        public CancelFrm()
        {
            InitializeComponent();
        }
        public CancelFrm(string s, string b)
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
                                string q5 = "SELECT b.BOOKING_ID,b.F_NO,b.BOOKING_DT,b.DOJ,f.SRC,f.DEST,b.SEAT_BOOK,b.PRICE,b.Ticket_type FROM BOOKING_INFO b JOIN FLIGHT_MASTER f ON b.F_NO=f.F_NO WHERE b.BOOKING_ID='" + tbbid.Text + "'";
                                dt = dataaccess_layer.GetRecords(q5);
                                lbtcbid.Text = dt.Rows[0][0].ToString();
                                lbtcfid.Text = dt.Rows[0][1].ToString();
                                lbtcbookdat.Text = dt.Rows[0][2].ToString();
                                lbtcjdat.Text = dt.Rows[0][3].ToString();
                                lbtcfrm.Text = dt.Rows[0][4].ToString();
                                lbtcto.Text = dt.Rows[0][5].ToString();
                                lblticket_type.Text = dt.Rows[0][8].ToString();
                                //lbtcnoseats.Text = dt.Rows[0][6].ToString();
                                nofseats = int.Parse(dt.Rows[0][6].ToString());
                                //cmbnoofseats.Text = nofseats.ToString();
                               // for (int i = nofseats; i > 0; i--)
                                //{
                                  //  cmbnoofseats.Items.Add(i);
                                //}
                                string CountPassengers = "select passenger1,passenger2,passenger3,passenger4,passenger5 from booking_info where booking_id='" + lbtcbid.Text + "'";
                                DataTable dt1 = dataaccess_layer.GetRecords(CountPassengers);
                                for (int j = 0; j < 5; j++)
                                {
                                    if (dt1.Rows[0][j].ToString() != "")
                                    {
                                        count++;
                                    }
                                }
                                fare = dt.Rows[0][7].ToString();
                                lbtctotfare.Text = ((float.Parse(fare)) / count).ToString() ;
                                if (noofdays >= 10)
                                {
                                    lbtccanchrg.Text = (0.1 * (float.Parse(fare))/count).ToString();
                                }
                                else if (noofdays >= 5 && noofdays < 10)
                                {
                                    lbtccanchrg.Text = (0.2 * (float.Parse(fare))/count).ToString();
                                }
                                else if (noofdays >= 1 && noofdays < 5)
                                {
                                    lbtccanchrg.Text = (0.5 * (float.Parse(fare))/count).ToString();
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
            count = 0;
            pnlconfirm.Hide();
            pnlnext.Hide();
            //dgvcancel.Columns.Clear();

        }
        private void btncncl_Click(object sender, EventArgs e)
        {
            pnlconfirm.Hide();
        }



        private void btnnext_Click(object sender, EventArgs e)
        {
            cbPassenger1.Hide();
            cbPassenger2.Hide();
            cbPassenger3.Hide();
            cbPassenger4.Hide();
            cbPassenger5.Hide();
            btnpanelcancel.Text ="CANCEL";
            pnlnext.Show();
            string s = "SELECT Passenger1,Passenger2,Passenger3,Passenger4,Passenger5 from Booking_Info where Booking_id='" + lbtcbid.Text + "'";
            DataTable dt = new DataTable();
            dt = dataaccess_layer.GetRecords(s);
            if (dt.Rows[0][0].ToString() != "")
            {
                cbPassenger1.Show();
                cbPassenger1.Text = dt.Rows[0][0].ToString();
            }
            if (dt.Rows[0][1].ToString() != "")
            {
                cbPassenger2.Show();
                cbPassenger2.Text = dt.Rows[0][1].ToString();
            }
            if (dt.Rows[0][2].ToString() != "")
            {
                cbPassenger3.Show();
                cbPassenger3.Text = dt.Rows[0][2].ToString();
            }
            if (dt.Rows[0][3].ToString() != "")
            {
                cbPassenger4.Show();
                cbPassenger4.Text = dt.Rows[0][3].ToString();
            }
            if (dt.Rows[0][4].ToString() != "")
            {
                cbPassenger5.Show();
                cbPassenger5.Text = dt.Rows[0][4].ToString();
            }
        }

        private void BtnConfirm_Click_1(object sender, EventArgs e)
        {
           
            if (cbPassenger1.Checked)
            {
                string s = "update Booking_info set passenger1='' where booking_id='" + lbtcbid.Text + "'";
                if(tb_ticket_type.Text=="Business")
                {
                string s1="update s set No_of_seats_Business=No_of_seats_Business+1 from seats_available s join booking_info b on b.f_no=s.f_no where booking_id='"+lbtcbid.Text+"'";
                dataaccess_layer.ProcessQuery(s1);
                }
                dataaccess_layer.ProcessQuery(s);
            }
            if (cbPassenger2.Checked)
            {
                string s = "update Booking_info set passenger2='' where booking_id='" + lbtcbid.Text + "'";
                if (tb_ticket_type.Text == "Business")
                {
                    string s1 = "update s set No_of_seats_Business=No_of_seats_Business+1 from seats_available s join booking_info b on b.f_no=s.f_no where booking_id='" + lbtcbid.Text + "'";
                    dataaccess_layer.ProcessQuery(s1);
                }
                dataaccess_layer.ProcessQuery(s);
            }
            if (cbPassenger3.Checked)
            {
                string s = "update Booking_info set passenger3='' where booking_id='" + lbtcbid.Text + "'";
                if (tb_ticket_type.Text == "Business")
                {
                    string s1 = "update s set No_of_seats_Business=No_of_seats_Business+1 from seats_available s join booking_info b on b.f_no=s.f_no where booking_id='" + lbtcbid.Text + "'";
                    dataaccess_layer.ProcessQuery(s1);
                }
                dataaccess_layer.ProcessQuery(s);
            }
            if (cbPassenger4.Checked)
            {
                string s = "update Booking_info set passenger4='' where booking_id='" + lbtcbid.Text + "'";
                if (tb_ticket_type.Text == "Business")
                {
                    string s1 = "update s set No_of_seats_Business=No_of_seats_Business+1 from seats_available s join booking_info b on b.f_no=s.f_no where booking_id='" + lbtcbid.Text + "'";
                    dataaccess_layer.ProcessQuery(s1);
                }
                dataaccess_layer.ProcessQuery(s);
            }
            if (cbPassenger5.Checked)
            {
                string s = "update Booking_info set passenger5='' where booking_id='" + lbtcbid.Text + "'";
                if (tb_ticket_type.Text == "Business")
                {
                    string s1 = "update s set No_of_seats_Business=No_of_seats_Business+1 from seats_available s join booking_info b on b.f_no=s.f_no where booking_id='" + lbtcbid.Text + "'";
                    dataaccess_layer.ProcessQuery(s1);
                }
                dataaccess_layer.ProcessQuery(s);
            }
            string passengers = "select passenger1,passenger2,passenger3,passenger4,passenger5 from booking_info where booking_id='" + lbtcbid.Text + "'";
            DataTable dt = new DataTable();
            dt = dataaccess_layer.GetRecords(passengers);
            if (dt.Rows[0][0].ToString() == ""&&dt.Rows[0][1].ToString()==""&&dt.Rows[0][3].ToString()==""&&dt.Rows[0][4].ToString()=="")
            {
                string s = "delete from booking_info where booking_id='" + lbtcbid.Text + "'";
                dataaccess_layer.ProcessQuery(s);
            }
            this.Close();
        }

        private void btnpanelcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
