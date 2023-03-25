using System;

class Address
{
    string _address = "";
    private bool _isUSA;

    public Address()
    {

    }

    public Address(string address, bool isUSA)
    {
        _address = address;
        _isUSA = isUSA;
    }

    public string getAddress()
    {
        return _address;
    }

    public void setAddress()
    {
        Console.WriteLine("Please provide the address" );
        string userResp = Console.ReadLine();
        _address = userResp;
    }

    public void setUSA(bool isUSA)
    {
        _isUSA = isUSA;
    }

    public bool getUSA()
    {
        return _isUSA;

    }
}