using System;
using System.Collections.Generic;
using DatabaseLayer;
using DomainLayer;

namespace PrettyHair.Business
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

        public void SaveCustomer(DomainLayer.Customer cust)
        {
            DatabaseFacade.Instance.NewCustomer(cust);
        }
        public List<Customer> ShowCustomer()
        {
            List<DomainLayer.Customer> custList = new List<DomainLayer.Customer>();
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
