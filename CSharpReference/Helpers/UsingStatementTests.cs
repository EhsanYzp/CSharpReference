using CSharpReference.Primitives;

namespace CSharpReference.Helpers
{
    public class UsingStatementTests
    {

        /// <summary>
        /// Tests UsingStatement.cs
        /// </summary>
        public static void UsingStatement()
        {
            UsingStatement us = new UsingStatement();
            us.FunctionWithUsingStatement();
            us.FunctionWithTryFinally();
        }

    }
}
