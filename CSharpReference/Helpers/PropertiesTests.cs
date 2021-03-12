using CSharpReference.Primitives;
using System;

namespace CSharpReference.Helpers
{
    public class PropertiesTests
    {
        /// <summary>
        /// Tests Properties.cs
        /// </summary>
        public static void Properties()
        {
            //for testing set and get operators on a fullprop
            Properties pr = new Properties();
            pr.IntProp = 111;
            Console.WriteLine($"the intProp value is {pr.IntProp}");

            //for testing initializing a property using constructor
            Properties pr2 = new Properties(31242);
            Console.WriteLine($"the intProp value is {pr2.IntProp}");

            Properties pr3 = new Properties();
            Console.WriteLine($"the readonly property's value is {pr3.ReadOnlyProperty}");
            //pr3.ReadOnlyProperty = 4324234;           //cannot assign value to a readonly property

            Properties pr4 = new Properties();
            pr4.WriteOnlyProperty = 53543534;
            //    Console.WriteLine($"the writeonly property's value is {pr4.WriteOnlyProperty}");      //cannot get writeonly's property value.


        }

    }
}
