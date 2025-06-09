﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private int _quantity;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Price { get { return _price; } set { _price = value; } }
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
