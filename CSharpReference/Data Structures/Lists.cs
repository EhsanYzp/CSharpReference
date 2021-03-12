using System.Collections.Generic;

namespace CSharpReference.DataStructures
{
    public class PersonList
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }



    }
    public class Lists
    {
        public List<int> integerList;
        public List<string> stringList;
        public List<PersonList> personList;

        public List<int> CreateIntList()
        {
            integerList = new List<int>(5) { 1, 2, 3, 4, 5 };
            return integerList;
        }

        public List<string> CreateStringList() {
            stringList =  new List<string>() { "name 1", "name 2", "name 3" };
            return stringList;
        }

        public List<PersonList> CreateClassList()
        {
            personList = new List<PersonList>()
            {
                new PersonList{ Age = 12, FirstName = "name1", LastName = "lastname1"},
                new PersonList{ Age = 24, FirstName = "name2", LastName = "lastname2"},
                new PersonList{ Age = 30, FirstName = "name3", LastName = "lastname3"},
            };
            return personList;
        }

        public List<string> AddToList(string someString)
        {
            stringList.Add(someString);
            return stringList;            
        }

        public List<int> RemoveFromList(int integerToRemove)
        {
            integerList.Remove(integerToRemove);
            return integerList;
        }

        public void AddRangeToStringList()
        {
            
        }


    }
}
