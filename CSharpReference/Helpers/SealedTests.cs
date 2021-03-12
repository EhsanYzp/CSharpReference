using CSharpReference.OOPPrinciples;

namespace CSharpReference.Helpers
{
    public class SealedTests
    {
        /// <summary>
        /// Tests Sealed.cs
        /// </summary>
        public static void Sealed()
        {
            Sealed s = new Sealed();
            s.PrintSealed();

            A a = new A();
            a.PrintSealedFunctionInParent();
            B b = new B();
            b.PrintSealedFunctionInParent();
            C c = new C();
            c.PrintSealedFunctionInParent();
        }

    }
}
