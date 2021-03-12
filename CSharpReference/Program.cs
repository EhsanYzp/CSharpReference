using CSharpReference.Helpers;
using System;

namespace CSharpReference
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTests();
        }

        private static void RunTests()
        {
            try
            {
                AbstractClassTests.AbstractClass();                         //For testing AbstractClass.cs
                ArrowOperatorTests.ArrowOperator();                         //For testing ArrowOperator.cs
                ConstantsAndReadOnlyTests.ConstantAndReadOnly();            //For testing ConstantAndReadOnly.cs
                DelegatesTests.Delegates();                                 //For testing Delegates.cs
                EnumerablesTests.IEnumerables();                            //For testing IEnumerableAndIenumerator.cs
                EnumsTests.Enum();                                          //For testing Enums.cs
                ExtensionMethodsTests.ExtensionMethods();                   //For testing ExtensionMethod.cs
                FileManagementTests.FileManagement();                       //For testing FileManagement.cs
                GenericsTests.Generics();                                   //For testing Generics.cs
                IndexerTests.Indexer();                                     //For testing Indexer.cs
                InterfacesTests.Interfaces();                               //For testing Interfaces.cs
                LambdaExpressionTests.LambdaExpression();                   //For testing LambdaExpression.cs
                LazyLoadingTests.LazyLoading();                             //For testing LazyLoading.cs
                ListsTests.Lists();                                         //For testing Lists.cs
                NullableTypeTests.NullableType();                           //For testing NullableType.cs
                ObjectInitializerTests.ObjectInitializer();                 //For testing objectInitializer.cs
                OverloadingTests.Overloading();                             //For testing Overloading.cs
                OverridingTests.Overriding();                               //For testing Overriding.cs
                PartialClassTests.PartialClass();                           //For testing PartialClass.cs    
                PreprocessorDirectivesTests.PreprocessorDirectives();       //For testing PreprocessorDirectives.cs
                PropertiesTests.Properties();                               //For testing Properties.cs
                SealedTests.Sealed();                                       //For testing Sealed.cs
                StringAndStringBuilderTests.StringAndStringBuilder();       //For testing StringAndStringBuilder.cs
                StringFunctionsTests.StringFunctions();                     //For testing StringFunctions.cs
                StructsTests.Structs();                                     //For testing Structs.cs
                TuplesTests.Tuples();                                       //For testing Tuples.cs
                UsingStatementTests.UsingStatement();                       //For testing UsingStatement.cs
                VirtualAndAbstractTests.VirtualAndAbstract();               //For testing VirtualAndAbstract.cs

            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error}");
            }
        }
    }
}
