using CSharpReference.Data_Types;

namespace CSharpReference.Helpers
{
    public class StringFunctionsTests
    {
        /// <summary>
        /// Tests StringFunctions.cs
        /// </summary>
        public static void StringFunctions()
        {
            StringFunctions sf = new StringFunctions("          This is a test string!       ");

            sf.ToUpperCase();                   //sf.ToUpper()               
            sf.ToLowerCase();                   //sf.ToLower()
            sf.TrimString();                    //sf.Trim()
            sf.ContainsString("is a test");     //sf.Contains("is a test")
            sf.ContainsString("That");          //sf.Contains("That")
            sf.ConvertToCharArray();            //sf.ToCharArray()
            sf.GetSubString(3, 10);             //sf.Substring(3, 10)
            sf.CheckStartsWith("this");         //sf.StartsWith("this")
            sf.CheckStartsWith("that");         //sf.StartsWith("that")
            sf.SplitString();                   //sf.Split()
        }

    }
}
