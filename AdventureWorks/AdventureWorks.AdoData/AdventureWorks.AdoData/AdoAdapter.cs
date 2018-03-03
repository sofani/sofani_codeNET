using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdventureWorks.AdoData
{
    /*
     SqlDataAdapter is typically used to fill a DataSet or DataTable and so you will have access to the data after your connection has been closed (disconnected access). 
     SqlDataReader is a fast forward-only and connected cursor which tends to be generally quicker than filling a DataSet/DataTable
    */
    public class AdoAdapter
    {
        private string ConnectionString = "data source=sofanisqlweek.database.windows.net; initial catalog=sofanisqlweek; user id=sofa; password=sami114173;";
        private List<Customer> customers = new List<Customer>();

        public List<Customer> GetCustomers()
        {
            string query = "select firstname, lastname from SalesLT.Customer;";

            SqlCommand cmd = new SqlCommand(query);

            SqlDataAdapter da = new SqlDataAdapter();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                DataSet ds = new DataSet();

                con.Open();

                cmd.Connection = con;

                da.SelectCommand = cmd;

                da.Fill(ds);

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    var c = new Customer(r[0].ToString(), r[1].ToString());
                    customers.Add(c);
                    System.Console.WriteLine(c.Fname + " " + c.Lname);
                }

            }

            return customers;
        }
    }
}
