namespace CSharpReference.Primitives
{
    class Properties
    {
        
        /// <summary>
        /// Constructor which takes a parameter to set the property defined in the class.
        /// </summary>
        /// <param name="val"></param>
        public Properties(int val)
        {
            intProp = val;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Properties()
        {

        }

        //full property(read and write)
        private int intProp;
        public int IntProp
        {
            get { return intProp; }
            set { intProp = value; }
        }


        //readonly property, just having get
        private int readOnlyProperty = 1234;

        public int ReadOnlyProperty
        {
            get { return readOnlyProperty = 1234; }
           
        }

        //writeonly property, just having set
        private int writeOnlyProperty;

        public int WriteOnlyProperty
        {
            set { writeOnlyProperty = value; }
        }





    }
}
