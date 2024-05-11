// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static Product;

public class Product
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");
        string? userInput = Console.ReadLine();
        userInput = string.Empty;
        if (userInput == "1")
        {
            Console.WriteLine("Enter Product Name");
            Product product;
            userInput = Console.ReadLine();

        }
        else if (userInput == "2") 
        {
            Console.WriteLine("Enter name of the Dogleash");
            var dogLeash = Console.ReadLine();
            var dogLeash = productLogic.GetDogLeash(dogLeash);

        }
    }
}


