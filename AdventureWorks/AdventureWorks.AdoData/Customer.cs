using System;

namespace AdventureWorks.AdoData
{
    public class Customer
    {
        public string Fname;
        public string Lname;

        public Customer(string fname, string lname)
        {
            Fname = fname ?? throw new ArgumentNullException(nameof(fname));
            Lname = lname ?? throw new ArgumentNullException(nameof(lname));
        }
    }
}