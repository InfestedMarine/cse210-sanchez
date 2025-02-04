using System;

public class Address{

    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string street, string cityName, string stateName, string countryName){

        streetAddress = street;
        city = cityName;
        state = stateName;
        country = countryName;
    }

    public bool IsInUSA(){

        return country.ToLower() == "usa";
    }

    public string GetFullAddress(){

        return $"{streetAddress}\n{city}, {state}\n{country}";
    }
}