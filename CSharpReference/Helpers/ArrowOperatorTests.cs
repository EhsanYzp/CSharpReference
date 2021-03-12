using CSharpReference.Primitives;
using System;

namespace CSharpReference.Helpers
{
    public class ArrowOperatorTests
    {
        /// <summary>
        /// Tests ArrowOperator.cs
        /// </summary>
        public static void ArrowOperator()
        {
            ArrowOperator ao = new ArrowOperator();
            ao.UseArrowOperatorAsLambdaOperator();
            string result1 = ao.UseArrowOperatorAsExpressionBodyDefinition();
            Console.WriteLine(result1);
            string result2 = ao.NormalFunctionEquivalentOfexpressionBodyDefinition();
            Console.WriteLine(result2);
        }

    }
}
