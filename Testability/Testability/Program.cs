using System;
using System.Collections.Generic;

namespace Testability
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 100f};
            orderProcessor.Process(order);
        }
    }
}