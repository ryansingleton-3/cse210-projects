using System;

class Customer
{
    private string _customerName = "";
    Address _customerAddress;
    
    

    public Customer()
    {

    }

    public Customer(string customerName)
    {
        _customerName = customerName;

    }

    public void setAddress(Address address)
    {
        _customerAddress = address;
    }


    public string getAddress()
    {
        return _customerAddress.getAddress();
    }
    
    public string getCustName()
    {
        return _customerName;
    }

    public bool getUSA()
    {
        return _customerAddress.getUSA();
    }

    
}