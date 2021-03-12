using System;
using System.Text;

namespace CSharpReference.Data_Types
{
    class StringAndStringBuilder
    {
        public String str;
        public StringBuilder sb;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="strVal">initialization value for string parameter</param>
        /// <param name="sbVal">initialization value for stringbuilder parameter</param>
        public StringAndStringBuilder(String strVal, String sbVal)
        {
            str = strVal;
            sb = new StringBuilder();
            sb.Append(sbVal);
        }

        /// <summary>
        /// Function for testing how appending to string is working
        /// </summary>
        public void TestAppendToString()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                str += "hi ";
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"elapsed milliseconds for appending to string: {elapsedMs}");
        }

        /// <summary>
        /// Function for testing how appending to stringbuilder is working
        /// </summary>
        public void TestAppendToStringBuilder()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            for (int i = 0; i < 10000; i++)
            {
                sb.Append("hi ");
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"elapsed milliseconds for appending to stringbuilder: {elapsedMs}");
            
        }

        /// <summary>
        /// This function is for testing and confirming that the string is an immutable data type.
        /// </summary>
        public void ConfirmStringImmutability()
        {
            String localStr = "local string initialized.";
            Console.WriteLine($"Before calling helper function str is {localStr}");
            StringHelperImmutability(localStr);
            Console.WriteLine($"After calling helper function str is {localStr}");
        }

        /// <summary>
        /// Helper function to append to string.
        /// </summary>
        /// <param name="str"></param>
        public void StringHelperImmutability(String str)
        {
            str += "something appended to str in helper function.";
        }

        /// <summary>
        /// This function is for testing and confirming that the stringbuilder is a mutable data type. 
        /// </summary>
        public void ConfirmStringBuilderMutability()
        {
            StringBuilder localsb = new StringBuilder();
            localsb.Append("local stringbuilder initialized.");
            Console.WriteLine($"Before calling helper function sb is {localsb}");
            StringBuilderHelperMutability(localsb);
            Console.WriteLine($"Before calling helper function str is {localsb}");
        }

        /// <summary>
        /// Helper function to append to stringbuilder.
        /// </summary>
        /// <param name="sb"></param>
        public void StringBuilderHelperMutability(StringBuilder sb)
        {
            sb.Append("something appended to sb in helper function.");
        }
    }
}
