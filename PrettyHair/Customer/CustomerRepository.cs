using System.Collections.Generic;

namespace PrettyHair.Customer
{
    public class CustomerRepository
    {
        List<DomainLayer.Customer> customerList = new List<DomainLayer.Customer>();

        public void AddAllCustomersToList(List<DomainLayer.Customer> custList)
        {
            customerList.AddRange(custList);
        }
        public void AddCustomerToList(DomainLayer.Customer newCustomer)
        {
            customerList.Add(newCustomer);
        }
        public void ClearRepository()
        {
            customerList.Clear();
        }
        public List<DomainLayer.Customer> GetCustomerList()
        {
            return customerList;
        }
        
        public void CreateCustomer(string lastName, string firstName, string address, string phoneNumber)
        {
            DomainLayer.Customer newCust = new DomainLayer.Customer(lastName, firstName, address, phoneNumber);
            SaveToDB(newCust);

        }
        public void SaveToDB(DomainLayer.Customer newCust)
        {
            DatabaseLayer.DatabaseFacade.GetInstance.NewCustomer(newCust);
        }
    }
}
