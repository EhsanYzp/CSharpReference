using CSharpReference.Advanced_Topics;
using System;

namespace CSharpReference.Helpers
{
    public class IndexerTests
    {
        /// <summary>
        /// Tests Indexer.cs
        /// </summary>
        public static void Indexer()
        {
            Indexer i = new Indexer();
            i[0] = "One";
            i[1] = "Two";
            i[2] = "Three";
            i[3] = "Four";

            for (int ii = 0; ii < 10; ii++)
            {
                Console.WriteLine(i[ii]);
            }
        }

    }
}
