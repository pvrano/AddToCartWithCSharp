using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Store
    {
        List<Product> store = new List<Product>();


        public Store() {
            store.Add(new Product(1, "Bread", 2.5, 10));
            store.Add(new Product(2, "Butter", 3, 10));
            store.Add(new Product(3, "Eggs", 5, 10));
            store.Add(new Product(4, "Cereal", 12, 10));
            store.Add(new Product(5, "Rice Bag", 9, 10));
            store.Add(new Product(6, "Milk", 1.5, 10));
        }

        public void showStoreList()
        {
            foreach (Product product in store)
            {
                
               Console.WriteLine($"Product ID: {product.Id}, Product Name: {product.Name}, Product Price:  {product.Price},  Quantity: {product.Quantity}");
            }
        }

        public Product getProductById(int id)
        {
            Product p = store[id];
            return new Product(p.Id, p.Name, p.Price, p.Quantity);
            
        }

        public void reduceProductQuantity(Product product, int quantity)
        {
            Product storeProduct = store.Find(item => item.Id == product.Id);
            storeProduct.Quantity -= quantity;
        }
        
        
        
    }
}
