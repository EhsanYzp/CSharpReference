using CSharpReference.Primitives;

namespace CSharpReference.Helpers
{
    public class StructsTests
    {
        /// <summary>
        /// Tests for Structs.cs
        /// </summary>
        public static void Structs()
        {
            Structs st = new Structs();

            st.changeProperties();
            st.changeStaticFieldInStruct();
            st.structInitializationWithConstructor();
            st.structInitializationWithoutConstructor();

        }

    }
}
