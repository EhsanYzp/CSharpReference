using CSharpReference.OOPPrinciples;
using System;

namespace CSharpReference.Helpers
{
    public class LazyLoadingTests
    {

        /// <summary>
        /// Tests LazyLoading.cs
        /// </summary>
        public static void LazyLoading()
        {
            Lazy<LazyLoading> lazy = new Lazy<LazyLoading>();
            Console.WriteLine("Data Loaded : " + lazy.IsValueCreated);

            //Whenever following line executes, the value will be populated in the LazyLoading class and
            //this is how the LazyLoading class will initialize lazily.
            LazyLoading lazyInstance = lazy.Value;
            foreach (string tmp in lazyInstance.NamesList)
            {
                Console.WriteLine(tmp);
            }
        }

    }
}
