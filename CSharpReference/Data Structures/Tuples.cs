using System;

namespace CSharpReference.DataStructures
{
    class Tuples
    {
        /// <summary>
        /// instantiates a tuple with three elements(in general tuples can have up to 8 elements).
        /// </summary>
       public void InstantiateTuple()
       {
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "ehsan", "yazdanparast");
       }

        /// <summary>
        /// creating a tuple with 8 elements
        /// </summary>
        public void CreateTupleWithoutInstantiation()
        {
            var person = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
        }


        /// <summary>
        /// The elements of a tuple can be accessed with Item<elementNumber> properties
        /// e.g. Item1, Item2, Item3 and so on up to Item7 property.
        /// The Item1 property returns the first element, Item2 returns the second element and so on.
        /// The last element (the 8th element) will be returned using the Rest property.
        /// </summary>
        public void AccessingTupleElements()
        {
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1); // returns 1
            Console.WriteLine(person.Item2); // returns "Steve"
            Console.WriteLine(person.Item3); // returns "Jobs"


            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(numbers.Item1); // returns "One"
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns 3
            Console.WriteLine(numbers.Item4); // returns "Four"
            Console.WriteLine(numbers.Item5); // returns 5
            Console.WriteLine(numbers.Item6); // returns "Six"
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest); // returns (8)
            Console.WriteLine(numbers.Rest.Item1); // returns 8
        }

        /// <summary>
        /// If you want to include more than eight elements in a tuple, you can do that by nesting another tuple object as the eighth element.
        /// The last nested tuple can be accessed using the Rest property. 
        /// To access the nested tuple's element, use the Rest.Item1.Item<elelementNumber> property.
        /// </summary>
        public void NestedTuple()
        {
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbers.Item1); // returns 1
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest.Item1); //returns (8, 9, 10, 11, 12, 13)
            Console.WriteLine(numbers.Rest.Item1.Item1); //returns 8
            Console.WriteLine(numbers.Rest.Item1.Item2); //returns 9
        }


        /// <summary>
        /// A method can have a tuple as a parameter.
        /// </summary>
        /// <param name="person"></param>
        public void TupleAsAMethodParameter(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }

        /// <summary>
        /// A Tuple can be return from a method.
        /// </summary>
        /// <returns></returns>
        public Tuple<int, string, string> TupleAsReturnType()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }

    }
}
