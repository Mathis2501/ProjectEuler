using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainLayer
{
    public class Customer
    {
        //Variables
        string lastName;
        string firstName;
        string address;
        string phoneNumber;

        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }

        //Constructor
        public Customer()
        {

        }
        public Customer(string lastName, string firstName, string address, string phoneNumber)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        //Methods
        public override string ToString()
        {
            return lastName + ", " + firstName + ", " + address + ", " + phoneNumber;
        }
    }
}
