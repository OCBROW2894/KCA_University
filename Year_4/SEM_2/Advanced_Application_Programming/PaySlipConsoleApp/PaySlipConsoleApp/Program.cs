using System;
/***
 * Question(Problem) - Company XYZ LTD, A fast moving good selling Company Pays it's Employees on a retainer Salary of Ksh. 15,000
                    Plus the Commision of 20% of Sales. The Employees are subjected to a 30% tax on Gross Pay
                    
                    Additional Information
                    Gross Pay = Retainer salary Plus Commision
                    Net Pay= Gross Pay Minus Tax

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
            /*
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
            /*

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
            /*
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

            */
            /*
                        int num;

                        Console.Write("Enter an integer number: ");
                        num = int.Parse(Console.ReadLine());

                        /*
                        if (num == 1)
                        {
                            Console.Write("One");} else if (num == 2){Console.Write("Two");}
                        else if (num == 3){Console.Write("Three");} 
                        else{ Console.Write("Invalid");}  */

            /*
            switch (num)
            {
                case 1: Console.Write("One");break;
                case 2:Console.Write("Two");break;
                case 3:Console.Write("Three");break;
                default:Console.Write("Invalid"); break;
            } */
            
            Console.WriteLine("Welcome to the Sales Commission Calculator!");

            // Input the sales amount
            Console.Write("Enter the sales amount: $");
            double salesAmount = double.Parse(Console.ReadLine());

            // Calculate commission based on sales amount
            double commissionRate;
            /*
            if (salesAmount <= 1000)
            {
                commissionRate = 0.05; // 5% commission for sales up to $1000
            }
            else if (salesAmount <= 5000)
            {
                commissionRate = 0.1; // 10% commission for sales between $1001 and $5000
            }
            else
            {
                commissionRate = 0.15; // 15% commission for sales above $5000
            }
            */
            
            switch (salesAmount)
            {
                case double amount when amount <= 1000:
                    commissionRate = 0.05; // 5% commission for sales up to $1000
                    break;
                case double amount when amount <= 5000:
                    commissionRate = 0.1; // 10% commission for sales between $1001 and $5000
                    break;
                default:
                    commissionRate = 0.15; // 15% commission for sales above $5000
                    break;
            }
            
            // Calculate commission amount
            double commission = salesAmount * commissionRate;

            // Display the commission
            Console.WriteLine($"Sales Amount: ${salesAmount}");
            Console.WriteLine($"Commission Rate: {commissionRate:P}");
            Console.WriteLine($"Commission Earned: ${commission}");
            /*
            Console.WriteLine("Commission calculation completed. Thank you!");
            */
            /*
            for(int I=0; I<=10; I++)
            {
                Console.WriteLine("Advanced Application Programming");
            } */
            /*
            for (int I = 1; I <= 10; I=I+1)
            {
                Console.Write(I + "\n");
            } */
            /*
            int sum = 0;
            for (int I = 1; I <= 10; I = I + 2)
            {
                sum = sum + I;
               
            }
            Console.Write("The Sum: " + sum);
            */ /*
            for(int I=20; I >=1; I--)
            {
                Console.Write(I + " ");
            }
            */
            /*
            int sum = 0;
            for (int I = 200; I >= 5; I--)
            { if (I % 5 == 0)
                {
                    Console.Write(I + " ");
                    sum = sum + I;
                }
            } Console.WriteLine("The Sum is: " + sum); */

        }
    }
}

    

