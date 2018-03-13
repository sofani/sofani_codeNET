using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading;

namespace AdventureWorks.AdoData
{
    public class AdoReader
    {
        private string _connectionString = "data source=sofanisqlweek.database.windows.net;initial catalog=sofanisqlweek;user id=sofa;password=sami114173";
        private List<Customer> customers = new List<Customer>();

        public List<Customer> GetCustomers()
        {
            string query = "select FirstName, LastName from SalesLT.Customer";
            SqlCommand cmd = new SqlCommand(query);
            SqlDataReader dr;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                cmd.Connection = con;
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    var c = new Customer(dr[0].ToString(), dr[1].ToString());
                    customers.Add(c);
                    System.Console.WriteLine(c.Fname + " " + c.Lname);
                    Thread.Sleep(1500);
                }
            }
            return customers;
        }
    }
}
