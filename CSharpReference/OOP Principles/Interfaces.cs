/// <summary>
///  In this file, all the necessary information about declaring and using interfaces are explained.
/// </summary>
namespace CSharpReference.OOPPrinciples
{

        public interface IClassA
        {
           string AbstractFunction();
           // int i;                                interfaces cannot contain instance fields
           // public void PublicFunction();        modifier public is not permitted with the interfaces(and also other modifiers like private, protected).
           //  void functionWithBody(){//do sth}   interface functions cannot have implementations.
           //  abstract void AbstractFunction();    interface functions cannot use abstract modifier.
        }

        public interface IClassB
        {
           string AbstractFunction();
           string FunctionJustInInterfaceB();      

        }

        //it is possible to inherit an interface from another one. It is also possible to not use public modifier.
        interface IClassC : IClassB
        {

        }

    public class InheritedClassA : IClassA, IClassB     //child class can inherit from several interfaces
        {

            //Abstract Function is existing in both IClassA and IClassB. Therefore for implementing it in InheritedClassA, we need to clarify the source of implementation.
            string IClassA.AbstractFunction()                 //this method should not used any modifier
            {
                return "this is the function implemented in the child class A";
            }

            string IClassB.AbstractFunction()                 //this method should not used any modifier
            {
                return "this is the function implemented in the child class B";
            }

            public string FunctionJustInInterfaceB()          //this method should be declared public.
            {
                return "this is the implemention of the function declard in IClassB";
            }
        } 

        

}
