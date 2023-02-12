using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture scripture = new Scripture();
        scripture.Display();
        string response = "";
        

        while (response != "quit")
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type quit to finish.");
            string userResponse = Console.ReadLine();
            response = userResponse;
            scripture.deleteOneWord();
            Console.Clear();
            scripture.Display();
            if (scripture.checkHidden() == true)
            {
                Console.WriteLine("Congrats, you finished!");
                response = "quit";
            }
            

        }
        
        
        
    }
}