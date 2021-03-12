using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReference.Advanced_Topics
{
    public class LambdaExpression
    {
        delegate bool IsTeenAger(Student stud);
        delegate bool IsYoungerThan(Student stud, int youngAge);
        delegate bool IsYoungerThanWithMultiExpression(Student stud, int youngAge);
        delegate void Print();

        /// <summary>
        /// The lambda expression is a shorter way of representing anonymous method using some special syntax.
        /// For example, following function checks if student is teenager or not
        /// </summary>
        public void TestLambdaBasicSyntax()
        {
            IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;
            Student stud = new Student() { Age = 25 };
            Console.WriteLine(isTeenAger(stud));


        }

        /// <summary>
        /// Lambda Expression with Multiple Parameters
        /// It is possible to wrap the parameters in parenthesis if you need to pass more than one parameter.
        /// </summary>
        public void LambdaWithMultipleParameters()
        {
            IsYoungerThan isYoungerThan = (s, youngAge) => s.Age < youngAge; //It is also possible to specify the parameter type like this: (Student s,int youngAge) => s.Age >= youngage;
            Student stud = new Student() { Age = 25 };
            Console.WriteLine(isYoungerThan(stud, 26));
        }


        /// <summary>
        /// This function shows that it is not necessary to have atleast one parameter in a lambda expression.
        /// The lambda expression can be specify without any parameter also.
        /// </summary>
        public void LambdaWithoutParameter()
        {
            Print print = () => Console.WriteLine("This is parameter less lambda expression");
            print();
        }


        /// <summary>
        /// This function shows that it is possible to wrap expressions in curly braces if you want to have more than one statement in the body
        /// </summary>
        public void LambdaWithMultiExpression()
        {
            IsYoungerThanWithMultiExpression isYoungerThanWithMultiExpression = (s, youngAge) =>
            {
                int localVariable = 232;            //it is also possible to declare a variable in the expression body to use it anywhere in the expression body
                Console.WriteLine($"Lambda expression with multiple statements in the body. Local Variable = {localVariable}");
                return s.Age < youngAge;
            };

            Student stud = new Student() { Age = 25 };
            Console.WriteLine(isYoungerThanWithMultiExpression(stud, 26));
        }


        /// <summary>
        /// This function shows that the lambda expression can be assigned to Func<in T, out TResult> type delegate.
        /// The last parameter type in a Func delegate is the return type and rest are input parameters.
        /// </summary>
        public void AssignLambdaExpressionToDelegate()
        {
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            Student stud = new Student() { Age = 21 };
            Console.WriteLine(isStudentTeenAger(stud));
        }


    }


    /// <summary>
    /// Helper Class for using methods of LambdaExpression
    /// </summary>
    public class Student: IComparable<Student>
    {
        public int CompareTo(Student other)
        {
            if (this.StudentName.Length >= other.StudentName.Length)
                return 1;

            return 0;
        }

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    /// <summary>
    /// Helper Class for using methods of LambdaExpression
    /// </summary>
    public class Student2
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    /// <summary>
    /// Helper Class for using methods of LambdaExpression
    /// </summary>
    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}
