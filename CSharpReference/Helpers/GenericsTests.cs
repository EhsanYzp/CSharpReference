using CSharpReference.DataStructures;

namespace CSharpReference.Helpers
{
    public class GenericsTests
    {
        /// <summary>
        /// Tests Generics.cs
        /// </summary>
        public static void Generics()
        {
            //for testing implemented generic data type with int
            Generics<int> gi = new Generics<int>();
            gi.genericFunctionAdd(5);
            gi.ReturnElements();

            //for testing implemented generic data type with double
            Generics<double> gd = new Generics<double>();
            gd.genericFunctionAdd(3.45);
            gd.ReturnElements();

        }

    }
}
