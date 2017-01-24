using System;
using System.Collections.Generic;
using DatabaseLayer;

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

        public void SaveCustomer(string lastName, string firstName, string address, string phoneNumber)
        {
            DomainLayer.Customer newCust = new DomainLayer.Customer(lastName, firstName, address, phoneNumber);
            DatabaseFacade.Instance.NewCustomer(newCust);
        }
        public List<DomainLayer.Customer> ShowCustomer()
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
                DomainLayer.Customer newCust = new DomainLayer.Customer(lastName, firstName, address, phoneNumber);
                custList.Add(newCust);
            }

            return custList;
        }
    }
}
