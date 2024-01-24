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
          String eName;
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
          

      }
  }
}
