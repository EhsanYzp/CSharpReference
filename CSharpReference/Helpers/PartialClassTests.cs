using CSharpReference.Primitives;

namespace CSharpReference.Helpers
{
    public class PartialClassTests
    {
        /// <summary>
        /// Tests PartialClass.cs
        /// </summary>
        public static void PartialClass()
        {
            PartialClass pc = new PartialClass();
            pc.Register();          //Invokes register function from partial class.
            pc.Login();             //Invokes login function from partial class.
        }


    }
}
