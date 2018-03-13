using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading;

namespace AdventureWorks.AdoData
{
    public class AdoAdapter
    {
        private string _connectionString = "data source=sofanisqlweek.database.windows.net;initial catalog=sofanisqlweek;user id=sofa;password=sami114173";
        private List<Customer> customers = new List<Customer>();

        public List<Customer> GetCustomers()
        {
            string query = "select FirstName, LastName from SalesLT.Customer";
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter();

            using (SqlConnection con = new SqlConnection(_connectionString))
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
                    Thread.Sleep(1500);
                }
            }
            return customers;
        }
    }
}
