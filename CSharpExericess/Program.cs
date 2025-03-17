using System.Diagnostics;
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

            // secound Exericess
            /*
             * 1
            Console.WriteLine("Enter the operation number :\n1. Addition\n2. Subtraction ");
            Console.WriteLine("3. Multiplication\n4. Division");
            int OperationNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter First Number:\n");
            double FirstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number:\n");
            double SecondNumber = double.Parse(Console.ReadLine());
            double result = 0;
            bool isactive = false;
            switch (OperationNumber)
            {
                case 1:
                    result = FirstNumber + SecondNumber;
                    break;


                    case 2:
                    result = FirstNumber - SecondNumber;
                    break;


                    case 3:
                        result = FirstNumber * SecondNumber;
                        break;



                    case 4:
                    if (SecondNumber == 0)
                    {
                        Console.WriteLine("Division by zero not allowed");
                        isactive = true;
                    }
                    else
                    {
                        result = FirstNumber / SecondNumber;
                    }
                            break;

                        default:
                            Console.WriteLine("This choies Not Found!!");
                            isactive = true;
                    break;
                        }
                    if (!isactive) {
                Console.WriteLine(result);
                     }*/
            //------------------------------------------------------------------------------------------------------------------------------------------------------
            //3. Geometry Calculator 

            //Console.WriteLine("choos one shapes: \n");

            //Console.WriteLine("1. Circle (Calculate Area & Circumference),2. Square (Calculate Area & Perimeter),3. Triangle (Calculate Area) \n ");
            //char shape = char.Parse(Console.ReadLine());

            //switch (shape)
            //{
            //    case '1':
            //        Console.WriteLine("Enter the redius: \n");
            //        double redius = double.Parse(Console.ReadLine());
            //        double area = Math.PI * redius * redius;
            //        double  Circumference = 2 * Math.PI * redius;
            //        Console.WriteLine("Area: "+area+"\nCircumference "+ Circumference);

            //        break;
            //    case '2':
            //        Console.WriteLine("Enter the side: \n");
            //        double side = double.Parse(Console.ReadLine());
            //         area = side * side;
            //        double Perimeter = 4 * side;
            //        Console.WriteLine("Area: "+area +"\nPerimeter: " +Perimeter);
            //        break;

            //    case '3':
            //        Console.WriteLine("Enter height:\n");
            //        double height = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter height:\n");
            //        double  length = double.Parse(Console.ReadLine());
            //        area = 0.5 * length * height;
            //        Console.WriteLine("Area: " +area);

            //        break;

            //    default:
            //        Console.WriteLine("This choies Not Found!!");
            //        break;
            //---------------------------------------------------------------------------

            //4. Factorial of a Number  

            //Console.WriteLine("Enter the Num:");
            //int n = int.Parse(Console.ReadLine());
            //int factorial=1 ;

            //int i = 1;
            //while (i <= n)
            //{
            //    factorial *= i;
            //    i++;
            //}
            //Console.WriteLine("The factorial of " + n +" is" + factorial);

            //--------------------------------------------------------------------

            //2. Basic ATM System 

            //        do
            //        {

            //            Console.WriteLine("Select serves");
            //            Console.WriteLine("1. Withdraw Money.\n2. Deposit Money.\n3. Check Balance.\n4.Exit.");
            //            char choice = char.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter the amount:");
            //            int amount = int.Parse(Console.ReadLine());
            //            int balance = 1000;
            //            double result = 0;
            //            bool isActive = false;
            //            string choies = Console.ReadLine();
            //            bool exit = false;

            //            switch (choice)
            //            {
            //                case '1':
            //                    Console.WriteLine("Enter Amount to withdraw");
            //                    int WithdrawAmount = int.Parse(Console.ReadLine());
            //                    if (WithdrawAmount <= balance)
            //                    {
            //                        balance -= WithdrawAmount;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Invalid, Plese enter correct balenc");
            //                    }
            //                    break;
            //                case '2':
            //                    Console.WriteLine("Enter the amount to deposit: ");
            //                    int Deposit = int.Parse(Console.ReadLine());
            //                    balance += Deposit;
            //                    Console.WriteLine("Succeful depost" + Deposit);

            //                    break;

            //                case '3':
            //                    Console.WriteLine("your current balance is :" + balance);
            //                    break;
            //                case '4':
            //                    Console.WriteLine("Thank You, See you soon");
            //                    break;
            //                default:
            //                    Console.WriteLine("Invaild choies,plesce select the correct choies");
            //                    isActive = true;
            //                    break;
            //            }

            //        }
            //}



            //---------------------------------------------------------------------------------------
            //6. Scientific Calculator (Switch-Case & Math Functions) 
            //Console.WriteLine("choos an operation \n1.sin\n2.cos\n3.tan\n4.sqrt\n5.log\n6.pow");
            //char Op = char.Parse(Console.ReadLine());


            //double result = 0;
            //switch (Op)
            //{
            //    case '1':
            //        Console.WriteLine("Enter the Number:");
            //        double Nsin = double.Parse(Console.ReadLine());
            //        result = Math.Sin(Nsin);
            //        Console.WriteLine(result);
            //        break;
            //    case '2':
            //        Console.WriteLine("Enter the Number:");
            //        double Ncos= double.Parse(Console.ReadLine());
            //        result = Math.Cos(Ncos);
            //        Console.WriteLine(result);
            //        break;
            //    case '3':
            //        Console.WriteLine("Enter the Number:");
            //        double Ntan = double.Parse(Console.ReadLine());
            //        result = Math.Tan(Ntan);
            //        Console.WriteLine(result);
            //        break;
            //    case '4':
            //        Console.WriteLine("Enter the Number:");
            //        double Nsqrt = double.Parse(Console.ReadLine());
            //        result = Math.Sqrt(Nsqrt);
            //        Console.WriteLine(result);
            //        break;
            //    case '5':
            //        Console.WriteLine("Enter the Number:");
            //        double Nlog = double.Parse(Console.ReadLine());
            //        result = Math.Log(Nlog); ;
            //        Console.WriteLine(result);

            //        break;
            //    case '6':
            //        Console.WriteLine("Enter the pow:");
            //        double Npow = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter the Number:");
            //        double Npow1= double.Parse(Console.ReadLine());
            //        result = Math.Pow(Npow, Npow1);
            //        Console.WriteLine(result);
            //        break;
            //    default:
            //           Console.WriteLine("This choies Not Found!!");
            //              break;

            //}
            //--------------------------------------------------------------------------------------------------------------------------------------------

            //7 . Print Pattern (For Loop) 

            //Console.WriteLine("Enter the number N:");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        console.write("* ");
            //    }
            //    Console.WriteLine(x);
            //    
            //}
            //--------------------------------------------------------------------------------------------------------------


            ////Print a Pyramid Pattern (For Loop)

            //Console.WriteLine("enter number of rows : ");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j >= 1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i * 2 - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            //--------------------------------------------------------------------------------------------------------------
            //9. Print a Diamond Pattern (For Loop)
            //Console.WriteLine("enter row number");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j >= 1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i * 2 - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            //for (int i = n-1;i>=1;i--)
            //{
            //    for (int j =0; j <n-1;j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j <= 2*i-1;j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            //----------------------------------------------------------------------------
            //. Sum of Even and Odd Numbers 
            //Console.WriteLine("Enter the number value");
            //int n = int.Parse(Console.ReadLine());

            //int oddNum = 0;
            //int sumEven = 0;
            //for(int i=1;i<=n;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sumEven += i;
            //    }else
            //    {
            //        oddNum += i;
            //        Console.WriteLine("sum of even number:" + sumEven + "sum of odd number:" + oddNum);
            //    }
            //}
            //--------------------------------------------------------------------------------------------------------

                


        }
    }


    }

                
        
