using CSharpReference.Advanced_Topics;

namespace CSharpReference.Helpers
{
    public class DelegatesTests
    {
        /// <summary>
        /// Tests Delegates.cs
        /// </summary>
        public static void Delegates()
        {
            Delegates d = new Delegates();
            d.DelegateInvoke();
            d.DelegateAsFunctionParameter();
            d.MulticastDelegate();
        }
    }
}
