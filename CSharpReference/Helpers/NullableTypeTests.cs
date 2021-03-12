using CSharpReference.Data_Types;

namespace CSharpReference.Helpers
{
    public class NullableTypeTests
    {
        /// <summary>
        /// Tests NullableType.cs
        /// </summary>
        public static void NullableType()
        {
            NullableType nt = new NullableType();

            nt.AssignNullablleToNonNullable();
            nt.TestGetValueOrDefault();
            nt.TestNullableDefinedAsParameterInClass();
            nt.WithNullableSyntax();
            nt.WithShorthandSyntax();
        }

    }
}
