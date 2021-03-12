using CSharpReference.Data_Types;

namespace CSharpReference.Helpers
{
    public class StringAndStringBuilderTests
    {
        /// <summary>
        /// Tests for StringAndStringBuilder.cs
        /// </summary>
        public static void StringAndStringBuilder()
        {
            StringAndStringBuilder ssb = new StringAndStringBuilder("stringInitialization", "stringBuilderInitialization"); //This creates a StringAbdStringBuilder instance with invoking StringAndStringBuilder(String strVal, String sbVal) constructor.

            ssb.TestAppendToString();                                           //For testing perfomance of appending operator on String.
            ssb.TestAppendToStringBuilder();                                    //For testing performance of appending operator on StringBuilder

            ssb.ConfirmStringImmutability();                                    //For testing how the strings are immutable.
            ssb.ConfirmStringBuilderMutability();                               //For testing how the stringbuilders are mutable.
        }

    }
}
