using System;

class Order
{

    private List<Item> _items = new List<Item>();
    private Customer Customer;
    private int _shippingCost = 0;
    private int _totalCost = 0;
    private int _subtotal = 0;

    public Order()
    {

    }

    public void calculateCost()
    {
        foreach (Item item in _items)
        {
            _subtotal = _subtotal + item.getTotalPrice();
        }
        _totalCost = _subtotal;
        Console.WriteLine($"Cost without shipping: ${_totalCost}");
        calculateShipping();
        _totalCost = _totalCost + _shippingCost;
        Console.WriteLine($"Shipping charge: ${_shippingCost}");
        Console.WriteLine($"Total Cost: ${_totalCost}");
        
    }


    public void calculateShipping() 
    {
        if (Customer.getUSA() == true)
        {
            _shippingCost = 5;
        }
        else {
            _shippingCost = 35;
        }
        
    }


    public void setCustomer(Customer customer)
    {
        Customer = customer;
    }

    public void displayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"Shipping Address: {Customer.getAddress()}");
    }

    public void displayPackingSlip()
    {
        Console.WriteLine($"Customer Name: {Customer.getCustName()}");
        Console.WriteLine("Packing Label");
        Console.WriteLine("");
        foreach (Item item in _items)
        {
            item.displayItem();
            Console.WriteLine("");
        }
    }

    public void addItem(Item item)
    {
        _items.Add(item);
    }




}