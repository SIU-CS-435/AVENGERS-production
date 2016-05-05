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
    public partial class Booking : Form
    {
        string a;
        public Booking(string s)
        {
            InitializeComponent();
            a = s;
        }
        public Booking()
        {
            InitializeComponent();
        }

        private void pnlbook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                cmb_no_of_seats.Items.Add(i);
            }
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

        private void cmbSource_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbDestination.Text = "Select Destination";
            DataTable dt = new DataTable();
            string q = "SELECT DISTINCT DEST FROM FLIGHT_MASTER WHERE DEST<>'" + cmbSource.Text + "'";
            dt = dataaccess_layer.GetRecords(q);
            cmbDestination.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbDestination.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void btnshow_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (cmbSource.Text == "" || cmbDestination.Text == "")
                {
                    MessageBox.Show("Source or Destination not selected", "Error");
                }
                else if (cmb_no_of_seats.Text == "")
                {
                    MessageBox.Show("Enter No Of Seats", "Error");
                }
                else if (rbtn_economy.Checked)
                {
                    int i = bussiness_accesslayer.txtseats_Validating(cmb_no_of_seats.Text);
                    int j = bussiness_accesslayer.jour_date(dtpdate.Value.Date);
                    if (i == 0 && j == 0)
                    {
                        string q = "SELECT fm.F_NO FlightNumber,am.A_NAME AirlineName,fm.SRC Source,fm.DEPART_TIME DepartureTime,fm.DEST GoingTo,fm.ECONOMY Fare FROM FLIGHT_MASTER fm JOIN AIRLINES_MASTER am ON fm.F_No=am.F_NO JOIN SEATS_AVAILABLE sa ON fm.F_NO=sa.F_NO WHERE SRC='" + cmbSource.SelectedItem.ToString() + "' AND DEST='" + cmbDestination.SelectedItem.ToString() + "' AND No_of_Seats_Economy>=" + cmb_no_of_seats.Text + "";
                        DataTable dt = new DataTable();
                        dt = dataaccess_layer.GetRecords(q);
                        //dgviewsearch.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No flights Available", "Sorry");
                            dgviewsearch.Columns.Clear();
                        }
                        else
                        {
                            dgviewsearch.DataSource = null;
                            dgviewsearch.DataSource = dt;
                            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn(); Editlink.UseColumnTextForLinkValue = true;
                            Editlink.HeaderText = "Book";
                            Editlink.DataPropertyName = "lnkColumn";
                            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                            Editlink.Text = "Book";
                            if (dgviewsearch.Columns.Count == 6)
                                dgviewsearch.Columns.Add(Editlink);
                        }
                    }
                }
                else if (rbtn_business.Checked)
                {
                    int i = bussiness_accesslayer.txtseats_Validating(cmb_no_of_seats.Text);
                    int j = bussiness_accesslayer.jour_date(dtpdate.Value.Date);
                    if (i == 0 && j == 0)
                    {
                        string q = "SELECT fm.F_NO FlightNumber,am.A_NAME AirlineName,fm.SRC Source,fm.DEPART_TIME DepartureTime,fm.DEST GoingTo,fm.Business Fare FROM FLIGHT_MASTER fm JOIN AIRLINES_MASTER am ON fm.F_No=am.F_NO JOIN SEATS_AVAILABLE sa ON fm.F_NO=sa.F_NO WHERE SRC='" + cmbSource.SelectedItem.ToString() + "' AND DEST='" + cmbDestination.SelectedItem.ToString() + "' AND No_of_Seats_Business>=" + cmb_no_of_seats.Text + "";
                        DataTable dt = new DataTable();
                        dt = dataaccess_layer.GetRecords(q);
                        //dgviewsearch.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No flights Available", "Sorry");
                            dgviewsearch.Columns.Clear();
                        }
                        else
                        {
                            dgviewsearch.DataSource = null;
                            dgviewsearch.DataSource = dt;
                            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn(); Editlink.UseColumnTextForLinkValue = true;
                            Editlink.HeaderText = "Book";
                            Editlink.DataPropertyName = "lnkColumn";
                            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                            Editlink.Text = "Book";
                            if (dgviewsearch.Columns.Count == 6)
                                dgviewsearch.Columns.Add(Editlink);
                        }
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
                else
                {
                    MessageBox.Show("Please Select Ticket Type");
                }
            }
            catch (Exception ex)
            {
                bussiness_accesslayer.LogErrorFile(ex.Message + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString());
                MessageBox.Show("Internal Error Occured");
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void btnconfirm_Click_1(object sender, EventArgs e)
        {
            int valid = 0;
            if (tbpassenger2.Visible == true)
            {
                if (tbpassenger2.Text == string.Empty)
                {
                    valid = 1;
                }
            }
            if (tbpassenger3.Visible == true)
            {
                if (tbpassenger3.Text == string.Empty)
                {
                    valid = 1;
                }
            }
            if (tbpassenger4.Visible == true)
            {
                if (tbpassenger4.Text == string.Empty)
                {
                    valid = 1;
                }
            }
            if (tbpassenger5.Visible == true)
            {
                if (tbpassenger5.Text == string.Empty)
                {
                    valid = 1;
                }
            }
            if (valid == 0)
            {
                lblpassenger2.Hide();
                lblpassenger3.Hide();
                lblpassenger4.Hide();
                lblpassenger5.Hide();
                tbpassenger2.Hide();
                tbpassenger3.Hide();
                tbpassenger4.Hide();
                tbpassenger5.Hide();
                try
                {
                    int i = bussiness_accesslayer.null_validation(tbpassenger1.Text);
                    int k = bussiness_accesslayer.name_validation(tbpassenger1.Text);
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
                        if (rbtn_business.Checked)
                        {
                            string q = "INSERT INTO BOOKING_INFO (BOOKING_ID,BOOKING_DT,F_NO,CID,PRICE,SEAT_BOOK,DOJ,Passenger1,Passenger2,Passenger3,Passenger4,Passenger5,Ticket_type) VALUES('" + bi + "','" + lbbookingdate.Text + "','" + lbflightno.Text + "'," + Convert.ToInt16(dt.Rows[0]["cid"]) + ",'" + lbtotalprice.Text + "','" + cmb_no_of_seats.Text + "','" + lbdoj.Text + "','" + tbpassenger1.Text + "','" + tbpassenger2.Text + "','" + tbpassenger3.Text + "','" + tbpassenger4.Text + "','" + tbpassenger5.Text + "','Business')";
                            dataaccess_layer.ProcessQuery(q);
                        }
                        else if (rbtn_economy.Checked)
                        {
                            string q = "INSERT INTO BOOKING_INFO (BOOKING_ID,BOOKING_DT,F_NO,CID,PRICE,SEAT_BOOK,DOJ,Passenger1,Passenger2,Passenger3,Passenger4,Passenger5,Ticket_type) VALUES('" + bi + "','" + lbbookingdate.Text + "','" + lbflightno.Text + "'," + Convert.ToInt16(dt.Rows[0]["cid"]) + ",'" + lbtotalprice.Text + "','" + cmb_no_of_seats.Text + "','" + lbdoj.Text + "','" + tbpassenger1.Text + "','" + tbpassenger2.Text + "','" + tbpassenger3.Text + "','" + tbpassenger4.Text + "','" + tbpassenger5.Text + "','Economy')";
                            dataaccess_layer.ProcessQuery(q);
                        }
                        string q1 = "SELECT MAX(BOOKING_ID) FROM  BOOKING_INFO";
                        DataTable d1 = new DataTable();
                        d1 = dataaccess_layer.GetRecords(q1);
                        lbbookingid.Text = d1.Rows[0][0].ToString();
                        lbairline.Text = lbairlinename.Text;
                        lbbookidate.Text = lbbookingdate.Text;
                        lbcustname.Text = tbpassenger1.Text;
                        lbto.Text = lbdestination.Text;
                        lbfrom.Text = lbsource.Text;
                        lbpass.Text = lbseats.Text;
                        lbjourneydate.Text = lbdoj.Text;
                        lbdepttime.Text = lbtime.Text;
                        lbtotal.Text = lbtotalprice.Text;
                        lbflight.Text = lbflightno.Text;
                        if (rbtn_business.Checked)
                        {
                            string q3 = "UPDATE s SET No_of_Seats_Business=No_of_Seats_Business-" + lbseats.Text + " FROM SEATS_AVAILABLE s JOIN BOOKING_INFO b ON b.F_NO=s.F_NO WHERE s.F_NO='" + lbflightno.Text + "'";
                            dataaccess_layer.ProcessQuery(q3);
                        }
                        else if (rbtn_economy.Checked)
                        {
                            string q3 = "UPDATE s SET No_of_Seats_Economy=No_of_Seats_Economy-" + lbseats.Text + " FROM SEATS_AVAILABLE s JOIN BOOKING_INFO b ON b.F_NO=s.F_NO WHERE s.F_NO='" + lbflightno.Text + "'";
                            dataaccess_layer.ProcessQuery(q3);
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
            else
            {
                MessageBox.Show("Please Enter Passenger Names");
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            pnlbook.Hide();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgviewsearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_no_of_seats.Hide();
            rbtn_economy.Hide();
            rbtn_business.Hide();
            lbltickettype.Hide();
            if (int.Parse(cmb_no_of_seats.Text) == 1)
            {
                tbpassenger2.Hide();
                tbpassenger3.Hide();
                tbpassenger4.Hide();
                tbpassenger5.Hide();
                lblpassenger2.Hide();
                lblpassenger3.Hide();
                lblpassenger4.Hide();
                lblpassenger5.Hide();
            }
            if (int.Parse(cmb_no_of_seats.Text) == 2)
            {
                tbpassenger3.Hide();
                tbpassenger4.Hide();
                tbpassenger5.Hide();
                lblpassenger3.Hide();
                lblpassenger4.Hide();
                lblpassenger5.Hide();
            }
            if (int.Parse(cmb_no_of_seats.Text) == 3)
            {
                tbpassenger4.Hide();
                tbpassenger5.Hide();
                lblpassenger4.Hide();
                lblpassenger5.Hide();
            }
            if (int.Parse(cmb_no_of_seats.Text) == 4)
            {
                tbpassenger5.Hide();
                lblpassenger5.Hide();
            }

            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dgviewsearch.CurrentCell.OwningRow;
                string sou = row.Cells[2].Value.ToString();
                string time = row.Cells[3].Value.ToString();
                string des = row.Cells[4].Value.ToString();
                string airname = row.Cells[1].Value.ToString();
                lbseats.Text = cmb_no_of_seats.Text;
                lbbookingdate.Text = DateTime.Now.ToShortDateString();
                lbdoj.Text = dtpdate.Value.Date.ToString();
                int pr = ((Convert.ToInt16(row.Cells[5].Value)) * Convert.ToInt16(cmb_no_of_seats.Text));
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

        private void rbtn_economy_CheckedChanged(object sender, EventArgs e)
        {
            dgviewsearch.Columns.Clear();
        }

        private void rbtn_business_CheckedChanged(object sender, EventArgs e)
        {
            dgviewsearch.Columns.Clear();
        }

    }


}

