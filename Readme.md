# ShoppingCart Console Application

A simple C# console application that simulates a shopping cart system. Users can browse products from a store, add items to their cart, and view the total price. Product data is loaded from a JSON file.

## Features
- List available products from a store (loaded from `Data/StoreItems.json`)
- Add products to the cart by product ID and quantity
- Prevents adding more items than available in stock
- Calculates and displays the total cart price
- Updates store inventory after adding to cart

## Project Structure
- `Program.cs`: Main entry point, handles user interaction
- `Store.cs`: Loads products, displays store items, manages inventory
- `Cart.cs`: Manages cart items and total price
- `Product.cs`: Product model
- `Data/StoreItems.json`: Product data

## How to Run
1. Open the solution in Visual Studio or VS Code.
2. Build the project (requires .NET 8.0 or later).
3. Run the application. Follow the prompts to add products to your cart.

## Example Usage
```
Product ID: 1, Product Name: Wireless Mouse, Product Price: 24.99,  Quantity: 120
...
Enter the id of the product to add in cart
1
Enter the quantity of the product
2
You have selected Wireless Mouse and quantity as: 2
Product Wireless Mouse added to the cart
Your final cart price is 49.98
```

## Requirements
- .NET 8.0 SDK or later

## Author
- Your Name
