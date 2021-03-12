using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpReference.Primitives
{


    public class UserInfo
    {
        /// <summary>
        /// Example helper class
        /// </summary>
        /// <param name="id">person id</param>
        /// <param name="name">person name</param>
        /// <param name="location">person location</param>
        public UserInfo(int id, string name, string location)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }
    }

    /// <summary>
    /// example class implementing IEnumerable interface.
    /// </summary>
    public class Users : IEnumerable
    {
        private UserInfo[] _user;
        public Users(UserInfo[] uArray)
        {
            _user = new UserInfo[uArray.Length];
            for (int i = 0; i < uArray.Length; i++)
            {
                _user[i] = uArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public UsersEnum GetEnumerator()
        {
            return new UsersEnum(_user);
        }
    }

    /// <summary>
    /// example class implementing IEnumerator interface.
    /// </summary>
    public class UsersEnum : IEnumerator
    {
        public UserInfo[] _user;
        int currentIndex = -1;

        public UsersEnum(UserInfo[] list)
        {
            _user = list;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < _user.Length);
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public UserInfo Current
        {
            get
            {
                try
                {
                    return _user[currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }

    /// <summary>
    /// This class is for testing how enumerable argument can be passed to functions, etc.
    /// </summary>
    public class IEnumerableAsArgument
    {
      public IEnumerable<bool> DisplayIEnumerable(IEnumerable<bool> argument)
        {
            return argument;
        }  
    }

}
