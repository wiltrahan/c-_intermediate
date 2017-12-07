using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Wil");
            list.Add(DateTime.Today);
            
            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("Frankie");
        }
    }
}