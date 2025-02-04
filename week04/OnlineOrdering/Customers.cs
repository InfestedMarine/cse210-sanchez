using System;

public class Customer{

    private string name;
    private Address address;

    public Customer(string customerName, Address customerAddress){

        name = customerName;
        address = customerAddress;
    }

    public string Getname(){

        return name;
    }

    public bool IsInUSA(){

        return address.IsInUSA();
    }

    public string GetAddress(){
        
        return address.GetFullAddress();
    }
}