using System;

namespace CSharpReference.Primitives
{
    public class Enums
    {
        //by default enum values starts from 0 and have increment of 1 for each element.
        //it is possible to change the numeric values by manually giving values to enum elements
        public enum Rate
        {
            Weak = 10,
            Normal = 20,
            Good,               //good will be 21
            Excellent = 30           
        }

        /// <summary>
        /// This function prints the strings of enum defined in this class.
        /// </summary>
        public string[] GetStringsOfEnum()
        {
            return Enum.GetNames(typeof(Rate));
          
        }

        /// <summary>
        /// This function prints the integer values of the enum defined in this class.
        /// </summary>
        public int[] GetValuesOfEnum()
        {
          return (int[])Enum.GetValues(typeof(Rate));
            
        }

        /// <summary>
        /// This function prints an example single element of the enum as string or integer.
        /// </summary>
        public int GetSingleElementsFromEnum()
        {
            return (int)Rate.Weak;
        }
    }
}
