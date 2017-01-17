using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class CustomerRepository
    {
        List<Customer> customerList = new List<Customer>();

        public void AddAllCustomersToList(List<Customer> custList)
        {
            customerList.AddRange(custList);
        }
        public void AddCustomerToList(Customer newCustomer)
        {
            customerList.Add(newCustomer);
        }
        public void ClearRepository()
        {
            customerList.Clear();
        }
        public List<Customer> GetCustomerList()
        {
            return customerList;
        }
        
        public void CreateCustomer(string lastName, string firstName, string address, string phoneNumber)
        {
            Customer newCust = new Customer(lastName, firstName, address, phoneNumber);
            SaveToDB(newCust);

        }
        public void SaveToDB(Customer newCust)
        {
            DatabaseLayer.DatabaseFacade.Instance.NewCustomer(newCust);
        }
    }
}
