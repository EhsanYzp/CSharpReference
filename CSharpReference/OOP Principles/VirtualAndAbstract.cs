using System;

namespace CSharpReference.OOPPrinciples
{
    public abstract class VirtualAndAbstract
    {
        public abstract void AbstractMethod();
        public virtual void VirtualMethod()
        {
            Console.WriteLine("This is a virtual method and it SHOULD HAVE body in the base class.");
        }
    }

    public class ChildClass : VirtualAndAbstract {
        public override void AbstractMethod()
        {
            Console.WriteLine("This is an abstract method and it SHOULD HAVE body in the child class.");
        }

        //Uncomment following method if you want implementation of VirtualMethod in child class is class(instead of base class)
        //public override void VirtualMethod()
        //{
        //    base.VirtualMethod();

        //    Console.WriteLine("Virtual method can be overriden in the child class also but it is not mandatory.");
        //}
    }
}
