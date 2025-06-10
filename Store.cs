using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Store
    {
        List<Product> store = new List<Product>();


        string filePath = "C:\\Users\\pvran\\source\\repos\\PracticeOops\\Collections\\ShoppingCart\\Data\\StoreItems.json";

        string jsonString;

        



        public Store() {
            jsonString = File.ReadAllText(filePath);
            store = JsonSerializer.Deserialize<List<Product>>(jsonString);
            
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
