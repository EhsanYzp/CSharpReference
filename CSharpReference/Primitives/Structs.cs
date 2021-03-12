using System;

namespace CSharpReference.Primitives
{
    struct StructExample
    {
        public StructExample(int val, String str)              //structs constructors should take parameters. ALL struct elements should initialized in the constructor.
        {
            parameter1 = val;
            parameter2 = str;
            propVar = 200;
        }
        //public int notPermittedInt = 200;             it is not allowed to initialize variables inside the struct(except constructors and statics).
        public int parameter1;
        public String parameter2;
        public static int staticInt = 1111;         //it is possible to initialize statics inside structs

        private int propVar;            //structs can have properties

        public int PropVar
        {
            get { return propVar; }
            set { propVar = value; }
        }

        public void ExampleFunction()           //structs can have methods
        {
            Console.WriteLine($"adding two variables from struct's result is {parameter1 + propVar}"); 
        }

    }
    class Structs
    {
        /// <summary>
        /// Function for initializing struct with direct access to its parameters. 
        /// </summary>
        public void structInitializationWithoutConstructor()
        {
            StructExample st = new StructExample();
            st.parameter1 = 100;
            st.parameter2 = "some string";

            Console.WriteLine($"parameter1 is {st.parameter2} and parameter2 is {st.parameter2}");
        }

        /// <summary>
        /// Function for initializing struct with parameterized constructor.
        /// </summary>
        public void structInitializationWithConstructor()
        {
            StructExample st = new StructExample(200, "constructor string");

            Console.WriteLine($"parameter1 is {st.parameter2} and parameter2 is {st.parameter2}");
        }

        /// <summary>
        /// Function for changing static field a struct.
        /// </summary>
        public void changeStaticFieldInStruct() {
            StructExample st = new StructExample();
            //st.staticInt = 500;       compile error. Static fields of structs should be accessed using the name of the struct itself.
            StructExample.staticInt = 1000;
        }

        /// <summary>
        /// Function for getting and setting properties from/to a struct.
        /// </summary>
        public void changeProperties()
        {
            StructExample st = new StructExample();
            st.PropVar = 666;
            Console.WriteLine($"propVar is {st.PropVar}");
        }

        
    }
}
