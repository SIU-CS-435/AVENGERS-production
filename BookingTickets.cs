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
    public partial class BOOKED_TICKET : Form
    {
        string a;
        public BOOKED_TICKET()
        {
            InitializeComponent();
        }
        public BOOKED_TICKET(string s)
        {
            InitializeComponent();
            a = s;
        }

        private void BOOKED_TICKET_Load(object sender, EventArgs e)
        {
            string q = "SELECT BOOKING_ID BookingId,BOOKING_DT BookingDate,F.F_NO FlightNo,CID CustomerId,SRC SOURCE,DEST DESTINATION,PRICE,SEAT_BOOK TotalSeats,DOJ JourneyDate FROM  BOOKING_INF B JOIN FLIGHT_MASTER F ON B.F_NO=F.F_NO  WHERE CID IN(SELECT CID FROM CUSTOMER_INFO WHERE EMAIL='" + a + "')";
            DataTable dt = new DataTable();
            
            dt = dataaccess_layer.GetRecords(q);
            dgviewbooked.DataSource = null;
            dgviewbooked.DataSource = dt;
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn(); Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Cancel";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Cancel";
            if (dgviewbooked.Columns.Count == 9)
            {
                dgviewbooked.Columns.Add(Editlink);
            }
        }