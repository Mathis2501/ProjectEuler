using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DatabaseLayer;
using DomainLayer;

namespace DatabaseLayer
{
    public class DatabaseFacade
    {
        Database db;
        private static volatile DatabaseFacade instance;
        private static object synchronizationRoot = new Object();
        public static DatabaseFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new DatabaseFacade();
                        }
                    }
                }

                return instance;
            }  
        }
        private DatabaseFacade()
        {
            db = new Database();
        }

        public void NewCustomer(Customer newCust)
        {
            db.InsertCustomer(newCust);
        }

        public List<Customer> ShowCustomer()
        {
            List<Customer> custList = db.GetCustomer();
            return custList;

        }
    }
}
