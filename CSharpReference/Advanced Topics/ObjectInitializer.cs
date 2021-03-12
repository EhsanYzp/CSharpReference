using System;
using System.Collections.Generic;

namespace CSharpReference.Advanced_Topics
{
    /// <summary>
    /// this class does not have any constructors.
    /// we can initialize its properties using the Object Initializer syntax(see class ObjectInitializer)
    /// </summary>
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
     
    }

    public class ObjectInitializer
    {

        public void ObjectInitializerTest()
        {
            //we can initialize the object with a single entity initialized in it.
            Person p = new Person()
            {
                PersonID = 1,
                PersonName = "Ehsan Yazdanparast",
                PersonAge = 32
            };

            Console.WriteLine($"person name: {p.PersonID} , person name: {p.PersonName}, person age: {p.PersonAge}");

            //We can also initialize collections with this syntax
            Person p1 = new Person() { PersonAge = 10 };
            Person p2 = new Person() { PersonName = "Asghar", PersonID = 234 };
            Person p3 = new Person() { PersonID = 11, PersonAge = 10, PersonName = "Shozab" };
            Person p4 = new Person() { PersonAge = 10, PersonID = 22 };
            Person p5 = new Person() { PersonName = "Mohsen" };

            List<Person> personList = new List<Person>
            {
                p1,
                p2,
                p3,
                p4,
                p5
            };

            foreach (var item in personList)
            {
                Console.WriteLine($"person name: {item.PersonName} , person name: {item.PersonName}, person age: {item.PersonAge}");
            }

            //We can also directly instantiate objects with object initialization
            List<Person> personList2 = new List<Person>
            {
                new Person() { PersonAge = 10 },
                new Person() { PersonName = "Asghar", PersonID = 234 },
                new Person() { PersonID = 11, PersonAge = 10, PersonName = "Shozab" },
                new Person() { PersonAge = 10, PersonID = 22 },
                new Person() { PersonName = "Mohsen" },
                null        //it is possible to specify null as an element

            };

            foreach (var item in personList2)
            {
                Console.WriteLine($"person name: {item?.PersonName} , person name: {item?.PersonName}, person age: {item?.PersonAge}");
            }

        }
    }




}
