using PropertyContainerPatternExample.model;
using System;

namespace PropertyContainerPatternExample
{
    public class Program
    {
        private static void Main()
        {
            var book = new Book();

            book.AddPropertyBy("ABC","Publisher");
            book.AddPropertyBy(new DateTime(2017, 12, 31), "ReleaseDate");
            book.AddPropertyBy(12, "QuantitySold");

            book.RemoveProperty("ReleaseDate");


            var keys = book.GetPropertyKeys();
            foreach(var key in keys)
            {
                var property = book.GetPropertyBy(key);
                Console.WriteLine(key + ": " + property);
            }

            Console.ReadLine();
        }
    }
}
