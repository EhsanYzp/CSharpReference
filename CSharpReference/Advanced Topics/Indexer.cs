namespace CSharpReference.Advanced_Topics
{

    /// <summary>
    /// Important notes to remember:
    /// 1.indexes are defined like properties and they have getter and setter methods.
    /// 2.the main use of the indexers are to simplify usage of the data types(arrays, lists,etc) defined in the classes.
    /// in general using them, instead of doing className.variable[index], we can do className[index].
    /// 3.type of indexer = type of single element of variable we want to set or get
    /// 4.we should use keyword "this" in definition of indexer to clarify that the indexer is used in the context of this class.
    /// </summary>
    public class Indexer
    {
        private string[] strArr = new string[10];       //this is the datatype we index.
                                                        //from outside, when we want to access to its elements, instead of using Indexer.strArr[index], we use Indexer[index].

        public string this[int index]
        {
            get { return strArr[index]; /* return the specified index here */ }
            set { strArr[index] = value;/* set the specified index to value here */ }
        }

    }
}
