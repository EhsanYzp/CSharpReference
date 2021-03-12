using CSharpReference.Advanced_Topics;

namespace CSharpReference.Helpers
{
    public class LambdaExpressionTests
    {

        /// <summary>
        /// Tests LambdaExpression.cs
        /// </summary>
        public static void LambdaExpression()
        {
            LambdaExpression le = new LambdaExpression();
            le.AssignLambdaExpressionToDelegate();
            le.LambdaWithMultiExpression();
            le.LambdaWithMultipleParameters();
            le.LambdaWithoutParameter();
            le.TestLambdaBasicSyntax();
        }

    }
}
