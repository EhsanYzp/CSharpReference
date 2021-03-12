using System;

namespace CSharpReference.Data_Types
{
    class StringFunctions
    {
        private String testString;

        public String TestString
        {
            get { return testString; }
            set { testString = value; }
        }

        public StringFunctions(String str)
        {
            TestString = str;
        }

        /// <summary>
        /// Converts string to uppercase
        /// </summary>
        public void ToUpperCase()
        {
            Console.WriteLine($"before ToUpperCase: {testString}");
            testString = testString.ToUpper();
            Console.WriteLine($"after ToUpperCase: {testString}");
        }

        /// <summary>
        /// Converts string to lowercase
        /// </summary>
        public void ToLowerCase()
        {
            Console.WriteLine($"before ToLowerCase: {testString}");
            testString = testString.ToLower();
            Console.WriteLine($"after ToLowerCase: {testString}");
        }

        /// <summary>
        ///trims the string from beginning and the end(removes extra spaces)
        /// </summary>
        public void TrimString()
        {
            Console.WriteLine($"before TrimString: {testString}");
            testString = testString.Trim();
            Console.WriteLine($"after TrimString: {testString}");
        }


        /// <summary>
        ///checks to see if the string contains a specified string or not?
        /// </summary>
        public void ContainsString(String str)
        {
            
            bool isContains = testString.Contains(str);

            if(isContains == true)
                Console.WriteLine($"input string contains: {str}");
            else
                Console.WriteLine($"input string does not contain: {str}");
        }

        /// <summary>
        /// Converts a string to a char array
        /// </summary>
        public void ConvertToCharArray()
        {
            char[] charArray = testString.ToCharArray();
            foreach (var character in charArray)
            {
                Console.WriteLine(character);
            }
        }

        /// <summary>
        /// gets a substring out of a string
        /// </summary>
        /// <param name="start">start index of substring</param>
        /// <param name="length">length of substring</param>

        public void GetSubString(int start, int length)
        {
            String substr = testString.Substring(start, length);
            Console.WriteLine($"substring is : {substr}");
        }

        /// <summary>
        /// check to see if the string starts with a specified string or not
        /// </summary>
        /// <param name="str">specified string</param>
        public void CheckStartsWith(String str)
        {
            bool isStartingWith = testString.StartsWith(str);

            if (isStartingWith == true)
                Console.WriteLine($"{testString} starts with {str}");
            else
                Console.WriteLine($"{testString} does not start with {str}");
        }

        public void SplitString()
        {
            string[] splittedString = testString.Split(' ');
            foreach (var token in splittedString)
            {
                Console.WriteLine($"splitted: {token}");
            }
        }
    }
}
