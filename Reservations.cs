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
    public partial class Reservations : Form
    {
        string email = string.Empty;
        public Reservations(string s)
        {
            InitializeComponent();
            email = s; 
        }
        private void Reservations_Load(object sender, EventArgs e)
        {
            string s = "select Reservation_date,R_id from Reserve_Info where cust_email='" + email + "'";
            DataTable dt1 = dataaccess_layer.GetRecords(s);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                TimeSpan ts =  DateTime.Now.Date.Subtract(Convert.ToDateTime(dt1.Rows[i][0]));
                int no_of_days=ts.Days;
                if(no_of_days>7)
                {
                    string s1="Delete from Reserve_Info where R_id='"+dt1.Rows[i][1]+"'";
                    dataaccess_layer.ProcessQuery(s1);
                }
            }
            DataTable dt = new DataTable();
            string conn = "Data Source=DESKTOP-OPN87JD\\SQLEXPRESS;Initial Catalog=ExpDB;Integrated Security=True";
            SqlConnection sc = null;
            sc = new SqlConnection(conn);
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand("Reservations", sc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Columns.Add("Reservation ID");
                dt.Columns.Add("Flight Number");
                dt.Columns.Add("Airlines");
                dt.Columns.Add("Source");
                dt.Columns.Add("Date Of Journey");
                dt.Columns.Add("Departure time");
                dt.Columns.Add("Destination");
                dt.Columns.Add("Price");
                dt.Columns.Add("Number Of Passengers");
                dt.Columns.Add("Passenger 1");
                dt.Columns.Add("Passenger 2");
                dt.Columns.Add("Passenger 3");
                dt.Columns.Add("Passenger 4");
                dt.Columns.Add("Passenger 5");
                while (sdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Reservation ID"]=sdr["R_id"];
                    dr["Flight Number"] = sdr["F_NO"];
                    dr["Airlines"] = sdr["A_NAME"];
                    dr["Source"] = sdr["src"];
                    dr["Date Of Journey"] = sdr["DOJ"];
                    dr["Destination"] = sdr["dest"];
                    dr["Departure time"] = sdr["DEPART_TIME"];
                    dr["Price"] = sdr["Fare"];
                    dr["Number Of Passengers"] = sdr["No_of_seats"];
                    dr["Passenger 1"] = sdr["Passenger1"];
                    dr["Passenger 2"] = sdr["Passenger2"];
                    dr["Passenger 3"] = sdr["Passenger3"];
                    dr["Passenger 4"] = sdr["Passenger4"];
                    dr["Passenger 5"] = sdr["Passenger5"];
                    dt.Rows.Add(dr);
                    dgreservations.DataSource = null;
                    dgreservations.DataSource = dt;
                    DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                    Editlink.UseColumnTextForLinkValue = true;
                    Editlink.HeaderText = "Book";
                    Editlink.DataPropertyName = "lnkColumn";
                    Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                    Editlink.Text = "Book";
                    if (dgreservations.Columns.Count == 14)
                        dgreservations.Columns.Add(Editlink);
                }
            }
            catch (Exception ex)
            {
                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                MessageBox.Show("Internal Error Occured", "Sorry");
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgreservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 14)
                {
                    DataGridViewRow row = dgreservations.CurrentCell.OwningRow;
                    var result = MessageBox.Show("Are you sure you want to book?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string q2 = "SELECT CID FROM CUSTOMER_INFO WHERE EMAIL='" + email + "'";
                        DataTable dt = new DataTable();
                        dt = dataaccess_layer.GetRecords(q2);
                        string fno = "SELECT MAX(S_NO) FROM BOOKING_INFO";
                        DataTable d = new DataTable();
                        d = dataaccess_layer.GetRecords(fno);
                        string c = d.Rows[0][0].ToString();
                        if (c == "")
                        {
                            c = "1";
                        }
                        string bi = "B" + c;
                        string q = "INSERT INTO BOOKING_INFO (BOOKING_ID,BOOKING_DT,F_NO,CID,PRICE,SEAT_BOOK,DOJ) VALUES('" + bi + "','" + DateTime.Now.ToShortDateString() + "','" + dgreservations.Rows[e.RowIndex].Cells[1].Value.ToString() + "'," + Convert.ToInt16(dt.Rows[0]["cid"]) + "," + dgreservations.Rows[e.RowIndex].Cells[7].Value.ToString() + "," + dgreservations.Rows[e.RowIndex].Cells[8].Value.ToString() + ",'" + dgreservations.Rows[e.RowIndex].Cells[4].Value.ToString() + "') ";
                        dataaccess_layer.ProcessQuery(q);
                        string q1 = "Delete from Reserve_Info where R_id='" + dgreservations.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                        dataaccess_layer.ProcessQuery(q1);
                        MessageBox.Show("Booking Successful");
                        this.Close();
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
    }
}
