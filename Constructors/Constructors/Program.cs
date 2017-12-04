using System;
using System.Collections.Generic;

namespace Constructors
{
   
    class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1, "Wil");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}