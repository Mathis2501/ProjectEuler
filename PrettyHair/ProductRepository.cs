using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class ProductRepository
    {
        
        Product product = new Product();
        List<Product> productList = new List<Product>();
        List<string> stringList = new List<string>();

        public void AddIgnoredAsFirstToList()
        {
            productList.Add(product);
        }
        public void ChangeDescription(int index, string newDescription)
        {
            productList[index].Description = newDescription;
        }

        public void AddProductToList(Product newProduct)
        {
            productList.Add(newProduct);
        }

        public List<Product> GetList()
        {
            return productList;
        }

        public List<string> GetListAsStringList()
        {
            foreach (Product product in productList)
            {
                stringList.Add(product.ToString());
            }

            return stringList;
        }

        public void AdjustPriceByIndex(int index, double adjustedPrice)
        {
            productList[index].AdjustPrice(adjustedPrice);
        }

        public void DeleteProduct(int productId)
        {
            foreach (Product product in productList)
            {
                if (product.GetId() == productId)
                {
                    productList.Remove(product); break;
                }
            }
        }
    }
}
