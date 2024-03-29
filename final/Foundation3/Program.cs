using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------------------------");
        Address address1 = new Address("123 Main Street");
        Reception reception1 = new Reception("Ryan's Reception", "The best wedding reception in the world!","10/16/2023", "11:33AM", address1, "Reception");
        reception1.AddEmails(new string[] { "ryanbsingleton3@gmail.com", "alyssa.singleton18@yahoo.com", "john@company.com" });
        reception1.DisplayShortDeets();
        reception1.DisplayStandardDeets();
        reception1.DisplayFullDeets();
        Console.WriteLine("---------------------------------------------------------");

        Address address2 = new Address("321 Main Street");
        Lecture lecture1 = new Lecture("John Bytheway",100,"John's Lecture", "Come and listen to the well-known speaker John Bytheway discuss faith!","10/18/2025", "10:00AM", address2, "Lecture");
        lecture1.DisplayShortDeets();
        lecture1.DisplayStandardDeets();
        lecture1.DisplayFullDeets();
        Console.WriteLine("---------------------------------------------------------");

        Address address3 = new Address("132 Main Street");
        Gathering gathering1 = new Gathering("Clear skies and windy", "Josephine's Bonfire", "Bring some marshmallows to spend some time with friends and family.","10/17/2024", "8:00PM", address3, "Gathering");
        gathering1.DisplayShortDeets();
        gathering1.DisplayStandardDeets();
        gathering1.DisplayFullDeets();
        Console.WriteLine("---------------------------------------------------------");
    }
}