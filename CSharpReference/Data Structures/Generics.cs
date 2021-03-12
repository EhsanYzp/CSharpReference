namespace CSharpReference.DataStructures
{
    public class Generics<T>
    {
        //implemented generic array. It can be int, float, double, etc.
        public T[] genericArray = new T[5];

        /// <summary>
        /// This function adds a value to one of the elements of the implemented array
        /// </summary>
        /// <param name="value"></param>
        public T genericFunctionAdd(T value)
        {
            genericArray[2] = value;
            return genericArray[2];
        }

        /// <summary>
        /// This function prints the elements of implemented generic array
        /// </summary>
        public T[] ReturnElements()
        {
            return genericArray;                         
        }
    }
}
