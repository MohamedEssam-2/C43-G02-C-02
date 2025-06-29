using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Write a program that allows the user to enter a number then print it.
            Console.WriteLine("enter a number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("your entered number is " + x);
            #endregion


            #region Question 2
            //Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string name = "mohamed";
            //int r = int.Parse(name);
            //Console.WriteLine();
            //cant convert from string to int except convert from string contain numbers to int like string s ="123" 
            #endregion


            #region Question 3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happe
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float sum = n1 + n2;
            Console.WriteLine("FIrst number = " + n1 + "second number = " + n2);
            Console.WriteLine(" sum = " + sum);

            // if the input contain decimal or fraction numbers they will be parsed correctly added and the result will be displayed  
            #endregion


            #region Question4
            //Write C# program that Extract a substring from a given string.
            string name = "mohamed";
            Console.WriteLine(name.Substring(2, 5));
            #endregion


            #region Question 5
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("before edit ");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            num1 = num2;
            Console.WriteLine("after edit ");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            //copy value only from num2 to num1 
            #endregion


            #region Question 6 
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Point p1 = new Point();
            Point p2 = new Point();
            Console.WriteLine("before edit ");
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);

            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);

            Console.WriteLine("Add values to p1");
            p1.x = 10;
            p1.y = 20;
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);


            Console.WriteLine("add values to p2");
            p2.x = 30;
            p2.y = 40;
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);
            p1 = p2;
            Console.WriteLine("after edit ");
            Console.WriteLine("values of p1 after edit");
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine("values of p2 after edit ");
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);

            //copy reference from p2 to p1 as p2 and p1 point to the same place at heap and both have the same value also 
            #endregion


            #region Question 7
            //Write C# program that take two string variables and print them as one variable
            Console.WriteLine("enter first name");
            string fname = Console.ReadLine();
            Console.WriteLine("enter second name");
            string lname = Console.ReadLine();

            string fullname = fname + " " + lname;
            Console.WriteLine("Fullname = " + fullname);
            #endregion


            #region Question 8 
            //Which of the following statements is correct about the C#.NET code snippet given below?
            int d;
            d = Convert.ToInt32(!(30 < 20));
            //A)value 1 will be assigned to d.
            //as 20 not greater than 30 so it will return 0 but there is not outside will reverse the 0 to 1 
            #endregion


            #region Question 9 

            //Which of the following is the correct output for the C# code given below?
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            //answer will be 6 1
            // as the default value here is int

            #endregion


            #region Question10
            //10 - What will be the output of the C# code given below?

            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            // answer is 7 7 
            //as 1<=0 return 0 and there is not outside so it return 1 then join in if stm
            // ++num = 2    +     z++ = 5  then z will be  be 6   =  7     +   " "   +  ++z =6 + 1 = 7  
            #endregion





        }
    }
}
