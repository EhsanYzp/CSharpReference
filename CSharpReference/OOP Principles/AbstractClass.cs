namespace CSharpReference.OOPPrinciples
{
    abstract public class AbstractClass
    {
        //Abstract class can have abstract(or not abstract) properties
        private int abstractProperty;

        abstract public int AbstractProperty
        {
            get;
            set;
        }

        //Abstract class can have non-abstract(or abstract variables)
        public string stringVariable;

        //Abstract methods defined in the base class can not have implementation in the base class and SHOULD HAVE implementation in any child class which they have!
        abstract public string AbstractMethod();

        virtual public string VirtualMethod()
        {
            return "Virtual Method SHOULD HAVE implementation in the base class and CAN BE overriden in the child classes.";
        }


    }

    abstract public class AbstractClass2
    {
        //JUst for testing multi-inheritance
    }

    public class ChildClassFromAbstract: AbstractClass
    {

        public ChildClassFromAbstract(bool var, int propVal )
        {
            this.ChildOwnVariable = var;
            this.AbstractProperty = propVal;
        }

        private bool ChildOwnVariable = true;    //child classes may have their own variables(or properties) which are not defined in the base class.
        private int abstractProperty;


        /// <summary>
        /// This function prints out the variable and property(overriden from base class) defined in the child class.
        /// </summary>
        public string PrintVariableAndPropertyValues()
        {
            return "ChildOwnVariable = " + ChildOwnVariable + ", abstractProperty = " + abstractProperty;
        }
        /// <summary>
        /// implementation of the property defined in the base class
        /// </summary>
        public override int AbstractProperty 
        {
            get { return abstractProperty; }
            set { abstractProperty = value; }
        }

        /// <summary>
        /// This is the method defined in the base class and the representative logic is defined by a child class.
        /// </summary>
        public override string AbstractMethod()
        {
            return "Abstract methods defined in the base class SHOULD BE implemented in any class inherited from it.";
        }

        /// <summary>
        /// Classes derived from a base class may have their own specific methods like this one!
        /// </summary>
        public string ChildOwnMethod()
        {
            return "Child classes may have their own specific methods(not defined in base class)";
        }

        /// <summary>
        /// Virtual methods defined in the base class may or maybe be overriden in the child class! This is an example function 
        /// which calls the base implemented version of the function and then implements some logic on top of it.
        /// </summary>
        public override string VirtualMethod()
        {
            base.VirtualMethod();
            return "Virtual methods defined in the base class may or maybe be overriden in the child class!";
        }

    }

    //It is not allowed for a child class to inherit from more than one base class.
    //public class ChildClass2FromBaseClass: AbstractClass, AbstractClass2
    //{

    //}
}
