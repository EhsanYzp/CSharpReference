using CSharpReference.OOPPrinciples;
using System;

namespace CSharpReference.Helpers
{
    public class AbstractClassTests
    {
        /// <summary>
        /// Tests AbstractClass.cs
        /// </summary>
        public static void AbstractClass()
        {
            //Testing instance of child class.
            ChildClassFromAbstract ccfa = new ChildClassFromAbstract(false, 2342);
            ccfa.PrintVariableAndPropertyValues();
            ccfa.ChildOwnMethod();
            ccfa.AbstractMethod();
            ccfa.VirtualMethod();

            Console.WriteLine("--------------------------");

            //casting child class to base class and test again the methods. After conversion the specific methods of the child class will be lost.
            AbstractClass ac = (AbstractClass)ccfa;
            ac.AbstractMethod();
            ac.VirtualMethod();

        }


    }
}
