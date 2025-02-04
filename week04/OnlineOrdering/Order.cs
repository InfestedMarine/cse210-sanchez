using System;
using System.Collections.Generic;

public class Order{

    private List<Product> products;
    private Customer customer;

    public Order(Customer orderCustomer){

        products = new List<Product>();
        customer = orderCustomer;
    }

    public void AddProduct(Product product){

        products.Add(product);
    }

    public decimal CalculateTotalCost(){

        decimal total = 0;

        foreach (var product in products){

            total += product.GetTotalCost();
        }

        decimal shippingCost = customer.IsInUSA() ? 5 : 35;
        return total + shippingCost;

    }

    public string GetPackingLabel(){

        string label = "Packing Label:\n";

        foreach (var product in products){

            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    public string GetShippingLabel(){

        return $"Shipping Label:\n {customer.Getname()}\n {customer.GetAddress()}";
    }
}