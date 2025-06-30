using System;
using System.Xml.Linq;

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













            #endregion






















        }
    }
}
