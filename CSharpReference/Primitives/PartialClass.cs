using System;

namespace CSharpReference.Primitives
{
    public interface IRegister
    {
        void Register();
    }

    public interface ILogin
    {
        void Login();
    }

   //Register function is implemented in this part of partial class.
    public partial class PartialClass : IRegister, ILogin
    {
        public void Register()
        {
            Console.WriteLine("User Registered!");
        }
    }

    //login function is implemented in this part of partial class.
    public partial class PartialClass
    {
        public void Login()
        {
            Console.WriteLine("User Logged in!");
        }
    }
}
