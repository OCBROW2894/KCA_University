using System;
/***
           * eName- Employee Name
           * rSalary- Retainer Salary
           * gPay- Gross Pay
           * nPay- Net Pay
*/

namespace PaySlipConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /***  String eName;
             double rSalary, Commision, gPay, nPay, sales, tax;

             Console.Write("Please Enter Employees Name: ");
               eName = Console.ReadLine();

             Console.Write("Enter Sales : ");
               sales = Convert.ToDouble(Console.ReadLine());

           Console.Write("Enter0")


               rSalary = 15000;
               Commision = 0.2 * sales;
               gPay = rSalary + Commision;
               tax = 0.3 * gPay;
               nPay = gPay - tax;

               Console.WriteLine("---------XYZ-PAYSLIP----------------");
               Console.WriteLine("|   NAME:             " + eName );
               Console.WriteLine("|   RETAINER SALARY:  " + rSalary );
               Console.WriteLine("|   GROSS PAY:        " + gPay );
               Console.WriteLine("|   TAX:              " + tax );
               Console.WriteLine("|   NET PAY:          " + nPay );
             */


            /***  int mean;
              Console.WriteLine("Enter average marks: ");
              // double eMarks = Convert.ToDouble(Console.ReadLine());
              mean = int.Parse(Console.ReadLine());
              Console.WriteLine("Student average mark is: " + mean);
              Console.ReadKey(); */

            int sum;
            int avg;
            int subj1 = -10002;
            int subj2 = 46;
            int subj3 = 53;
            int subj4 = 65;
            int subj5 = 82;


            // double eMarks = Convert.ToDouble(Console.ReadLine());
            sum = subj1 + subj2 + subj3 + subj4 + subj5;
            Console.WriteLine("Sum is: " + sum);

            avg = sum / 5;
            Console.WriteLine("Average is: " + avg);

            /*** if (avg < 100 && avg > 0)
            {
                if (avg >= 70)
                {
                    Console.WriteLine("Grade is A");
                }
                else if (avg >= 60)
                {
                    Console.WriteLine("Grade is B");
                }
                else if (avg >= 50)
                {
                    Console.WriteLine(" Grade is C");
                }
                else if (avg >= 40)
                {
                    Console.WriteLine("Grade is D");
                }
                else
                {
                    Console.WriteLine("Grade is F");
                }
            } 
            else 
            {
                Console.WriteLine("Invalid");
            }
            */


            string Grade;

            if (avg < 100 && avg > 0)
            {
                if (avg >= 70)
                {
                    Grade = "A";
                }
                else if (avg >= 60)
                {
                    Grade = "B";
                }
                else if (avg >= 50)
                {
                    Grade = "C";
                }
                else if (avg >= 40)
                {
                    Grade = "D";
                }
                else
                {
                    Grade = "F";
                }

                Console.WriteLine("Grade is " + Grade);

            }
            else
            {
                Console.WriteLine("Invalid");
            }

       






            /***
            int i, n, sum = 0;
            double avg;

            Console.Write("\n")
            Console.Write("Read 10 numbers and calculate sum and average:
            */

            /***  if (avg >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("fail");
            }

            double Sales = 350000;
            double Comm;
            if (Sales >= 500000)
            {
                Comm = Sales * 0.2;
            }
            else
            {
                Comm = Sales * 0.1;
            }

            Console.WriteLine("The commision is:" + Comm);

            */

            /***
            A = 70 - 100
            B = 60 - 69
            C =  50 - 59
            D = 40 - 49 
            E = below 40
            */

            double Sales = 1000000;
            double Comm;
            if (Sales >= 1000000)
            {
                Comm = Sales * 0.25; 
            }
            else if (Sales >= 500000)
            {
                Comm = Sales * 0.2;
            }
            else if (Sales >= 250000)
            {
                Comm = Sales * 0.1;
            }
            else if (Sales >= 100000)
            {
                Comm = Sales * 0.05;
            }
            else 
            {
                Comm = 0;
            }

            Console.WriteLine("The commision is:" + Comm);
        }
    }
}
