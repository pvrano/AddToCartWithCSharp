using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{


    public class Cart
    {
        private double _cartPrice;

        Product product = new Product();
        
        private List<Product> _products;


        public double CartPrice { get { return _cartPrice;  } set { _cartPrice = value; } }


        
        public Cart() 
        {
          _products =  new List<Product>();

        }

        public double addToCart(Product product)
        {   
            this._products.Add(product);
            CartPrice = CartPrice + (product.Price*product.Quantity);
            Console.WriteLine($"Product {product.Name} added to the cart");


            return CartPrice;
            
        }

    }
}
