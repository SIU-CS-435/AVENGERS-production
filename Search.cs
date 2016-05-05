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
    public partial class Search : Form
    {
        string a=string.Empty;
        string F_NO, A_NAME, SRC, DEPART_TIME, DEST, FARE, No_of_Seats, DOJ;
        public Search(string s)
        {
            InitializeComponent();
            a = s;
        }
        public Search()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbSource.Text == "" || cmbDestination.Text == "")
                {
                    MessageBox.Show("Source or Destination not selected", "Error");
                }
                else if (cmbseats.Text == "")
                {
                    MessageBox.Show("Enter No Of Seats", "Error");
                }
                else
                {
                    int i = bussiness_accesslayer.txtseats_Validating(cmbseats.Text);
                    int j = bussiness_accesslayer.jour_date(dtpdate.Value.Date);
                    if (i == 0 && j == 0)
                    {
                        //string q = "SELECT fm.F_NO FlightNumber,am.A_NAME AirlineName,fm.SRC Source,fm.DEPART_TIME DepartureTime,fm.DEST GoingTo,fm.FARE Fare FROM FLIGHT_MASTER fm JOIN AIRLINES_MASTER am ON fm.F_No=am.F_NO JOIN SEATS_AVAILABLE sa ON fm.F_NO=sa.F_NO WHERE SRC='" + cmbSource.SelectedItem.ToString() + "' AND DEST='" + cmbDestination.SelectedItem.ToString() + "' AND No_of_Seats>=" + tbseats.Text + "";
                        DataTable dt = new DataTable();
                        string conn = "Data Source=DESKTOP-OPN87JD\\SQLEXPRESS;Initial Catalog=ExpDB;Integrated Security=True";
                        SqlConnection sc = null;
                        sc = new SqlConnection(conn);
                        if (rbeconomy.Checked)
                        {
                            try
                            {
                                sc.Open();
                                SqlCommand cmd = new SqlCommand("search", sc);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("src", cmbSource.Text);
                                cmd.Parameters.AddWithValue("dest", cmbDestination.Text);
                                cmd.Parameters.AddWithValue("No_of_Seats", cmbseats.Text);
                                SqlDataReader sdr = cmd.ExecuteReader();
                                dt.Columns.Add("Flight Number");
                                dt.Columns.Add("Airlines");
                                dt.Columns.Add("Source");
                                dt.Columns.Add("Departure time");
                                dt.Columns.Add("Destination");
                                dt.Columns.Add("Price");
                                while (sdr.Read())
                                {
                                    DataRow dr = dt.NewRow();
                                    dr["Flight Number"] = sdr["FlightNumber"];
                                    dr["Airlines"] = sdr["AirlineName"];
                                    dr["Source"] = sdr["Source"];
                                    dr["Departure time"] = sdr["DepartureTime"];
                                    dr["Destination"] = sdr["GoingTo"];
                                    dr["Price"] = sdr["Fare"];
                                    dt.Rows.Add(dr);
                                }
                                //dgviewsearch.DataSource = dt;
                                dgviewsearch.DataSource = null;
                                dgviewsearch.DataSource = dt;
                                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                                Editlink.UseColumnTextForLinkValue = true;
                                Editlink.HeaderText = "Reserve";
                                Editlink.DataPropertyName = "lnkColumn";
                                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                                Editlink.Text = "Reserve";
                                if (dgviewsearch.Columns.Count == 6)
                                    dgviewsearch.Columns.Add(Editlink);

                            }
                            catch (Exception ex)
                            {
                                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                                MessageBox.Show("Internal Error Occured", "Sorry");
                                this.BeginInvoke(new MethodInvoker(Close));
                            }
                        }
                        else if (rbbusiness.Checked)
                        {
                            try
                            {
                                sc.Open();
                                SqlCommand cmd = new SqlCommand("searchBusiness", sc);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("src", cmbSource.Text);
                                cmd.Parameters.AddWithValue("dest", cmbDestination.Text);
                                cmd.Parameters.AddWithValue("No_of_Seats", cmbseats.Text);
                                SqlDataReader sdr = cmd.ExecuteReader();
                                dt.Columns.Add("Flight Number");
                                dt.Columns.Add("Airlines");
                                dt.Columns.Add("Source");
                                dt.Columns.Add("Departure time");
                                dt.Columns.Add("Destination");
                                dt.Columns.Add("Price");
                                while (sdr.Read())
                                {
                                    DataRow dr = dt.NewRow();
                                    dr["Flight Number"] = sdr["FlightNumber"];
                                    dr["Airlines"] = sdr["AirlineName"];
                                    dr["Source"] = sdr["Source"];
                                    dr["Departure time"] = sdr["DepartureTime"];
                                    dr["Destination"] = sdr["GoingTo"];
                                    dr["Price"] = sdr["Fare"];
                                    dt.Rows.Add(dr);
                                }
                                //dgviewsearch.DataSource = dt;
                                dgviewsearch.DataSource = null;
                                dgviewsearch.DataSource = dt;
                                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                                Editlink.UseColumnTextForLinkValue = true;
                                Editlink.HeaderText = "Reserve";
                                Editlink.DataPropertyName = "lnkColumn";
                                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                                Editlink.Text = "Reserve";
                                if (dgviewsearch.Columns.Count == 6)
                                    dgviewsearch.Columns.Add(Editlink);

                            }
                            catch (Exception ex)
                            {
                                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                                MessageBox.Show("Internal Error Occured", "Sorry");
                                this.BeginInvoke(new MethodInvoker(Close));
                            }
                        }
            
                        //dt = dataaccess_layer.GetRecords(q);
                        
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No flights Available", "Sorry");
                            dgviewsearch.Columns.Clear();
                        }
                        //else
                        //{
                         //   dgviewsearch.DataSource = null;
                            //dgviewsearch.DataSource = dt;
                           // DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn(); Editlink.UseColumnTextForLinkValue = true;
                            //Editlink.HeaderText = "Book";
                            //Editlink.DataPropertyName = "lnkColumn";
                            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                            //Editlink.Text = "Book";
                            //if (dgviewsearch.Columns.Count == 6)
                            //    dgviewsearch.Columns.Add(Editlink);
                        //}
                    }
                    else
                    {
                        if (i == 1)
                            MessageBox.Show("Seats count should be in between 1 and 20", "Invalid no of Seats Requested");
                        if (i == 2)
                            MessageBox.Show("Seats Should be in Number Format", "Invalid Type Entry");
                        if (j == 1)
                            MessageBox.Show("Date of journey should be a later date", "Invalid DOJ");
                        dgviewsearch.Columns.Clear();
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

 private void Search_Load(object sender, EventArgs e)
 {
     try
     {
         cmbseats.Text = '0'.ToString();
         for (int i = 1; i < 6; i++)
         {
             cmbseats.Items.Add(i);
         }
         dtpdate.MinDate = DateTime.Now.Date;
         pnlpassengerinfo.Hide();
         pnlreserve.Hide();
         //pnlbook.Hide();
         //pnlconfirmed.Hide();
         cmbSource.Text = "Select Source";
         cmbDestination.Text = "Select Destination";
         string q = "SELECT SRC FROM FLIGHT_MASTER GROUP BY SRC";
         DataTable dt = new DataTable();
         dt = dataaccess_layer.GetRecords(q);
         for (int i = 0; i < dt.Rows.Count; i++)
         {
             cmbSource.Items.Add(dt.Rows[i][0].ToString());
         }
     }
     catch (Exception ex)
     {
         bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
         MessageBox.Show("Internal Error Occured");
         this.BeginInvoke(new MethodInvoker(Close));
     }

 }

 private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
 {
     lb_tickettype.Hide();
     rbbusiness.Hide();
     rbeconomy.Hide();
     try
     {
         if (e.ColumnIndex == 6)
         {
             if (a == "")
             {
                 MessageBox.Show("Please Login to Reserve Tickets");
                 USER_LOGIN ul = new USER_LOGIN();
                 ul.Show();
             }
             else
             {
                 DataGridViewRow row = dgviewsearch.CurrentCell.OwningRow;
                 pnlpassengerinfo.Show();
                 cmbseats.Visible = false;
                 F_NO = row.Cells[0].Value.ToString();
                 A_NAME = row.Cells[1].Value.ToString();
                 SRC = row.Cells[2].Value.ToString();
                 DEPART_TIME = row.Cells[3].Value.ToString();
                 DEST = row.Cells[4].Value.ToString();
                 FARE = row.Cells[5].Value.ToString();
                 No_of_Seats = cmbseats.Text;
                 DOJ = dtpdate.Text;
                 if (cmbseats.Text == '1'.ToString())
                 {
                     tbpassenger2.Visible = false;
                     lblpassenger2.Visible = false;
                     tbpassenger3.Visible = false;
                     lblpassenger3.Visible = false;
                     tbpassenger4.Visible = false;
                     lblpassenger4.Visible = false;
                     tbpassenger5.Visible = false;
                     lblpassenger5.Visible = false;
                 }
                 if (cmbseats.Text == '2'.ToString())
                 {
                     tbpassenger3.Visible = false;
                     lblpassenger3.Visible = false;
                     tbpassenger4.Visible = false;
                     lblpassenger4.Visible = false;
                     tbpassenger5.Visible = false;
                     lblpassenger5.Visible = false;
                 }
                 if (cmbseats.Text == '3'.ToString())
                 {
                     tbpassenger4.Visible = false;
                     lblpassenger4.Visible = false;
                     tbpassenger5.Visible = false;
                     lblpassenger5.Visible = false;
                 }
                 if (cmbseats.Text == '4'.ToString())
                 {
                     tbpassenger5.Visible = false;
                     lblpassenger5.Visible = false;
                 }
                 //MessageBox.Show(DOJ);
                 //string sou= row.Cells[2].Value.ToString();
                 //string time = row.Cells[3].Value.ToString();
                 //string des = row.Cells[4].Value.ToString();
                 //string airname = row.Cells[1].Value.ToString();
                 //lbseats.Text = tbseats.Text;
                 //lbbookingdate.Text = DateTime.Now.ToShortDateString();
                 //lbdoj.Text = dtpdate.Value.Date.ToString();
                 //int pr = ((Convert.ToInt16(row.Cells[5].Value)) * Convert.ToInt16(tbseats.Text));
                 //lbtotalprice.Text = pr.ToString();
                 //lbairlinename.Text = airname;
                 //lbdestination.Text = des;
                 //lbtime.Text = time;
                 //lbsource.Text = sou;
                 //string f = row.Cells[0].Value.ToString();
                 //lbflightno.Text = f;
                 //pnlbook.Show();
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
 private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
 {
     cmbDestination.Text="Select Destination";
     DataTable dt = new DataTable();
     string q = "SELECT DISTINCT DEST FROM FLIGHT_MASTER WHERE DEST<>'" + cmbSource.Text + "'";
     dt = dataaccess_layer.GetRecords(q);
     cmbDestination.Items.Clear();
     for (int i = 0; i < dt.Rows.Count; i++)
     {
         cmbDestination.Items.Add(dt.Rows[i][0].ToString());
     } 
 }

 private void btnclose_Click(object sender, EventArgs e)
 {
     this.Close();
 }
 private void btnreserve_Click_1(object sender, EventArgs e)
 {
     string passenger1name=string.Empty, passenger2name=string.Empty, passenger3name=string.Empty, passenger4name=string.Empty, passenger5name=string.Empty;
     btnclose1.Visible = false;
     if (tbpassenger1.Text != "")
     {
         passenger1name = tbpassenger1.Text;
     }
     if (tbpassenger2.Text != "")
     {
         passenger2name = tbpassenger2.Text;
     }
     if (tbpassenger3.Text != "")
     {
         passenger3name = tbpassenger3.Text;
     }
     if (tbpassenger4.Text != "")
     {
         passenger4name = tbpassenger4.Text;
     }
     if (tbpassenger5.Text != "")
     {
         passenger5name = tbpassenger5.Text;
     }
     try
     {
         DataTable dt = new DataTable();
         string conn = "Data Source=DESKTOP-OPN87JD\\SQLEXPRESS;Initial Catalog=ExpDB;Integrated Security=True";
         SqlConnection sc = null;
         sc = new SqlConnection(conn);
         sc.Open();
         if (rbeconomy.Checked)
         {
             SqlCommand cmd = new SqlCommand("insertintoreserve", sc);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@F_NO", F_NO);
             cmd.Parameters.AddWithValue("@Reserve_date", DateTime.Now.ToShortDateString());
             cmd.Parameters.AddWithValue("@A_NAME", A_NAME);
             cmd.Parameters.AddWithValue("@SRC", SRC);
             cmd.Parameters.AddWithValue("@DEPART_TIME", DEPART_TIME);
             cmd.Parameters.AddWithValue("@DEST", DEST);
             cmd.Parameters.AddWithValue("@FARE", FARE);
             cmd.Parameters.AddWithValue("@NOS", No_of_Seats);
             cmd.Parameters.AddWithValue("@P1", passenger1name);
             cmd.Parameters.AddWithValue("@P2", passenger2name);
             cmd.Parameters.AddWithValue("@P3", passenger3name);
             cmd.Parameters.AddWithValue("@P4", passenger4name);
             cmd.Parameters.AddWithValue("@P5", passenger5name);
             cmd.Parameters.AddWithValue("@DOJ", DOJ);
             cmd.Parameters.AddWithValue("@Ticket_type", "Economy");
             cmd.Parameters.AddWithValue("@Cust_email", a);
             string s = "select No_of_seats_Economy from Seats_Available where F_No='" + F_NO + "'";
             DataTable dt1 = dataaccess_layer.GetRecords(s);
             int Availableseats = int.Parse(dt1.Rows[0][0].ToString());
             if (Availableseats >= int.Parse(No_of_Seats))
             {
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Reservation Successful");
                 this.Close();
             }
             else
             {
                 MessageBox.Show("Seats not available in the selected flight");
                 pnlpassengerinfo.Hide();
             }
         }
         else if (rbbusiness.Checked)
         {
             SqlCommand cmd = new SqlCommand("insertintoreserve_business", sc);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@F_NO", F_NO);
             cmd.Parameters.AddWithValue("@Reserve_date", DateTime.Now.ToShortDateString());
             cmd.Parameters.AddWithValue("@A_NAME", A_NAME);
             cmd.Parameters.AddWithValue("@SRC", SRC);
             cmd.Parameters.AddWithValue("@DEPART_TIME", DEPART_TIME);
             cmd.Parameters.AddWithValue("@DEST", DEST);
             cmd.Parameters.AddWithValue("@FARE", FARE);
             cmd.Parameters.AddWithValue("@NOS", No_of_Seats);
             cmd.Parameters.AddWithValue("@P1", passenger1name);
             cmd.Parameters.AddWithValue("@P2", passenger2name);
             cmd.Parameters.AddWithValue("@P3", passenger3name);
             cmd.Parameters.AddWithValue("@P4", passenger4name);
             cmd.Parameters.AddWithValue("@P5", passenger5name);
             cmd.Parameters.AddWithValue("@DOJ", DOJ);
             cmd.Parameters.AddWithValue("@Cust_email", a);
             cmd.Parameters.AddWithValue("@Ticket_type", "Economy");
             string s = "select No_of_seats_Business from Seats_Available where F_No='" + F_NO + "'";
             DataTable dt1 = dataaccess_layer.GetRecords(s);
             int Availableseats = int.Parse(dt1.Rows[0][0].ToString());
             if (Availableseats >= int.Parse(No_of_Seats))
             {
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Reservation Successful");
                 this.Close();
             }
             else
             {
                 MessageBox.Show("Seats not available in the selected flight");
                 pnlpassengerinfo.Hide();
             }
         }
         //string s = "insert into Reserve_Info(F_NO,A_NAME,SRC,DEPART_TIME,DEST,FARE,No_of_Seats,Passenger1,Passenger2,Passenger3,Passenger4,Passenger5,DOJ) values('" + F_NO + "','" + A_NAME + "','" + SRC + "','" + DEPART_TIME + "','" + DEST + "','" + FARE + "','" + No_of_Seats + "','" + tbpassenger1.Text + "','" + tbpassenger2.Text + "','" + tbpassenger3.Text + "','" + tbpassenger4.Text + "','" + tbpassenger5.Text + "','" + Convert.ToDateTime(DOJ).ToString() + "'";
         //dataaccess_layer.ProcessQuery(s);
     }
     catch (Exception ex)
     {
         bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
         MessageBox.Show("Internal Error Occured");
         this.BeginInvoke(new MethodInvoker(Close));
     }
 }

 private void rbeconomy_CheckedChanged(object sender, EventArgs e)
 {
     dgviewsearch.Columns.Clear();
 }

 private void rbbusiness_CheckedChanged(object sender, EventArgs e)
 {
     dgviewsearch.Columns.Clear();
 }
}
}

