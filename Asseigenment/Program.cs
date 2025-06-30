namespace Asseigenment

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Please Enter a Number:");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region  Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Please Enter a Number:");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else
            //{
            //    Console.WriteLine("negative");
            //}
            #endregion

            #region Write a program that takes 3 integers from the user then prints the max element and the min element.



            //Console.Write("Enter first number: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int c = int.Parse(Console.ReadLine());


            //int max = a;
            //int min =  a;

            //for (int i = 1; i < 3; i++)
            //{
            //    if (b > max )
            //        max = b;
            //    else if (c > max)
            //        max = c;
            //    if (b < min)    
            //        min = b;
            //    else if (c < min)           
            //         min = c;
            //}

            //Console.WriteLine("Max element = " + max);
            //Console.WriteLine("Min element = " + min);



            #endregion

            #region  Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Please Enter a Number:");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("The Number Is Even");
            //}
            //else
            //{
            //    Console.WriteLine("The Number Is Odd");

            //}
            #endregion

            #region Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Please Enter a Char:");
            //char ch = char.ToLower(Console.ReadLine()[0]);
            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}   
            #endregion

            #region  Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Please Enter a Number:");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //    if(i == n )
            //        Console.Write(i);
            //    else
            //        Console.Write(i + ",");

            #endregion

            #region  Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Please Enter a Number:");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //    Console.Write(n * i + " ");

            #endregion

            #region Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Please Enter a Number:");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n; i += 2)
            //    Console.Write(i + " ");

            #endregion

            #region Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter a First Number:");
            //int baseNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a Second Number:");
            //int power = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < power; i++)
            //{
            //    result *= baseNum; 
            //}
            //Console.WriteLine($"How to calculate {baseNum}^{power} = " + result);

            #endregion

            #region Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] marks = new int[5];
            //int total = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter mark {i+1}: ");
            //    marks[i] = int.Parse(Console.ReadLine()); 
            //    total += marks[i];
            //}
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine("Total Marks     = " + total);
            //Console.WriteLine("Average Marks   = " + average);
            //Console.WriteLine("Percentage      = " + percentage + "%");
            #endregion

            #region Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter Month Number (1-12):");
            //int month = int.Parse(Console.ReadLine());
            //int days = DateTime.DaysInMonth(2024, month); 
            //Console.WriteLine("Days = " + days);

            #endregion

            #region Write a program to create a Simple Calculator.
            //Console.WriteLine("Enter first number:");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an operator (+, -, *, /):");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number:");
            //double b = double.Parse(Console.ReadLine());
            //double result = 0;
            //switch (ch)
            //{
            //    case '+': result = a + b; break;
            //    case '-': result = a - b; break;
            //    case '*': result = a * b; break;
            //    case '/':
            //        if (b != 0)
            //            result = a / b;
            //        else
            //            Console.WriteLine("Error: Cannot divide by zero!");
            //        break;

            //}
            //Console.WriteLine("Result = " + result);

            #endregion

            #region Write a program to allow the user to enter a string and print the REVERSE of it
            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //string reversed = "";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reversed += str[i];
            //}

            //Console.WriteLine("Reversed string: " + reversed);
            #endregion

            #region  Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //string reversedStr = "";

            //if (input.StartsWith("-"))
            //{

            //    for (int i = input.Length - 1; i >= 1; i--)
            //    {
            //        reversedStr += input[i];
            //    }


            //    reversedStr = "-" + reversedStr;
            //}
            //else
            //{

            //    for (int i = input.Length - 1; i >= 0; i--)
            //    {
            //        reversedStr += input[i];
            //    }
            //}

            //int reversed = int.Parse(reversedStr);
            //Console.WriteLine("Reversed = " + reversed);
            #endregion

            #region  Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("Enter the start and end of the range:");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the end of the range:");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    int count = 0;

            //    if (i > 1)
            //    {
            //        for (int j = 2; j * j <= i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                count++;
            //                break;
            //            }
            //        }

            //        if (count == 0)
            //            Console.Write(i + " ");
            //    }
            //}

            #endregion

            #region  Write a program in C# Sharp to convert a decimal number into binary without using an array.

            #endregion

            #region Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            #endregion

            #region 18
            /*
             Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
             - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
             - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
             - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
             - If the worker takes more than 5 hours, they are required to leave the company. 
                    To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
             */
            #endregion

            #region Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            #endregion

            #region Write a program in C# Sharp to find the sum of all elements of the array.

            #endregion

            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            #endregion

            #region Write a program in C# Sharp to count the frequency of each element of an array.

            #endregion

            #region Write a program in C# Sharp to find maximum and minimum element in an array

            #endregion

            #region Write a program in C# Sharp to find the second largest element in an array.

            #endregion

            #region Consider an Array of Integer values with size N, having values as in this Example

            #endregion

            #region Given a list of space separated words, reverse the order of the words.

            #endregion

            #region  Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array

            #endregion

            #region Write a Program to Print One Dimensional Array in Reverse Order

            #endregion

            #region Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".


            #endregion

            #region What will be the output of the C# code given below?

            #endregion

        }
    }
}
