using System;

namespace CSharpReference.OOPPrinciples
{
    class BaseClass
    {
        /// <summary>
        /// Virtual method defined and implemented in the base class may or may not be overriden by inherited classes.
        /// </summary>
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }
    class SubClass : BaseClass
    {
        /// <summary>
        /// This function overrides a virtual method defined in the base class.
        /// Using base.Greetings(), the logic of base class also may be called in the body of this method.
        /// </summary>
        public override void Greetings()
        {
            Console.WriteLine("subClass Saying Hello!");
            // base.Greetings();  
        }
    }

}
