﻿using System;
using System.Collections.Generic;

namespace Indexers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Wil";
            Console.WriteLine(cookie["name"]);
        }
    }
}