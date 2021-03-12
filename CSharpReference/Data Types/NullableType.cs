using System;

namespace CSharpReference.Data_Types
{

    /// <summary>
    /// nullables can ONLY be used with value types and not reference types.
    /// </summary>
    class NullableType
    {
        public Nullable<int> nullableClassParameter;             //nullable defined in a class will have null value by default.

        /// <summary>
        /// Function to test the original syntax of defining a Nullable.
        /// </summary>
        public void WithNullableSyntax()
        {
            Nullable<int> i = null;     //this is the original syntax of defining nullable

            if(i.HasValue)
                Console.WriteLine(i.Value);   //or Console.WriteLine(i). If i == null or not assigned, with calling i.value there will be a compile error.
            else
                Console.WriteLine("Null");
        }

        /// <summary>
        /// Use the GetValueOrDefault() method to get an actual value if it is not null and the default value if it is null.
        /// </summary>
        public void TestGetValueOrDefault()
        {
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault());   //0 because 0 is the default value for int
        }


        /// <summary>
        /// Function to test the original syntax of defining a Nullable.
        /// </summary>
        public void WithShorthandSyntax()
        {
            int? i = null;     //this is the shorthand syntax of defining nullable

            if (i.HasValue)
                Console.WriteLine(i.Value);   //or Console.WriteLine(i). If i == null or not assigned, with calling i.value there will be a compile error.
            else
                Console.WriteLine("Null");
        }

        public void AssignNullablleToNonNullable()
        {
            int? i = null;
            int j = i ?? 0;         //will assign to j the value of i if it is not null, otherwise 0(or any other value used)
            Console.WriteLine($"i = {i} , j = {j}");
        }

        public void TestNullableDefinedAsParameterInClass()
        {
            if (nullableClassParameter == null)
                Console.WriteLine("Null"); 
        }

    }
}
