using CSharpReference.DataStructures;
using System;

namespace CSharpReference.Helpers
{
    public class TuplesTests
    {

        /// <summary>
        /// Tests Tuples.cs
        /// </summary>
        public static void Tuples()
        {
            Tuples t = new Tuples();
            t.AccessingTupleElements();
            t.CreateTupleWithoutInstantiation();
            t.InstantiateTuple();
            t.NestedTuple();
            t.TupleAsAMethodParameter(Tuple.Create(1, "Steve", "Jobs"));
            var returnTuple = t.TupleAsReturnType();
            Console.WriteLine(returnTuple);
        }

    }
}
