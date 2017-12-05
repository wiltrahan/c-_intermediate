using System;
using System.Collections.Generic;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1979, 8, 29));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}