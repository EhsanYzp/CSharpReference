using CSharpReference.DataStructures;

namespace CSharpReference.Helpers
{
    public class ListsTests
    {
        /// <summary>
        /// Tests Lists.cs
        /// </summary>
        public static void Lists()
        {
            Lists l = new Lists();
            l.CreateIntList();
            l.CreateStringList();
            l.CreateClassList();
            l.AddToList("this string added to string list");
            l.RemoveFromList(4);
        }

    }
}
