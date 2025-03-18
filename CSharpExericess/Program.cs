using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------
            /*1

          int Number;
          Console.WriteLine("Enter the Number: \n");
          Number = int.Parse(Console.ReadLine());
         if (Number%2==0)
         {
           Console.WriteLine("\n The number is even");
          }
           else
          {
          Console.WriteLine("\n The number is odd");
           }

            //----------------------------------------------------------------------
            /*2
            int Num1, Num2, Num3;
            Console.WriteLine("Enter the Num1: \n");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Num2: \n");
            Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Num3: \n");
            Num3 = int.Parse(Console.ReadLine());

            int Largest;
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine("\n The Num1 is largest");
            }
            else  if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine("\n The Num2 is largest");
            }
            else 
            {
                Console.WriteLine("\n The Num3 is largest");
            }
            */

            //--------------------------------------------------------------

            /* 
             * 3
             float Temp;
             Console.WriteLine("Enter the temperature converter: \n");
            Temp = float.Parse(Console.ReadLine());
            double result;
            result = (Temp * 9 / 5) + 32;
            Console.WriteLine(result);
             */
            //---------------------------------------------------------------------
            /*
             * 4
            float price;
            Console.WriteLine("Enter the price: \n");
            price = float.Parse(Console.ReadLine());
            double result;
            result = price * 10%100;
            Console.WriteLine(result);
         */
            //---------------------------------------------------------------------
            /*
             * 5
             int Marks;
             Console.WriteLine("Enter your mark: \n");
             Marks = int.Parse(Console.ReadLine());
             if (Marks >= 90)
             {
                 Console.WriteLine("\n A");
             }
             else if (Marks >= 80)
             {
                 Console.WriteLine("\n B");
             }
             else if (Marks >= 70)
             {
                 Console.WriteLine("\n C");
             }
             else if (Marks >= 60)
             {
                 Console.WriteLine("\n D");
             }
             else
             {
                 Console.WriteLine("\n F");

             }
             */
            //-------------------------------------------------------------

            /*
             * 6
           int Num1, Num2;
           Console.WriteLine("Enter the Number1: \n");
           Num1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the Number2: \n");
           Num2 = int.Parse(Console.ReadLine());

           int n = Num1;
           Num1 = Num2;
           Num2 = n;
           Console.WriteLine("Number After Swap: \n");
           Console.WriteLine("Number After Swap:"+Num1);
           Console.WriteLine("Number After Swap:" + Num2);
           */
            //---------------------------------------------------------------
            /*
             * 8
            float Units;
            Console.WriteLine("Enter the Units: \n");
            Units = int.Parse(Console.ReadLine());
             if (Units < 100)
            {
                Console.WriteLine(Units*0.5);
            }
            else if (Units < 300)
            {
                Console.WriteLine(Units * 0.75 );

            }
            else if (Units > 301)
            {
                Console.WriteLine(Units * 1);

            }
            */
            //--------------------------------------------------------------
            //1.Simple Calculator(Switch - Case)

            /* int Num1, Num2  ;
             string Operator;
             Console.WriteLine("Enter the Number1: \n");
             Num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the Number2: \n");
             Num2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the Operator: \n");
             Operator = int.Parse(Console.ReadLine());

             if (Operator ==  )
             {
                 Console.WriteLine(Num1+Num2);
            */
            //-----------------------------------------------------------------------------------------

            // secound Exericess
            //    while (true)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("\nSelect a Program:");
            //        Console.WriteLine("1. Simple Calculator");
            //        Console.WriteLine("2. Basic ATM System");
            //        Console.WriteLine("3. Geometry Calculator");
            //        Console.WriteLine("4. Factorial of a Number");
            //        Console.WriteLine("5. Sum of Even and Odd Numbers");
            //        Console.WriteLine("6. Scientific Calculator");
            //        Console.WriteLine("7. Print Triangle Pattern");
            //        Console.WriteLine("8. Print Pyramid Pattern");
            //        Console.WriteLine("9. Print Diamond Pattern");
            //        Console.WriteLine("10. Guess the Number Game");
            //        Console.WriteLine("0. Exit");

            //        Console.Write("Enter your choice: ");
            //        int choice = int.Parse(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case 1: SimpleCalculator(); break;
            //            case 2: BasicATM(); break;
            //            case 3: GeometryCalculator(); break;
            //            case 4: Factorial(); break;
            //            case 5: SumEvenOdd(); break;
            //            case 6: ScientificCalculator(); break;
            //            case 7: PrintTriangle(); break;
            //            case 8: PrintPyramid(); break;
            //            case 9: PrintDiamond(); break;
            //            case 10: GuessGame(); break;
            //            case 0: return;
            //            default: Console.WriteLine("Invalid Choice! Try again."); break;
            //        }
            //        Console.ReadLine();
            //    }
            //}


            ////1. Simple Calculator
            //static void SimpleCalculator()
            //{

            //    Console.WriteLine("Enter the operation number :\n1. Addition\n2. Subtraction ");
            //    Console.WriteLine("3. Multiplication\n4. Division");
            //    int OperationNumber = int.Parse(Console.ReadLine());
            //    Console.Write("Enter First Number:\n");
            //    double FirstNumber = double.Parse(Console.ReadLine());

            //    Console.Write("Enter Second Number:\n");
            //    double SecondNumber = double.Parse(Console.ReadLine());
            //    double result = 0;
            //    bool isactive = false;
            //    switch (OperationNumber)
            //    {
            //        case 1:
            //            result = FirstNumber + SecondNumber;
            //            break;


            //        case 2:
            //            result = FirstNumber - SecondNumber;
            //            break;


            //        case 3:
            //            result = FirstNumber * SecondNumber;
            //            break;



            //        case 4:
            //            if (SecondNumber == 0)
            //            {
            //                Console.WriteLine("Division by zero not allowed");
            //                isactive = true;
            //            }
            //            else
            //            {
            //                result = FirstNumber / SecondNumber;
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("This choies Not Found!!");
            //            isactive = true;
            //            break;
            //    }
            //    if (!isactive)
            //    {
            //        Console.WriteLine(result);
            //    }
            //}


            ////2. Basic ATM System
            //static void BasicATM()
            //{

            //    double balance = 1000;
            //    while (true)
            //    {
            //        Console.WriteLine("\nATM menu:");
            //        Console.WriteLine("1.Withdraw");
            //        Console.WriteLine("2.Debost");
            //        Console.WriteLine("3.Check Balance");
            //        Console.WriteLine("4.Exite");
            //        Console.WriteLine("Enter your choice: ");
            //        int choice = int.Parse(Console.ReadLine());


            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine("Enter Amount to withdraw");
            //                int WithdrawAmount = int.Parse(Console.ReadLine());
            //                if (WithdrawAmount > balance) Console.WriteLine("Insufficient funds");
            //                else { balance -= WithdrawAmount; Console.WriteLine($"Withdrawal succesful,New balance:{balance}"); }

            //                break;
            //            case 2:
            //                Console.WriteLine("Enter the amount to deposit: ");
            //                double Deposit = double.Parse(Console.ReadLine());
            //                balance += Deposit;
            //                Console.WriteLine($"Succeful depost \nNew balance:{balance}");

            //                break;

            //            case 3:
            //                Console.WriteLine("Your current balance is :" + balance);
            //                break;
            //            case 4:

            //                return;
            //            default:
            //                Console.WriteLine("Invaild choies,plesce select the correct choies");

            //                break;
            //        }

            //    }
            //}
            ////3.Geometry Calculator
            //static void GeometryCalculator()
            //{

            //    Console.WriteLine("choos one shapes: \n");

            //    Console.WriteLine("1. Circle (Calculate Area & Circumference),2. Square (Calculate Area & Perimeter),3. Triangle (Calculate Area) \n ");
            //    char shape = char.Parse(Console.ReadLine());

            //    switch (shape)
            //    {
            //        case '1':
            //            Console.WriteLine("Enter the redius: \n");
            //            double redius = double.Parse(Console.ReadLine());
            //            double area = Math.PI * redius * redius;
            //            double Circumference = 2 * Math.PI * redius;
            //            Console.WriteLine("Area: " + area + "\nCircumference " + Circumference);

            //            break;
            //        case '2':
            //            Console.WriteLine("Enter the side: \n");
            //            double side = double.Parse(Console.ReadLine());
            //            area = side * side;
            //            double Perimeter = 4 * side;
            //            Console.WriteLine("Area: " + area + "\nPerimeter: " + Perimeter);
            //            break;

            //        case '3':
            //            Console.WriteLine("Enter height:\n");
            //            double height = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter height:\n");
            //            double length = double.Parse(Console.ReadLine());
            //            area = 0.5 * length * height;
            //            Console.WriteLine("Area: " + area);

            //            break;

            //        default:
            //            Console.WriteLine("This choies Not Found!!");
            //            break;
            //    }
            //}



            ////4.Factorial of a Number  
            //static void Factorial()
            //{

            //    Console.WriteLine("Enter the Num:");
            //    int n = int.Parse(Console.ReadLine());
            //    int factorial = 1;

            //    int i = 1;
            //    while (i <= n)
            //    {
            //        factorial *= i;
            //        i++;
            //    }
            //    Console.WriteLine("The factorial of " + n + " is" + factorial);

            //}

            ////5.Sum of Even and Odd Numbers 
            //static void SumEvenOdd()
            //{
            //    Console.WriteLine("Enter the number value");
            //    int n = int.Parse(Console.ReadLine());

            //    int oddNum = 0;
            //    int sumEven = 0;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        if (i % 2 == 0) sumEven += i; else oddNum += i;
            //        Console.WriteLine("sum of even number:" + sumEven + "sum of odd number:" + oddNum);

            //    }
            //}



            //    //6.Scientific Calculator(Switch - Case & Math Functions)
            //    static void ScientificCalculator()
            //    {
            //        Console.WriteLine("choos an operation \n1.sin\n2.cos\n3.tan\n4.sqrt\n5.log\n6.pow");
            //        char Op = char.Parse(Console.ReadLine());


            //        double result = 0;
            //        switch (Op)
            //        {
            //            case '1':
            //                Console.WriteLine("Enter the Number:");
            //                double Nsin = double.Parse(Console.ReadLine());
            //                result = Math.Sin(Nsin);
            //                Console.WriteLine(result);
            //                break;
            //            case '2':
            //                Console.WriteLine("Enter the Number:");
            //                double Ncos = double.Parse(Console.ReadLine());
            //                result = Math.Cos(Ncos);
            //                Console.WriteLine(result);
            //                break;
            //            case '3':
            //                Console.WriteLine("Enter the Number:");
            //                double Ntan = double.Parse(Console.ReadLine());
            //                result = Math.Tan(Ntan);
            //                Console.WriteLine(result);
            //                break;
            //            case '4':
            //                Console.WriteLine("Enter the Number:");
            //                double Nsqrt = double.Parse(Console.ReadLine());
            //                result = Math.Sqrt(Nsqrt);
            //                Console.WriteLine(result);
            //                break;
            //            case '5':
            //                Console.WriteLine("Enter the Number:");
            //                double Nlog = double.Parse(Console.ReadLine());
            //                result = Math.Log(Nlog); ;
            //                Console.WriteLine(result);

            //                break;
            //            case '6':
            //                Console.WriteLine("Enter the pow:");
            //                double Npow = double.Parse(Console.ReadLine());
            //                Console.WriteLine("Enter the Number:");
            //                double Npow1 = double.Parse(Console.ReadLine());
            //                result = Math.Pow(Npow, Npow1);
            //                Console.WriteLine(result);
            //                break;
            //            default:
            //                Console.WriteLine("This choies Not Found!!");
            //                break;

            //        }
            //    }

            //    //7.Print Pattern(For Loop)
            //    static void PrintTriangle()
            //    {

            //        Console.WriteLine("Enter the number N:");
            //        int n = int.Parse(Console.ReadLine());

            //        for (int i = 1; i <= n; i++)
            //        {
            //            for (int j = 1; j <= i; j++)
            //            {
            //                Console.Write("* ");
            //            }
            //            Console.WriteLine();

            //        }
            //    }


            ////8.Print a Pyramid Pattern (For Loop)
            //static void PrintPyramid()
            //{

            //    Console.Write("Enter N: ");
            //    int n = int.Parse(Console.ReadLine());
            //    for (int i = 1; i <= n; i++)
            //        Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));

            //}

            //// 9. Print Diamond Pattern
            //static void PrintDiamond()
            //{
            //    Console.Write("Enter N: ");
            //    int n = int.Parse(Console.ReadLine());

            //    // Upper part of the diamond
            //    for (int i = 1; i <= n; i++)
            //    {
            //        PrintRow(i, n);
            //    }

            //    // Lower part of the diamond
            //    for (int i = n - 1; i >= 1; i--)
            //    {
            //        PrintRow(i, n);
            //    }



            //}

            ////  10.Guess Game
            //static void GuessGame()
            //    {
            //        Random rand = new Random();
            //        int target = rand.Next(1, 101);
            //        int gues;

            //        do
            //        {
            //            Console.WriteLine("Guess the number (1-100): ");
            //            gues = int.Parse(Console.ReadLine());
            //            if (gues > target)
            //                Console.WriteLine("Try Lower!");
            //            else if (gues < target)
            //                Console.WriteLine("Try Higher!");
            //            else
            //                Console.WriteLine("You Win!!");



            //        } while (gues != target);


            //    }

            //static void PrintRow(int i, int n)
            //{

            //    for (int j = 0; j < n - i; j++)
            //        Console.Write(" ");

            //    for (int j = 0; j < 2 * i - 1; j++)
            //        Console.Write("*");

            //    Console.WriteLine();
            //}
            //--------------------------------------------------------------------------
            //C# Part3 Exercises 
            //1. Array Initialization & Output 
            //int[] numbers = new int[5];//inaitalaz array
            ////assign value
            //numbers[0] = 2;
            //numbers[1] = 4;
            //numbers[2] = 6;
            //numbers[3] = 8;
            //numbers[4] = 10;

            ////print array element
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //--------------------------------------------------------
            //2. Find Maximum & Minimum in an Array 
            //        int[] numbers = new int[10];

            //        Console.WriteLine("Enter 10 numbers:");

            //        for (int i = 0; i < numbers.Length; i++)
            //        {
            //            Console.WriteLine($"Enter Number {i + 1}:");
            //            numbers[i] = int.Parse(Console.ReadLine());
            //        }
            //        int max = numbers[0];
            //        int min = numbers[0];
            //        for (int i = 0; i < numbers.Length; i++)
            //        {
            //            if (numbers[i] > max)
            //            {
            //                max = numbers[i];
            //            }
            //            if (numbers[i] < min)
            //            {
            //                min = numbers[i];
            //            }
            //        }
            //        Console.WriteLine("Maximum:" + max);
            //        Console.WriteLine("Minmum:" + min);
            //    }
            //}
            //------------------------------------------------------------------------------------------------
            //3. Count Even & Odd Numbers 
    //        Console.Write("Enter the number:");
    //        int n = int.Parse(Console.ReadLine());
    //        int[] numbers = new int[n];

    //        for (int i = 0; i < n; i++)
    //        {
    //            Console.WriteLine($"Enter Number {i + 1}:");
    //            numbers[i] = int.Parse(Console.ReadLine());
    //        }

    //        int oddCount = 0;
    //        int evenCount =0;

    //        for (int i = 0; i < n; i++)
    //        {
    //            if (numbers[i] % 2 == 0)
    //            {
    //                evenCount = evenCount + numbers[i];
    //            }
    //            else
    //            {
    //                oddCount = oddCount + numbers[i];
    //            }
    //        }
    //        Console.WriteLine("Even Number" + evenCount);
    //        Console.WriteLine("Odd Number:" + oddCount);
    //    }
    //}
    //-------------------------------------------------------------------------------------------
    ////4-4. Reverse an Array 
    Console.Write("Enter the number:");
            int n = int.Parse(Console.ReadLine());
    int[] numbers = new int[n];
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine($"Enter Number {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
}
Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }



}
}


    }
        












