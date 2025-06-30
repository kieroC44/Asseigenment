using System;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conditional statements - Example 2 [Age > 22]
            //Console.WriteLine("Please enter a number ");
            //int.TryParse(Console.ReadLine(), out int age);
            //if(age > 22)
            //Console.WriteLine("Age > 22");
            ////else if (age < 22)
            //Console.WriteLine("Age < 22");
            ////else
            //Console.WriteLine("Age = 22");

            //switch (age) //Relational pattern : No jump table will be created
            //switch (age)
            //{
            //    case (> 22):

            //    Console.WriteLine("Age > 22");
            //    break;
            //case (< 22):
            //    Console.WriteLine("Age < 22");
            //    break;
            //default:
            //    Console.WriteLine("Age = 22");
            //    break;
            //}
            #endregion

            #region Conditional statements - Example 3 [Name - Hello Name]
            //Console.WriteLine("Please enter your name");
            //string name = Console.ReadLine();
            ////if(name == "Mariam")
            //Console.WriteLine("Hello Mariam");
            ////else if (name == "Omar")
            //Console.WriteLine("Hello Omar");
            ////else
            //Console.WriteLine("Hello Person");

            //switch (name)
            //{
            //    case "Mariam":
            //        Console.WriteLine("Hello Mariam");
            //        break;
            //    case "Omar":
            //        Console.WriteLine("Hello Omar");
            //        break;
            //    default:
            //        Console.WriteLine("Hello Person");
            //        break;

            //}

            #endregion

            #region Conditional statements - Example 4 [Budget] - [Switch with
            //1000 == > Option 1
            //2000 == > Option 2 , Option 1
            //3000 == > Option 3 , Option 2 , Option 1
            //Console.WriteLine("Please enter the budget");
            //int.TryParse(Console.ReadLine(), out int budget);
            //switch (budget)
            //{
            //case 1000:
            //        Console.WriteLine("Option 1");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        //Console.WriteLine("Option 1");
            //        goto case 1000;
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        goto case 2000;
            //    //Console.WriteLine("Option 2");
            //    //Console.WriteLine("Option 1");
            //    default:
            //        Console.WriteLine("Unknown Option");
            //        break;
            //    }


            //  if (budget == 1000)
            //      Console.WriteLine("Option 1");
            //  else if (budget == 2000)
            //  {
            //      Console.WriteLine("Option 2");
            //      Console.WriteLine("Option 1");
            //  }
            //  else if (budget == 3000)
            //  { 
            //  Console.WriteLine("Option 3");
            //  Console.WriteLine("Option 2");
            //  Console.WriteLine("Option 1");
            //  }  
            //else
            //{
            //Console.WriteLine("Unknown option");
            //  }

            //Hamada:
            //Console.WriteLine("Hello y hamada");

            //Console.WriteLine("Please enter a number");
            ////int.TryParse(Console.ReadLine(), out int number);
            //goto Hamada;




            #endregion

            #region Switch C# 7.0 [Pattern matching - When keyword]
            #region Pattern matching
            ////[Object , integer , double]
            //object obj;
            ////allocate 4 bytes in stack
            //obj = 10; //Boxing
            //switch (obj)
            //{
            //    case int X when X < 10 && X >= 5: //Unboxing
            //        Console.WriteLine("Integer");
            //        break;
            //    case float X:
            //        Console.WriteLine("Float");
            //        break;
            //    case double X:
            //        Console.WriteLine("Double");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown datatype");
            //        break;
            //}

            #endregion



            #region User defined data type
            ////[Person]
            //Object obj = new person() { Id = 1, Name = "Mariam", Age = 20 };
            //switch (obj)
            //{
            //    case int input:
            //        Console.WriteLine("Integer value");
            //        break;
            //    case float input:
            //        Console.WriteLine("Float value");
            //        break;
            //    case person input when input.Name == "Mariam":
            //        Console.WriteLine("Person value");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown data type");
            //        break;

            //}
            #endregion
            #endregion

            #region Switch C# 8.0 [Pattern matching without alias - switch exprtession]

            #region Pattern matching without alias
            ////[Object , integer , double]
            //object obj = 10;
            //switch (obj)
            //{
            //    case int when (int)obj <= 10:
            //        Console.WriteLine("Integer");
            //        break;
            //    case float:
            //        Console.WriteLine("Float");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown data type");
            //        break;


            //}


            #endregion

            #region Switch case before pattern matching
            ////1 => Msg = Option 1
            //int number;
            //string result;
            //Console.WriteLine("Please enter the number [1,2,3]");
            //int.TryParse(Console.ReadLine(), out number);
            //switch (number)
            //{
            //    case 1:
            //        result = "Option 1";
            //        break;
            //    case 2:
            //        result = "Option 2";
            //        break;
            //    case 3:
            //        result = "Option 3";
            //        break;
            //    default:
            //        result = "Unknown option";
            //        break;
            //}
            #endregion

            #region Switch expression [Constant pattern - discard pattern]
            // msg = option 1

            //int number;
            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out number);
            //string result = number switch
            //{ 
            //1 => "Option 1", //Constant pattern
            //2 => "Option 2",
            //3 => "Option 3",
            //  => "Unknown option" //Discard pattern
            //};
            //Console.WriteLine(result);
            #endregion

            #region Property Pattern
            ////[Person]
            //person person = new person() { Id = 10, Name = "Mariam", Age = 20 };
            //string resuit = person switch
            //{
            //    { Age: 30 } => "Age = 30",
            //    { Id: 10, Name: "Mariam", Age: 20 } => "Hello mariam",
            //    { Id: 10 } => "Hello Mariam with id 10", //Property pattern
            //    { Id: 300 } => "Id is 300",
            //     _=> "Hello Person"
            //};
            //   Console.WriteLine(result);
            #endregion

            #region Nullable type - relational pattern
            // int?
            //int? X = null;
            //int? number = 100;
            //string result = number switch
            //{
            //    null => "Null",
            //    int X when X > 0 => "Positive number",
            //    int Y when Y< 0 => "Negative number",
            //       _ => "Zero"
            // };
            //Console.WriteLine(result);









            #endregion


            #endregion


            #region Switch C# 9.0 [Relational pattern - logical pattern - enhanced proper

            #region Relational Pattern
            // num < 10 , between 10 and 20 , > 20
            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out int number);
            //string result = number switch
            //{

            //    < 10 => "Number < 10",
            //    > 20 => "Number > 20",
            //    >= 10 and <= 20 => "Number between 10 , 20",
            //};
            //    Console.WriteLine(result);

            #endregion

            #region Enhanced property pattern
            //////Person is samy & age > 10
            //////Person is omar & age between 20 and 30
            //////Person's age is between 40 and 50
            //////Else == > Unknown
            //person person = new person() { Id = 1, Name = "samy", Age = 20 };
            //string result = person switch
            //{
            //    { Name: "samy", Age: > 10 } => "Hello Samy",
            //    { Name: "omar", Age: >= 20 and <= 30 } => "Hello Omar",
            //    { Age: >= 40 and <= 50 } => "Age between 40 and 50",
            //        _=> "Unknown person"
            //};
            //Console.WriteLine(result);
            #endregion






            #endregion


            #region Looping statemtns [for - foreach]

            #region Intro
            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);
            //}

            //for (int i = 1; i < 10; i++)
            //{ 
            //Console.WriteLine(i);
            //}
            //for (int i = 100; i >= 1; i -- )
            //{ 
            //Console.WriteLine(i);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5 , 6 , 7 , 8 , 9 , 10 };
            // 0 ,1, 2, 3, 4
            // size / length => 5I
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers += 10; 
            //    Console.WriteLine(numbers[i]);
            //}


            //foreach (int number in numbers)
            //{
            //    //number += 10;
            //    //Console.WriteLine(numbers[i]);
            //    //Console.WriteLine(number);
            //}




            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[5]);








            #endregion


            #region For - Foreach
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 3)
            //        break;
            //    Console.WriteLine(i);
            //}
            #endregion










            #endregion



            #region Looping statemtns [while - do while]
            #region do while
            //Let user enter an even number
            //if value odd or it's not a number == > enter value again
            //else == > print the even number
            //int number;
            //bool isParsed;
            //Console.WriteLine("Please enter an even number");
            //isParsed = int.TryParse(Console.ReadLine(), out number);
            //Console.WriteLine(number);
            //int number;
            //bool isParsed;
            //do

            //Console.WriteLine("Please enter an even number");
            //isParsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!isParsed | | number % 2 == 1);
            ////False == > !false = true
            ///True == > !true = false
            //Console.WriteLine(number);
            #endregion

            #region While
            //take a number from user and print
            //a sequence of number from number entered to 10
            //5 => 5,6,7,8,9,10
            //2 => 2,3,4,5,6,7,8,9,10
            //int number;
            //bool isParsed;
            //Console.WriteLine("Please enter a number <= 10");
            //isParsed = int.TryParse(Console.ReadLine(), out number);

            //Console.Clear();
            //if (isParsed)
            //{
            //    while (number <= 10)

            //        Console.WriteLine(number);
            //    number++;

            //}








            #endregion
            #endregion


            #region String
            //Is a Built in Class [Reference Data Type] and represente
            //They are immutable [once a string object is created, its
            //Any operation that modifies a string actually creates a
            //Internally is represented as an array of characters.
            //Each character in the string corresponds to a single cha

            #region Examples
            //string name = new string("Mariam");
            //String name2 = "Mariam";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            //name2 = "Omar";
            //Console.WriteLine(" *****************");
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());

            //string name = "Hello";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //name += " Mariam";
            //Console.WriteLine();
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            //name = "Mariam";//Synatx sugar
            #endregion


            #region String methods
            //string name = "           Hello kiero            ";
            //Static method == > Class member method == > Class
            //Non-Static method == > Object member method == > instance

            //Console.WriteLine(name.Length); //6[property]
            //Console.WriteLine(name. ToUpper());
            //Console.WriteLine(name. ToLower());
            //Console.WriteLine(name.Replace("hello","Hey"));
            //Console.WriteLine(name. Replace('M', 'H')) ;
            //Console.WriteLine(name.Remove(0, 5));
            //Console.WriteLine(name.Trim());




            #endregion











            #endregion


            #region StringBuilger
            //Is a built in class [reference data type] and represente
            //Mutable string
            //LinkedList of characters
            #region Examples
            //StringBuilder name;
            //Allocate 4 bytes in stack for reference
            //name = "Mariam"; //Invalid

            //name = new StringBuilder("Mariam");
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            ////name +=" Shindy"; //Invalid
            //name.Append(" Shindy");
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());



            //StringBuilder

            //name1 = new StringBuilder("Mariam");
            //StringBuilder name2 = new StringBuilder();
            //name2.Append("Mariam");
            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());

            //name1 = name2;
            //Console.WriteLine("Change name1");
            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());




            #endregion






            #region StringBuilder Methods

            //StringBuilder msg = new StringBuilder("Mariam");
            //msg = msg.Insert(0, "Hello");
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.Replace('M','C'));
            //Console.WriteLine(msg.Replace("Mariam","NewMariam"));
            //Console.WriteLine(msg.Remove(0,2));
            //int age = 20;
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());

            //msg.Clear();
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());

            //msg.AppendFormat(" Your age is {0}", age);
            //Console.WriteLine(name.Length); //6
            //name.AppendLine(" Shindy");
            //name.Append("Hello");
            //name.AppendJoin(",", " Yasser", "Omar", "Shindy");

            //Console.WriteLine(name);









            #endregion
            #endregion
            #region String Vs StringBuilder
            /*
            Simple and few concatenations == > String
            Large loops or frequent changes == > StringBuilder
            You care about performance == > StringBuilder
            You care about code simplicity == > String
            */









            #endregion

            #region 1D Array



            #region Array advantages and disadvatanges


            //Array arr = new Array();
            //allocate 4 bytes in stack
            //numbers = new int[4] { 1, 2, 3, 4 };
            //numbers = new int[] { 1, 2, 3, 4 };
            //int[] numbers = { 1, 2, 3, 4 };
            //int[] numbers = [ 1, 2, 3, 4 ];

            //int[] numbers = new int[3];
            //Array. Fill(numbers, 5);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //Array arr = Array.CreateInstance(typeof(int), 5);

            // arr.SetValue(10, 0);
            // arr.SetValue(20, 1);
            // arr.SetValue(30, 2);
            // arr.SetValue(40, 3);
            // arr.SetValue(50, 4);
            // Console.WriteLine(arr.GetValue(0));

            //object[] data = new object[3] { 1, "Mariam", true };
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] Numbers = { 1, 2, 3, 4 };
            //for(int i = 0; i < 4; i++)
            //Console.WriteLine(Numbers[i]);


            //int[] Numbers = new int[5];
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"Please enter the array element {i + 1}");
            //    int.TryParse(Console.ReadLine(), out Numbers[i]);
            //}
            //Console.Clear();
            //for (int i = 0; i < Numbers.Length; i++)
            //       Console.WriteLine(Numbers[i]);






            // new
            //1] allocate required at heap [4 * 4 = 16 bytes]
            //2] Inialize default value [o]
            //3] Call user defined ctor if exist
            //4] Assign reference in stack to instance in heap

            //int[] Numbers = new int[5] { 1, 2, 3, 4, 5 } ;

            //foreach (int number in Numbers)
            //Console.WriteLine(number);

            //char[] characters = new char[3];
            //default char \e
            //char m = default;
            //Console.WriteLine(m);
            //Console.WriteLine((int)m);

            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank); //D

            #endregion



            #endregion

            #region 2D Array
            //int[,] marks = new int[2, 5] { { 100, 200, 300, 400, 500 }, { 10, 20, 30, 40, 50 } };

            ////for(int i = 0; i < 2; i++) //rows
            ////{

            ///for (int j = 0; j < 5; j++)
            //{
            ////            Console.Write(marks[i, j] + " ");
            ///            Console.WriteLine();
            ///}

            //Console.WriteLine(marks.Length);
            //Console.WriteLine(marks.Rank);

//            int[,] marks = new int[2, 5];
//            for (int i = 0; i < 2; i++) 
//            {
//                Console.WriteLine($"Please enter student number {i + 1} info ");
//                for (int j = 0; j < 5; j++)
//                { 
//            Console.WriteLine($"Please enter the grade for subject {j + 1}");
//            int.TryParse(Console.ReadLine(), out marks[i, j]);
//        }
//    }
//    Console.Clear();
//            for (int i = 0; i< 2; i++)
//        {
//                Console.WriteLine($" Info for student number {i + 1} ");
//            for (int j = 0; j< 5; j++)
//        {
//                Console.Write($"{marks[i, j]} ");
//        }
//            Console.WriteLine();

//}




            #endregion

        }
    }
}
