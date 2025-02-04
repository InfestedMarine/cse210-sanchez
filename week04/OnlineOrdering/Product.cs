using System;


public class Product{

    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string productName, string id, decimal unitPrice, int quantityOrdered){

        name = productName;
        productId = id;
        price = unitPrice;
        quantity = quantityOrdered;
    }

    public decimal GetTotalCost(){

        return price * quantity;
    }

    public string GetName(){

        return name;
    }

    public string GetProductId(){

        return productId;
    }
}