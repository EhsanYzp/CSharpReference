using System;

namespace CSharpReference.Advanced_Topics
{
    /// <summary>
    /// Extension methods, as the name suggests, are additional methods.
    /// Extension methods allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface.
    /// Extension methods can be added to your own custom class, .NET framework classes, or third party classes or interfaces.
    /// In the following example, IsGreaterThan() is an extension method for int type, which returns true if the value of the int variable is greater than the supplied integer parameter.
    /// An extension method is actually a special kind of static method defined in a static class.
    /// </summary>
    public static class IntExtensions
    {


        /// <summary>
        /// extension method defined on type int.
        /// </summary>
        /// <param name="i">specificies the type on which the extension method is applicable. this keyword is essential here and specifies that this is an extension method. </param>
        /// <param name="value">parameter need in the function itself</param>
        /// <returns></returns>
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }


    }

    public class TestExtensionMethod{

        public TestExtensionMethod()
        {
            int i = 10;
            bool result = i.IsGreaterThan(100);  // The function is defined in the form of IsGreaterThan(i, value) but
                                                 //when we call itm the first parameter is coming before the method like i.IsGreaterThan(value)
            Console.WriteLine($"isGreaterThan is an extension method on type int and testing 10 > 100 returns {result}") ;
        }
    }
}
