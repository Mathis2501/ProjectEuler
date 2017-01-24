using System.Collections.Generic;

namespace PrettyHair.Product
{
    public class ProductRepository
    {
        DomainLayer.Product product = new DomainLayer.Product();
        List<DomainLayer.Product> productList = new List<DomainLayer.Product>();
        List<string> stringList = new List<string>();

        public void AddIgnoredAsFirstToList()
        {
            productList.Add(product);
        }
        public void ChangeDescription(int index, string newDescription)
        {
            productList[index].Description = newDescription;
        }

        public void AddProductToList(DomainLayer.Product newProduct)
        {
            productList.Add(newProduct);
        }

        public List<DomainLayer.Product> GetList()
        {
            return productList;
        }

        public List<string> GetListAsStringList()
        {
            foreach (DomainLayer.Product product in productList)
            {
                stringList.Add(product.ToString());
            }

            return stringList;
        }

        public void AdjustPriceByIndex(int index, double adjustedPrice)
        {
            productList[index].Price = adjustedPrice;
        }

        public void DeleteProduct(int productId)
        {
            foreach (DomainLayer.Product product in productList)
            {
                if (product.GetId() == productId)
                {
                    productList.Remove(product); break;
                }
            }
        }
    }
}
