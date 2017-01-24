using System.Windows;
using PrettyHair.Business;

namespace GuiLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BusinessFacade Controler;
        public MainWindow()
        {
            Controler = BusinessFacade.GetInstance;
            InitializeComponent();
        }
    }
}
