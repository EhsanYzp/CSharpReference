using CSharpReference.Primitives;

namespace CSharpReference.Helpers
{
    public class EnumsTests
    {

        /// <summary>
        /// Tests Enums.cs
        /// </summary>
        public static void Enum()
        {
            Enums e = new Enums();
            e.GetStringsOfEnum();              //Prints the strings of the enum defined in Enums class.
            e.GetValuesOfEnum();               //Prints the integer values of the enum defined in the Enum class.
            e.GetSingleElementsFromEnum();    //Prints single element of the enum either as string or an integer.
        }


    }
}
