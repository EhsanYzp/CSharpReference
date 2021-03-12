using System.Collections.Generic;

namespace CSharpReference.Advanced_Topics
{
    /// <summary>
    /// Delegate is a function pointer. It is reference type data type.
    /// Syntax: public delegate void <function name>(<parameters>)
    /// A method that is going to assign to delegate must have same signature as delegate.
    /// Delegates can be invoke like a normal function or Invoke() method.
    /// Multiple methods can be assigned to the delegate using "+" operator. It is called multicast delegate.
    /// </summary>
    public class Delegates
    {
        //This is the prototype of defined delegate.
        public delegate int ReturnVals(int value);

        /// <summary>
        /// This function invokes the delegate called Print.
        /// </summary>
        public List<int> DelegateInvoke()
        {
            List<int> result = new List<int>();

            // Print delegate points to PrintNumber
            ReturnVals returnDel = ReturnNumber;

            // or
            // Print returnDel = new Print(PrintNumber);

            result.Add( returnDel(1) );                   //direct invoke
            result.Add( returnDel.Invoke(2) );            //invoking using Invoke


            // Print delegate points to PrintMoney
            returnDel = ReturnMoney;

            result.Add( returnDel(3) );
            result.Add( returnDel.Invoke(4) );

            return result;

        }

        /// <summary>
        /// This function calls another functions which receive delegates as input parameter.
        /// </summary>
        public List<int> DelegateAsFunctionParameter()
        {
            List<int> result = new List<int>();

            result.Add( HelperFunction(ReturnNumber, 1) );
            result.Add( HelperFunction(ReturnMoney, 2) );

            return result;
        }


        /// <summary>
        /// The delegate can points to multiple methods. 
        /// A delegate that points multiple methods is called a multicast delegate. 
        /// The "+" operator adds a function to the delegate object and
        /// the "-" operator removes an existing function from a delegate object.
        /// </summary>
        public List<int> MulticastDelegate()
        {
            List<int> result = new List<int>();

            ReturnVals returnDel = ReturnNumber;
            returnDel += ReturnHexadecimal;
            returnDel += ReturnMoney;

            result.Add( returnDel(1) );

            returnDel -= ReturnHexadecimal;
            result.Add( returnDel(2) );

            return result;
        }


        /// <summary>
        /// A method can have a parameter of a delegate type and can invoke the delegate parameter.
        /// </summary>
        /// <param name="delegateFunc">parameter of a delegate type</param>
        /// <param name="numToPrint">int parameter passed to delegate</param>

        public static int HelperFunction(ReturnVals delegateFunc, int numToPrint)
        {
            return delegateFunc(numToPrint);
        }

        /// <summary>
        /// A function having the signature of defined Print delegate.
        /// </summary>
        /// <param name="num">input parameter to print</param>
        public static int ReturnNumber(int num)
        {
            return num;
        }

        /// <summary>
        /// A function having the signature of defined Print delegate.
        /// </summary>
        /// <param name="money">input parameter to print</param>
        public static int ReturnMoney(int money)
        {
            return money;
        }


        /// <summary>
        /// A function having the signature of defined Print delegate.
        /// </summary>
        /// <param name="money">input parameter to print</param>
        public static int ReturnHexadecimal(int dec)
        {
            return dec;
        }

    }
}
