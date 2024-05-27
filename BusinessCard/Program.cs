using System;

namespace BusinessCard
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Please enter your name");
           string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ",can you please insert your phone number?");
           string phone = Console.ReadLine();
            Console.WriteLine("Thank you, and where are you working or studying at the moment?");
           string work = Console.ReadLine();
            Console.WriteLine("Informations gathered:");
            Console.WriteLine(work);
            Console.WriteLine(name);
            Console.WriteLine(phone);
            Console.ReadLine();

        }
    }
}
