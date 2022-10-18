//using System;

//namespace GenericsDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

/*18.10.2022. I use this tutorial: https://dotnettutorials.net/lesson/generics-csharp/
so I create a console application project called "https://dotnettutorials.net/lesson/generics-csharp/"
and set it as the startup project. Also I change Program.cs to ClsMain.cs
and content from: "namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}"
to "namespace GenericsDemo
{
    public class ClsMain
    {
        private static void Main()
        {
            bool IsEqual = ClsCalculator.AreEqual(10, 20);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }

            Console.ReadKey();
        }
    }

    public class ClsCalculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
    }
}"*/

using System;
//namespace GenericsDemo
//{
//    public class ClsMain
//    {
//        private static void Main()
//        {
//            bool IsEqual = ClsCalculator.AreEqual(10, 20);
//            if (IsEqual)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }

//            Console.ReadKey();
//        }
//    }

//    public class ClsCalculator
//    {
//        public static bool AreEqual(int value1, int value2)
//        {
//            return value1 == value2;
//        }
//    }
//}

/*18.10.2022. To be able to compare even string values, not only integer values, I do this:
Modifying the Method to accept any data type values:
Let’s modify the AreEqual() method of the ClsCalculator class to use the Object data type as shown below.

namespace GenericsDemo
{
    public class ClsMain
    {
        private static void Main()
        {
           // bool IsEqual = ClsCalculator.AreEqual(10, 20);
            bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }
    public class ClsCalculator
    {
        //Now this method can accept any data type
        public static bool AreEqual(object value1, object value2)
        {
            return value1 == value2;
        }
    }
}*/

////Modifying the Method to accept any data type values:
////Let’s modify the AreEqual() method of the ClsCalculator class to use the Object data type as shown below.

//namespace GenericsDemo
//{
//    public class ClsMain
//    {
//        private static void Main()
//        {
//           // bool IsEqual = ClsCalculator.AreEqual(10, 20);
//            bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
//            if (IsEqual)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            Console.ReadKey();
//        }
//    }
//    public class ClsCalculator
//    {
//        //Now this method can accept any data type
//        public static bool AreEqual(object value1, object value2)
//        {
//            return value1 == value2;
//        }
//    }
//}

/*18.10.2022. I use this tutorial https://dotnettutorials.net/lesson/generics-csharp/
That’s it. Run the application and you will see it is working as expected. Let’s see the problem of the above code implementation.

We get poor Performance due to boxing and unboxing. The object type needs to be converted to the value type.
Now, the AreEuqal() method is not type-safe. Now it is possible to pass a string value for the first parameter and an integer value for the second parameter. 
Method Overloading to Achieve the same:
Another option is we need to overload the AreEqual method which will accept different types of parameters as shown below. As you can see in the below code, now we have created three methods with the same name but with different types of parameters. This is nothing but method overloading. Now, run the application and you will see everything is working as expected.

namespace GenericsDemo
{
    public class ClsMain
    {
        private static void Main()
        {
           // bool IsEqual = ClsCalculator.AreEqual(10, 20);
           // bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
            bool IsEqual = ClsCalculator.AreEqual(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }
    public class ClsCalculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(string value1, string value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(double value1, double value2)
        {
            return value1 == value2;
        }
    }
}
The problem with the above code implementation is that we are repeating the same logic in each and every method. However, if tomorrow we need to compare two float or two long values then again we need to create two more methods.
*/

//namespace GenericsDemo
//{
//    public class ClsMain
//    {
//        private static void Main()
//        {
//            // bool IsEqual = ClsCalculator.AreEqual(10, 20);
//            // bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
//            bool IsEqual = ClsCalculator.AreEqual(10.5, 20.5);
//            if (IsEqual)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            Console.ReadKey();
//        }
//    }
//    public class ClsCalculator
//    {
//        public static bool AreEqual(int value1, int value2)
//        {
//            return value1 == value2;
//        }
//        public static bool AreEqual(string value1, string value2)
//        {
//            return value1 == value2;
//        }
//        public static bool AreEqual(double value1, double value2)
//        {
//            return value1 == value2;
//        }
//    }
//}

/*The problem with the above code implementation is that we are repeating the same logic in each and every method. However, if tomorrow we need to compare two float or two long values then again we need to create two more methods.

How to solve the above Problems?
We can solve all the above problems with Generics in C#. With generics, we will make the AreEqual() method to works with different types of data types. Let us first modify the code implementation to use the generics and then we will discuss how it works.

namespace GenericsDemo
{
    public class ClsMain
    {
        private static void Main()
        {
            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }
    public class ClsCalculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}*/

namespace GenericsDemo
{
    public class ClsMain
    {
        private static void Main()
        {
            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }

    public class ClsCalculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}

/*Here in the above example, in order to make the AreEqual() method generic (generic means the same method will work with the different data types), we specified the type parameter T using the angular brackets <T>. Then we use that type as the data type for the method parameters as shown in the below image.

Generics in C#

At this point, if you want to invoke the above AreEqual() method, then you need to specify the data type on which the method should operate. For example, if you want to work with integer values, then you need to invoke the AreEqual() method by specifying int as the data type as shown in the below image using angular brackets.

Invoking Generic Methods in C#

The above AreEqual() generic method is working as follows:

How the Generic Methods work in C#

If you want to work with the string values, then you need to call the AreEqual() method as shown below.
bool IsEqual= ClsCalculator.AreEqual<string>(“ABC”, “ABC”);
Now, I hope you understand the need and importance of Generics in C#.*/

/* 18.10.2022. I commit and push to git changes with message "18.10.2022. Making BlazorApp and beginning
working with GenericsDemo*/