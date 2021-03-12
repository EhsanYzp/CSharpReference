using System;
using System.Linq;

namespace CSharpReference.Primitives
{
    public class ArrowOperator
    {
        /// <summary>
        /// In lambda expressions, the lambda operator => separates the input variables on the left side from the lambda body on the right side. 
        /// The following example uses the LINQ feature with method syntax to demonstrate the usage of lambda expressions:
        /// </summary>
        public string UseArrowOperatorAsLambdaOperator()
        {
            string result = "";

            string[] words = { "bot", "apple", "apricot" };
            int minimalLength = words
                                .Where(w => w.StartsWith("a"))
                                .Min(w => w.Length);

            result += minimalLength.ToString();

            int[] numbers = { 1, 4, 7, 10 };
            int product = numbers.Aggregate(1, (interim, next) => interim * next);
            result += product.ToString();

            //Input variables of lambda expressions are strongly typed at compile time.
            //When the compiler can infer the types of input variables, like in the preceding example, you may omit type declarations.
            //If you need to specify the type of input variables, you must do that for each variable, as the following example shows:
            int[] numbers2 = { 1, 4, 7, 10 };
            int product2 = numbers2.Aggregate(1, (int interim, int next) => interim * next);
            result += product2.ToString();

            //The following example shows how to define a lambda expression without input variables:
            Func<string> greet = () => "lambda expression without input variables test";

            return result;
        }

        /// <summary>
        /// An expression body definition has the following general syntax: member => expression;
        /// where expression is a valid expression. The return type of expression must be implicitly convertible to the member's return type.
        /// If the member's return type is void or if the member is a constructor, a finalizer, or a property set accessor, expression must be a statement expression; it can be of any type then.
        /// </summary>
        /// <returns></returns>
        public string UseArrowOperatorAsExpressionBodyDefinition() => "some string       ".Trim();

        /// <summary>
        /// Original version of function UseArrowOperatorAsExpressionBodyDefinition() 
        /// </summary>
        /// <returns></returns>
        public string NormalFunctionEquivalentOfexpressionBodyDefinition()
        {
            return "some string       ".Trim();
        }
    }
}
