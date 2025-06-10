using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private int _quantity;

        [JsonPropertyName("id")]
        public int Id { get { return _id; } set { _id = value; } }
        [JsonPropertyName("name")]
        public string Name { get { return _name; } set { _name = value; } }
        [JsonPropertyName("price")]
        public double Price { get { return _price; } set { _price = value; } }

        [JsonPropertyName("quantity")]
        public int Quantity { get { return _quantity; } set { _quantity = value; } }

        public Product(int id, string name, double price,int quantity) {
            _id = id;
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public Product() { }

        
    }
}
