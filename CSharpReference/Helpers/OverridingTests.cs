using CSharpReference.OOPPrinciples;

namespace CSharpReference.Helpers
{
    public class OverridingTests
    {
        /// <summary>
        /// Tests Overriding.cs
        /// </summary>
        public static void Overriding()
        {
            SubClass sc = new SubClass();               //Prints greetings from sub class
            sc.Greetings();

            BaseClass bc = new SubClass();              //Prints greetings from sub class
            bc.Greetings();

            BaseClass bc2 = new BaseClass();            //Prints greetings from base class
            bc2.Greetings();

        }


    }
}
