using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseLayer;
using DomainLayer;

namespace PrettyHair
{
    public class BusinessFacade
    {
        
        private static volatile BusinessFacade instance;

        private static object synchronizationRoot = new Object();

        public static BusinessFacade Instance
        {
            get
            {
                lock (synchronizationRoot)
                {
                    if (instance == null)
                    {
                        instance = new BusinessFacade();
                    }
                }
                
                return instance;
            }
        }

        private BusinessFacade()
        {
            DatabaseFacade dbf = DatabaseFacade.Instance;
        }

        public void SaveCustomer(string lastName, string firstName, string address, string phoneNumber)
        {
            Customer newCust = new Customer(lastName, firstName, address, phoneNumber);
            DatabaseFacade.Instance.NewCustomer(newCust);
        }
        public List<Customer> ShowCustomer()
        {
            List<Customer> custList = new List<Customer>();
            string lastName;
            string firstName;
            string address;
            string phoneNumber;

            foreach (var item in DatabaseFacade.Instance.ShowCustomer())
            {
                lastName = item.LastName;
                firstName = item.FirstName;
                address = item.Address;
                phoneNumber = item.PhoneNumber;
                Customer newCust = new Customer(lastName, firstName, address, phoneNumber);
                custList.Add(newCust);
            }

            return custList;
        }
    }
}
