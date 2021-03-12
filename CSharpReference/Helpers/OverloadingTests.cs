using CSharpReference.OOPPrinciples;
using System;

namespace CSharpReference.Helpers
{
    public class OverloadingTests
    {
        /// <summary>
        /// Tests Overloading.cs
        /// </summary>
        public static void Overloading()
        {
            Overloading ol = new Overloading();
            Console.WriteLine($"The result of first overloaded version of the function: {ol.Add(5, 10)}");
            Console.WriteLine($"The result of second overloaded version of the function: {ol.Add(44, 34, 11)}");
            Console.WriteLine($"The result of third overloaded version of the function: {ol.Add(457.22, 11.1, 32.43, 1.11)}");

        }

    }
}
