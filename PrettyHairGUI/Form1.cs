using PrettyHair;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrettyHairGUI
{
    public partial class PrettyHairUI : Form
    {
        CustomerRepository custRepo = new CustomerRepository();
        //customers til at teste med
        Customer newCustomer1 = new Customer("Christensen", "Jimmi", "Bernstorffsvej 10", "28734552");
        Customer newCustomer2 = new Customer("Larsen", "Katrine", "Bernstorffsvej 10", "99229922");
        Customer newCustomer3 = new Customer("Larsen", "Gustav", "Bernstorffsvej 10", "11223344");
        Customer newCustomer4 = new Customer("Hansen", "Karsten", "Hjallesevej 32", "55667788");
        string firstName;
        string lastName;
        string Address;
        string phone;
        string searchWord;
        
        public PrettyHairUI()
        {
            InitializeComponent();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            List<string> custList = custRepo.GetListAsStringList();
            CustListBox.DataSource = custList;
        }

        private void RegiCustButton_Click(object sender, EventArgs e)
        {
            custRepo.AddCustomerToList(newCustomer1);
            custRepo.AddCustomerToList(newCustomer2);
            custRepo.AddCustomerToList(newCustomer3);
            custRepo.AddCustomerToList(newCustomer4);
            //Customer newCustomer = new Customer(lastName, firstName, Address, phone);
            List<string> custList = custRepo.GetListAsStringList();
            CustListBox.DataSource = custList;
        }
        private void CustSearchButton_Click(object sender, EventArgs e)
        {
            List<string> searchList = new List<string>();
            searchList.Add(custRepo.Search(searchWord));
            CustListBox.DataSource = searchList;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            firstName = ToEmne.Text;
        }
        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            lastName = ToEmne.Text;
        }
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            Address = ToEmne.Text;
        }
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            phone = ToEmne.Text;
        }
        private void CustSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            searchWord = ToEmne.Text;
        }
    }
}
