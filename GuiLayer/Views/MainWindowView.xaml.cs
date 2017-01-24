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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GuiLayer.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : UserControl
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, RoutedEventArgs e)
        {
            /*CustomersWindow customersWindow = new CustomersWindow();
            customersWindow.Show();
            */
            var myWindow = MainWindow.GetWindow(this);
            var customerView = new CustomerView();


        }

        private void ProductsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
