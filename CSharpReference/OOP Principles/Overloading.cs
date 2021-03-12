namespace CSharpReference.OOPPrinciples
{
    class Overloading
    {
        /// <summary>
        /// First version of Add function
        /// </summary>
        /// <param name="a">first parameter</param>
        /// <param name="b">second parameter</param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Overloaded second version of Add function
        /// </summary>
        /// <param name="a">first parameter</param>
        /// <param name="b">second parameter</param>
        /// <param name="c">third parameter</param>
        /// <returns></returns>
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Overloaded third version of Add function
        /// </summary>
        /// <param name="a">first parameter</param>
        /// <param name="b">second parameter</param>
        /// <param name="c">third parameter</param>
        /// <param name="d">fourth parameter</param>
        /// <returns></returns>
        public double Add(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
    }
}
