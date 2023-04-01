using System;

class Event
{
    protected string _title = "";
    protected string _description = "";
    protected string _date = "";
    protected string _time = "";
    protected Address _address;
    protected string _type;

    public Event()
        {
            
        }
    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public void setAddress(Address address)
    {
        _address = address;
    }


    public string getAddress()
    {
        return _address.getAddress();
    }

    public void displayShortDeets()
    {
        Console.WriteLine("Short Details:");
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine(_title);
        Console.WriteLine(_date);
        Console.WriteLine("");
       

    }

    public void displayStandardDeets()
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address.getAddress());
        Console.WriteLine("");

    }

    
    



}