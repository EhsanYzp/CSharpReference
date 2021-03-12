using System;
using System.Collections.Generic;

namespace CSharpReference.OOPPrinciples
{
    public class LazyLoading
    {

        private List<string> namesList = null;
        public List<string> NamesList
        {
            get
            {
                return namesList;
            }
        }
        public LazyLoading()
        {
            Console.WriteLine("List Generated:");
            namesList = new List<string>() { "ehsan", "mohsen", "amir", "sepide" };
        }
    }
}
        