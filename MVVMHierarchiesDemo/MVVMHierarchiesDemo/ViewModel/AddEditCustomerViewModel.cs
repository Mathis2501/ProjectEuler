using MVVMHierarchiesDemo.Model;
using MVVMHierarchiesDemo;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMHierarchiesDemo.Views;

namespace MVVMHierarchiesDemo.ViewModel
{

    class AddEditCustomerViewModel : BindableBase
    {

        public AddEditCustomerViewModel()
        {
            CancelCommand = new MyICommand<Action>(OnCancel);
            SaveCommand = new MyICommand<Action>(OnSave, CanSave);
        }

        private bool _EditMode;

        public bool EditMode
        {
            get { return _EditMode; }
            set { SetProperty(ref _EditMode, value); }
        }

        private SimpleEditableCustomer _Customer;

        public SimpleEditableCustomer Customer
        {
            get { return _Customer; }
            set { SetProperty(ref _Customer, value); }
        }

        private Customer _editingCustomer = null;

        public void SetCustomer()
        {

            if (Customer != null) Customer.ErrorsChanged -= RaiseCanExecuteChanged;
            Customer = new SimpleEditableCustomer();
            Customer.ErrorsChanged += RaiseCanExecuteChanged;
        }

        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }

        public MyICommand<Action> CancelCommand { get; private set; }
        public MyICommand<Action> SaveCommand { get; private set; }

        public event Action Done = delegate { };

        private void OnCancel(Action a)
        {
            Done();
        }

        private void OnSave(Action a)
        {
            Done();
        }

        private bool CanSave(Action a)
        {
            SetCustomer();
            //try
            //{
                return !Customer.HasErrors;
            //}
            //catch (Exception)
            //{
                
            //}
            //return false;
        }
    }
}