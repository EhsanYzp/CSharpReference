using CSharpReference.OOPPrinciples;

namespace CSharpReference.Helpers
{
    public class VirtualAndAbstractTests
    {
        /// <summary>
        /// Tests VirtualAndAbstract.cs
        /// </summary>
        public static void VirtualAndAbstract()
        {
            ChildClass va = new ChildClass();
            va.AbstractMethod();                //To see how the implementation of abstract method in child class is called.
            va.VirtualMethod();                 //To see what happens with virtual method call. If it is not implemented in the child class, base class virtual method is called.

        }
    }
}
