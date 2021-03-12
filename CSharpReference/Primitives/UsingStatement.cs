using System;
using System.IO;

namespace CSharpReference.Primitives
{
    class UsingStatement
    {
        /// <summary>
        /// This function includes a using statement to demonstrate disposing unmanaged types.
        /// </summary>
        public void FunctionWithUsingStatement()
        {
            using (TextWriter w = File.CreateText(".\\logUsing.txt")  )
            {
                w.WriteLine("This is line one!");
            }
        }

        /// <summary>
        /// This function includes a try finally statement to demonstrate disposing unmanaged types.
        /// </summary>
        public void FunctionWithTryFinally()
        {
            TextWriter w = File.CreateText(".\\logTryFinally.txt");
            try
            {
                w.WriteLine("This is line one!");
            }
            finally
            {
                if (w != null)
                    ((IDisposable)w).Dispose();
            }
    
        }
    }
}
