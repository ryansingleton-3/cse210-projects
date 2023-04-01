using System;

class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item("123", "Grapes", 2, 3);
        Item item2 = new Item("321", "Bananas", 7, 4);
        Address address1 = new Address("1234 Main Street Columbus, OH USA 654321", true);
        address1.SetUSA(true);
        Customer customer1 = new Customer("Bob Smith");
        customer1.SetAddress(address1);
        Order order1 = new Order();
        order1.AddItem(item1);
        order1.AddItem(item2);
        order1.SetCustomer(customer1);
        Console.WriteLine("");
        Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
        order1.DisplayPackingSlip();
        order1.CalculateCost();
        Console.WriteLine("");
        order1.DisplayShippingLabel();
        Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
        Console.WriteLine("");



        Item item3 = new Item("483974", "Milk", 4, 5);
        Item item4 = new Item("321", "Bread", 2, 4);
        Address address2 = new Address("1234 Candido Pujato Santa Fe, Santa Fe Argentina 123456", false);
        address2.SetUSA(false);
        Customer customer2 = new Customer("Jane Smith");
        customer2.SetAddress(address2);
        Order order2 = new Order();
        order2.AddItem(item3);
        order2.AddItem(item4);
        order2.SetCustomer(customer2);
        order2.DisplayPackingSlip();
        order2.CalculateCost();
        Console.WriteLine("");
        order2.DisplayShippingLabel();




        /// Shipping Label /////




        // Packing Label ///////




        // Total Price //
    }
}