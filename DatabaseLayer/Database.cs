using DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DatabaseLayer
{//test
    public class Database
    {
        private static string connectionString =
            "Server=ealdb1.eal.local; Database= ejl50_db; User= ejl50_usr; Password=Baz1nga50;";
        internal List<Customer> GetCustomer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd2 = new SqlCommand("spGetCustomers", connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    //cmd2.Parameters.Add(new SqlParameter("@ZipCode", "5000"));

                    SqlDataReader reader = cmd2.ExecuteReader();

                    List<Customer> custList = new List<Customer>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string custLastName = reader["CustLastName"].ToString();
                            string custFirstName = reader["CustFirstName"].ToString();
                            string custAddress = reader["CustAddress"].ToString();
                            string custPhone = reader["CustPhoneNumber"].ToString();
                            Customer customerGet = new Customer(custLastName, custFirstName, custAddress, custPhone);
                            custList.Add(customerGet);
                        }
                    }
                    return custList;
                }
                catch (SqlException e)
                {
                    
                    Console.WriteLine("UPS " + e.Message);
                    Console.ReadKey();
                    return null;
                }
            }
        }
        internal void InsertCustomer(Customer newCust)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd1 = new SqlCommand("spInsertCustomer", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@CustLastName", newCust.LastName));
                    cmd1.Parameters.Add(new SqlParameter("@CustFirstName", newCust.FirstName));
                    cmd1.Parameters.Add(new SqlParameter("@CustAddress", newCust.Address));
                    cmd1.Parameters.Add(new SqlParameter("@CustPhoneNumber", newCust.PhoneNumber));

                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("UPS " + e.Message);
                    Console.ReadKey();
                }

            }

        }
    }
}
