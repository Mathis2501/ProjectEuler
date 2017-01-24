namespace GuiLayer.ViewModel
{
    class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
        }

        private CustomerViewModel custViewModel = new CustomerViewModel();

        private OrderViewModel orderViewModel = new OrderViewModel();

        private ProductsViewModel productsViewModel = new ProductsViewModel();

        private BindableBase _CurrentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "cust":
                    CurrentViewModel = custViewModel;
                    break;

                case "order":
                    CurrentViewModel = orderViewModel;
                    break;

                case "prod":
                default:
                    CurrentViewModel = productsViewModel;
                    break;
            }
        }
    }
}