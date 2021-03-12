namespace CSharpReference.Primitives
{
    public class ConstantAndReadOnly
    {
        public int param;
        public const int constInt = 1000;
        public readonly int readOnlyInt = 500;

        /// <summary>
        /// This constructor changes the readOnlyInt value and overrides it
        /// </summary>
        /// <param name="value"></param>
        public ConstantAndReadOnly(int value)
        {
            //constInt = 50;        it is not allowed to change constant defined parameter in a constructor
            readOnlyInt = value;       //is possible to change value of readonly parameter in a public constructor.
        }

        /// <summary>
        /// This is the default constructor without applying any change to readonly parameter.
        /// </summary>
        public ConstantAndReadOnly()
        {
            
        }

        public int ConstantHelper()
        {
            //constInt = 10;        it is not allowed to change the value of the constant after its initialization
           return constInt;
        }
        public int ReadOnlyHelper()
        {
            //readOnlyInt = 500;     it is not possible to change value of a readonly parameter outside of a constructor or initialization area
           return readOnlyInt;
        }
    }
}
