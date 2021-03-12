using System;

namespace CSharpReference.OOPPrinciples
{
    public sealed class Sealed
    {
        public void PrintSealed()
        {
            Console.WriteLine("This is a sealed class and is not possible to inherit from it");
        }
    }

    //cannot derived from sealed class
    //public class InheritClassFromSealed: Sealed
    //{

    //}

    public class A
    {
        //public sealed void PrintSealedFunctionInParent()
        //{
        //    Console.WriteLine("This is not allowed because this is not an override function");
        //}

        public virtual void PrintSealedFunctionInParent()
        {
            Console.WriteLine("This is the function in the base class.");
        }
    }

    public class B: A
    {
        public sealed override void PrintSealedFunctionInParent()
        {
            Console.WriteLine("This is the function the child class and is sealed. So it is not possible to override this function anymore in the inherited classes.");
        }
    }

    public class C: B
    {

        //it is not possible to override a sealed function
        //public override void PrintSealedFunctionInParent()
        //{
        //    //compile error
        //}
    }
}
