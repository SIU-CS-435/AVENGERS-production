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
        string a;
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
                else if (tbseats.Text == "")
                {
                    MessageBox.Show("Enter No Of Seats", "Error");
                }
                else
                {
                    int i = bussiness_accesslayer.txtseats_Validating(tbseats.Text);
                    int j = bussiness_accesslayer.jour_date(dtpdate.Value.Date);
                    if (i == 0 && j == 0)
                    {
                        //string q = "SELECT fm.F_NO FlightNumber,am.A_NAME AirlineName,fm.SRC Source,fm.DEPART_TIME DepartureTime,fm.DEST GoingTo,fm.FARE Fare FROM FLIGHT_MASTER fm JOIN AIRLINES_MASTER am ON fm.F_No=am.F_NO JOIN SEATS_AVAILABLE sa ON fm.F_NO=sa.F_NO WHERE SRC='" + cmbSource.SelectedItem.ToString() + "' AND DEST='" + cmbDestination.SelectedItem.ToString() + "' AND No_of_Seats>=" + tbseats.Text + "";
                        DataTable dt = new DataTable();
                        string conn = "Data Source=DESKTOP-OPN87JD\\SQLEXPRESS;Initial Catalog=ExpDB;Integrated Security=True";
                        SqlConnection sc = null;
                        sc = new SqlConnection(conn);
                        try
                        {
                            sc.Open();
                            SqlCommand cmd = new SqlCommand("search", sc);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("src", cmbSource.Text);
                            cmd.Parameters.AddWithValue("dest", cmbDestination.Text);
                            cmd.Parameters.AddWithValue("No_of_Seats", tbseats.Text);
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
                            dgviewsearch.DataSource = dt;

                        }
                        catch (Exception ex)
                        {
                            bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                            MessageBox.Show("Internal Error Occured", "Sorry");
                            this.BeginInvoke(new MethodInvoker(Close));
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
         dtpdate.MinDate = DateTime.Now.Date;
         pnlbook.Hide();
         pnlconfirmed.Hide();
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
     if (e.ColumnIndex == 6)
     {
      
         DataGridViewRow row = dgviewsearch.CurrentCell.OwningRow;
         string sou= row.Cells[2].Value.ToString();
         string time = row.Cells[3].Value.ToString();
         string des = row.Cells[4].Value.ToString();
         string airname = row.Cells[1].Value.ToString();
         lbseats.Text = tbseats.Text;
         lbbookingdate.Text = DateTime.Now.ToShortDateString();
         lbdoj.Text = dtpdate.Value.Date.ToString();
         int pr = ((Convert.ToInt16(row.Cells[5].Value)) * Convert.ToInt16(tbseats.Text));
         lbtotalprice.Text = pr.ToString();
         lbairlinename.Text = airname;
         lbdestination.Text = des;
         lbtime.Text = time;
         lbsource.Text = sou;
         string f = row.Cells[0].Value.ToString();
         lbflightno.Text = f;
         pnlbook.Show();
     }
 }

 private void btncancel_Click(object sender, EventArgs e)
 {
     pnlbook.Hide();
 }

 private void btnconfirm_Click(object sender, EventArgs e)
 {
     try
     {
         int i = bussiness_accesslayer.null_validation(tbcustname.Text);
         int k = bussiness_accesslayer.name_validation(tbcustname.Text);
         if (i == 1)
         {
             MessageBox.Show("Enter Passenger Name", "Error");
         }
         else if (k == 1)
         {
             MessageBox.Show("Name Cannot be Alphanumeric", "Error");
         }
         else
         {
             pnlconfirmed.Show();
             string q2 = "SELECT CID FROM CUSTOMER_INFO WHERE EMAIL='" + a + "'";
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
             string q = "INSERT INTO BOOKING_INFO (BOOKING_ID,BOOKING_DT,F_NO,CID,PRICE,SEAT_BOOK,DOJ) VALUES('" + bi + "','" + lbbookingdate.Text + "','" + lbflightno.Text + "'," + Convert.ToInt16(dt.Rows[0]["cid"]) + "," + lbtotalprice.Text + "," + tbseats.Text + ",'" + lbdoj.Text + "') ";
             dataaccess_layer.ProcessQuery(q);
             string q1 = "SELECT MAX(BOOKING_ID) FROM  BOOKING_INFO";
             DataTable d1 = new DataTable();
             d1 = dataaccess_layer.GetRecords(q1);
             lbbookingid.Text = d1.Rows[0][0].ToString();
             lbairline.Text = lbairlinename.Text;
             lbbookidate.Text = lbbookingdate.Text;
             lbcustname.Text = tbcustname.Text;
             lbto.Text = lbdestination.Text;
             lbfrom.Text = lbsource.Text;
             lbpass.Text = lbseats.Text;
             lbjourneydate.Text = lbdoj.Text;
             lbdepttime.Text = lbtime.Text;
             lbtotal.Text = lbtotalprice.Text;
             lbflight.Text = lbflightno.Text;
             string q3 = "UPDATE s SET No_of_Seats=No_of_Seats-" + lbseats.Text + " FROM SEATS_AVAILABLE s JOIN BOOKING_INFO b ON b.F_NO=s.F_NO WHERE s.F_NO='" + lbflightno.Text + "'";
             dataaccess_layer.ProcessQuery(q3);
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

        }

        
    }

