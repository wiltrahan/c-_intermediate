using System;
using System.Collections.Generic;

namespace Properties
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person(new DateTime(1979, 8, 29));
            Console.WriteLine(person.Age);
        }
    }
}