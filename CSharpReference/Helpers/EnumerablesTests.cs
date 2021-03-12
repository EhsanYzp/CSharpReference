using CSharpReference.Primitives;
using System;
using System.Collections.Generic;

namespace CSharpReference.Helpers
{
    public class EnumerablesTests
    {
        /// <summary>
        /// Tests IEnumerables.cs
        /// </summary>
        public static void IEnumerables()
        {
            //for testing how an implemented IEnumerable class(Users) is behaving. 
            UserInfo[] uInfo = new UserInfo[3]
            {
                new UserInfo(1,"name1","surname1"),
                new UserInfo(1,"name2","surname2"),
                new UserInfo(1,"name3","surname3")
            };

            Users users = new Users(uInfo);
            //Thanks to the implementation of this class as IEnumerable, now is possible to iterate through its items using foreach statement.
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id} , {user.Name} , {user.Location}");
            }


            //for testing how is possible to send IEnumerable to a function as an input parameter.
            IEnumerableAsArgument ieaa = new IEnumerableAsArgument();
            ieaa.DisplayIEnumerable(new List<bool> { false, true, true, false, true, false });
        }

    }
}
