// See https://aka.ms/new-console-template for more information
using ShoppingCart;

Store storeObj = new Store();
Cart cart = new Cart();



// ask user for the product
// take the selected product from the store by id 
// add the product to cart
// print cart items

int entry = 1;

do
{
    storeObj.showStoreList();
    Console.WriteLine("Enter the id of the product to add in cart");
    int productId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Enter the quantity of the product");
    int quantity = Convert.ToInt32(Console.ReadLine());

    Product product = storeObj.getProductById(productId - 1);

    if (quantity > product.Quantity)
    {
        Console.WriteLine("Sorry this item is out of stock at the moment");
    }

    else
    {
        Console.WriteLine($"You have selected {product.Name} and quantity as: {quantity}");
        double cartPrice = cart.addToCart(new Product(product.Id,product.Name,product.Price,quantity));
        storeObj.reduceProductQuantity(product, quantity);
        Console.WriteLine($"Youe final cart price is {cartPrice}");
    }
    Console.WriteLine("Press 1 if you would still like to shop or press 0 if you like to checkout");
    entry = Convert.ToInt32(Console.ReadLine());
} while (entry == 1);





