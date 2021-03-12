using CSharpReference.OOPPrinciples;

namespace CSharpReference.Helpers
{
    public class InterfacesTests
    {
        /// <summary>
        /// Tests the Interfaces.cs 
        /// </summary>
        public static void Interfaces()
        {
            IClassA ica = new InheritedClassA();            //This creates a IClassA instance
            ica.AbstractFunction();                         //Abstract Function of IClassA should be called in this case

            IClassB icb = (IClassB)ica;                     //Type conversion to IClassB

            //   icb.AbstractFunction();                         //Abstract Function of IClassB should be called in this case

            //    icb.FunctionJustInInterfaceB();                 //FunctionJustInInterfaceB should be called(this function is not implemented in IClassA)

        }

    }
}
