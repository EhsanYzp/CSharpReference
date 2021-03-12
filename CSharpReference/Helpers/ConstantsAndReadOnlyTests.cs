using CSharpReference.Primitives;

namespace CSharpReference.Helpers
{
    public class ConstantsAndReadOnlyTests
    {
        /// <summary>
        /// Tests the ConstantAndReadOnly.cs
        /// </summary>
        public static void ConstantAndReadOnly()
        {
            ConstantAndReadOnly caro = new ConstantAndReadOnly(1367);           //This creates a ConstantAndReadOnly instance with invoking ConstantAndReadOnly(int value) constructor.
            caro.ConstantHelper();                                              //This should print the constant value initialized with parameter declaration
            caro.ReadOnlyHelper();                                              //This should print the readonly value initialized with parameter declaration and overriden in constructor later on

            ConstantAndReadOnly caroDefaulyConstructor = new ConstantAndReadOnly();     //This creates a ConstantAndReadOnly instance with invoking ConstantAndReadOnly() constructor.
            caroDefaulyConstructor.ReadOnlyHelper();                                    //This should print the readonly value initialized with parameter declaration.
        }

    }
}
