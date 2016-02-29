using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace atm
{
    class dataaccess_layer
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=F:\\Experiment_ATM\\atm\\Database1.sdf";
            return con;
        }
        //Retrieving records 
        public static DataTable GetRecords(string q)
        {   
            DataTable dt = new DataTable();
            SqlConnection c = GetConnection();
            SqlDataAdapter adp = new SqlDataAdapter(q, c);
            adp.Fill(dt);
        }
    }
}
