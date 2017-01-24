using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DomainLayer;
using PrettyHair;
using PrettyHair.Business;

namespace GuiLayer.Views
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        private BusinessFacade Controller;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            int i;
            if (string.IsNullOrEmpty(textBox.Text) && string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text))
            {
                if (int.TryParse(textBox3.Text, out i))
                {
                    Customer cust = new Customer(textBox.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                    Controller.SaveCustomer(cust);
                    this.Hide();
                }
            }
            

            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
