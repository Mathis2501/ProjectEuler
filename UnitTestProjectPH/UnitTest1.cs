using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrettyHair;
using System.Collections.Generic;

namespace UnitTestProjectPH
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void SetUpTest()
        {
            
        }
        
        [TestMethod]
        public void CanAddCustomerToList()
        {
            CustomerRepository custRepo = new CustomerRepository();
            Customer customer1 = new Customer("Christensen", "Jimmi", "Bernstorffsvej 10", "28734552");
            Customer customer2 = new Customer("Larsen", "Katrine", "Bernstorffsvej 10", "77456322");

            custRepo.AddCustomerToList(customer1);
            custRepo.AddCustomerToList(customer2);

            List<Customer> customerList = custRepo.GetCustomerList();

            Assert.AreEqual(2, customerList.Count); 
        }
        [TestMethod]
        public void CanGetCustomerListAsStrings()
        {
            CustomerRepository custRepo = new CustomerRepository();
            Customer customer1 = new Customer("Christensen", "Jimmi", "Bernstorffsvej 10", "28734552");
            Customer customer2 = new Customer("Larsen", "Katrine", "Bernstorffsvej 10", "77456322");

            custRepo.AddCustomerToList(customer1);
            custRepo.AddCustomerToList(customer2);

            List<string> stringList = custRepo.GetListAsStringList();

            Assert.IsInstanceOfType(stringList[0], typeof(string));
        }
        //[TestMethod]
        //public void CanGiveEachCustomerUniqueID()
        //{
        //    CustomerRepository custRepo = new CustomerRepository();

        //    Customer customer1 = new Customer("Christensen", "Jimmi", "Bernstorffsvej 10", "28734552");
        //    Customer customer2 = new Customer("Larsen", "Katrine", "Bernstorffsvej 10", "77456322");

        //    custRepo.AddCustomerToList(customer1);
        //    custRepo.AddCustomerToList(customer2);

        //    Assert.AreNotEqual(customer1.GetId(), customer2.GetId());
        //}
        //[TestMethod]
        //public void CanAddOrderToList()
        //{
        //    OrderRepository invRepo = new OrderRepository();
        //    Order newOrder = new Order(DateTime.Parse("15-11-2016"), DateTime.Parse("01-12-2016"), 20, 2);
            
        //    invRepo.AddOrderToList(newOrder);
        //    List<Order> orderList = invRepo.GetList();

        //    Assert.AreEqual(1, orderList.Count);
        //}
        [TestMethod]
        public void CanChangeProductDescription()
        {
            ProductRepository prodRepo = new ProductRepository();
            Product newProduct = new Product("Hairbrush", 20.00, "Hairbrush with steelhandle", 45);
            prodRepo.AddProductToList(newProduct);
            
            prodRepo.ChangeDescription(0, "Hairbrush with woodenhandle");

            Assert.AreEqual("Hairbrush with woodenhandle", newProduct.Description);
        }
        [TestMethod]
        public void CanSubFromProductAmount()
        {
            Product newProduct = new Product("Hairbrush", 20.00, "Hairbrush with steelhandle", 45);

            newProduct.SubFromAmount(25);

            Assert.AreEqual(20, newProduct.Amount);
        }
        [TestMethod]
        public void CanAddToProductAmount()
        {
            Product newProduct = new Product("Hairbrush", 20.00, "Hairbrush with steelhandle", 45);

            newProduct.AddToAmount(55);

            Assert.AreEqual(100, newProduct.Amount);

        }
        [TestMethod]
        public void CanChangeThePriceOfAProduct()
        {
            Product newProduct = new Product("Hairbrush", 20.00, "Hairbrush with steelhandle", 45);
            ProductRepository prodRepo = new ProductRepository();
            prodRepo.AddProductToList(newProduct);
            prodRepo.AdjustPriceByIndex(1, 35.00);

            Assert.AreEqual(35.00, newProduct.Price);
        }
        [TestMethod]
        public void CanDeleteProductFromList()
        {
            ProductRepository prodRepo = new ProductRepository();
            Product newProduct = new Product("Hairbrush", 20.00, "Hairbrush with steelhandle", 45);
            Product newProduct2 = new Product("Shampoo", 15.00, "With conditioner", 25);

            prodRepo.AddProductToList(newProduct);
            prodRepo.AddProductToList(newProduct2);

            prodRepo.DeleteProduct(5);

            List<Product> productList = prodRepo.GetList();

            Assert.AreEqual(1, productList.Count);
        }
        [TestMethod]
        public void CanGiveEachProductUniqueID()
        {
            ProductRepository prodRepo = new ProductRepository();
            Product newProduct = new Product("Hairbrush", 20.00, "Hairbrush with steelhandle", 45);
            Product newProduct2 = new Product("Shampoo", 15.00, "With conditioner", 25);

            prodRepo.AddProductToList(newProduct);
            prodRepo.AddProductToList(newProduct2);

            Assert.AreNotEqual(newProduct.GetId(), newProduct2.GetId());
        }
    }
}
