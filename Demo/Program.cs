using System;

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
            int number;
            string result;
            Console.WriteLine("Please enter the number [1,2,3]");
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    result = "Option 1";
                    break;
                case 2:
                    result = "Option 2";
                    break;
                case 3:
                    result = "Option 3";
                    break;
                default:
                    result = "Unknown option";
                    break;
            }
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





























        }
    }
}
