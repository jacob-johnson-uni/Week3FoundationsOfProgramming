using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;

namespace Week3Workshop
{
    class program
    {
        static void Main()
        {
            Console.Write("Please enter a task to run from the Workshop: ");
            string task = Console.ReadLine();
            if (task == "1")
            {
                task1();
            }
            else if (task == "2")
            {
                task2();
            }
            else if (task == "3")
            {
                task3();
            }
            else if (task == "4")
            {
                task4();
            }
            else if (task == "5")
            {
                task5();
            }
            else if (task == "6")
            {
                task6();
            }
            else if (task == "7")
            {
                task7();
            }
            //else if (task == "8")
            //{
            //    task8();
            //}
            //else if (task == "9")
            //{
            //    task9();
            //}
        }

        static void task1()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            int average1 = a + b;   //used this average1 to split the average calculation up
            int average = average1 / 2; //and wrote these outside of the statement to demonstrate the equations instead of overcomplicating them in writelines. Done for readability.

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
            Console.WriteLine($"Average: {average}");
        }

        static void task2()
        {
            Console.Write("Item Price (£): ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("VAT rate (%): ");
            decimal VAT = Convert.ToDecimal(Console.ReadLine());

            decimal VATAmount = price * VAT / 100m; //how the VAT is worked out
            decimal finalPrice = price + VATAmount;

            Console.WriteLine($"VAT Amount: {VATAmount:C}");
            Console.WriteLine($"Final Price: {finalPrice:C}");
        }

        static void task3()
        {
            bool underage = true;
            bool premiumMember = false;
            bool standardAccess = false; //starts as all being false and is updated throughout the program

            Console.WriteLine("=== Gym Membership Eligibility Test ===");
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter membership years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && age <= 65) // used loops to check each piece of data
            {
                standardAccess = true;
            }

            if (age >= 66 || years >= 5)
            {
                premiumMember = true;
            }

            if (age < 18)
            {
                underage = false;
                //standardAccess = false; // can be added in order to show they shouldn't have access even if they have a long winded membership before
                //premiumMember = false;
            }

            Console.WriteLine($"Standard access (18 - 65): {standardAccess}");
            Console.WriteLine($"Premium access (senior OR loyal): {premiumMember}");
            Console.WriteLine($"Not underage: {underage}");
        }

        static void task4()
        {
            Console.WriteLine("=== Payroll Calculator ===");
            
            Console.Write("Enter base salary (£): ");
            decimal baseSalary = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Enter bonus rate (%): ");
            decimal bonusRate = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Enter tax deduction (£): ");
            decimal tax = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Enter pension contribution (£): ");
            decimal pension = Convert.ToDecimal(Console.ReadLine());

            decimal bonus = baseSalary * bonusRate / 100m; //m for decimal
            decimal grossSalary = baseSalary + bonus;
            decimal netSalary = grossSalary - tax - pension;

            Console.WriteLine($"Base Salary: {baseSalary:C}");
            Console.WriteLine($"Bonus ({bonusRate}): {bonus:C}");
            Console.WriteLine($"Gross Salary: {grossSalary:C}");
            Console.WriteLine($"Tax + Pension: {tax + pension:C}");
            Console.WriteLine($"Net Salary: {netSalary:C}"); //:C adds the currency to the output
        }

        static void task5()
        {
            bool distinction = false;
            bool pass = false;
            bool fail = false;

            Console.WriteLine("=== Student Performance Evaluator ===");
            Console.Write("Enter mark 1: ");
            int mark1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter mark 2: ");
            int mark2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter mark 3: ");                            //more boolean practice
            int mark3 = Convert.ToInt32(Console.ReadLine());

            decimal average = (mark1 + mark2 + mark3) / 3.0m;

            
            if (average >= 40 || average > 70)
            {
                pass = true;
            }
            if (average < 40)
            {
                fail = true;
            }
            if (average >= 70)
            {
                distinction = true;
                pass = false;
            }

            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Distinction: {distinction}");
            Console.WriteLine($"Pass: {pass}");
            Console.WriteLine($"Fail: {fail}");

        }

        static void task6()
        {
            Console.WriteLine("=== Cinema Kiosk ===");
            Console.Write("Ticket price (£): ");
            double ticketPrice = double.Parse(Console.ReadLine()!);
            Console.Write("Number of tickets: ");
            int ticketCount = int.Parse(Console.ReadLine()!);
            Console.Write("Snack price (£): ");
            double snackPrice = double.Parse(Console.ReadLine()!);
            Console.Write("Number of snacks: ");
            int snackCount = int.Parse(Console.ReadLine()!);
            Console.Write("Voucher tokens: ");
            int tokens = int.Parse(Console.ReadLine()!);
  
            double ticketSubtotal = ticketPrice * ticketCount;
            double snackSubtotal = snackPrice * (snackCount - tokens);
            Console.WriteLine($"Ticket and snack subtotal: {ticketSubtotal + snackSubtotal:C}");
            
            int freeSnacks = tokens % 3;
            tokens = tokens / 3;
            
            double vatRate = 0.2;
            double vat = (ticketSubtotal + snackSubtotal) * vatRate;                                //fix the program
            decimal totalDue = (decimal)(ticketSubtotal + snackSubtotal) + (decimal)vat;
            int leftoverTokens = tokens - snackCount;
            if (leftoverTokens < 0)
            {
                leftoverTokens = 0;
            }
            
            
            Console.WriteLine("\n--- Bill ---");
            Console.WriteLine($"Free snacks from tokens: {freeSnacks} leftover:  {leftoverTokens}");
            Console.WriteLine("VAT (20%): £" + vat);
            Console.WriteLine("TOTAL: £" + totalDue);
        }

        static void task7()
        {
            Console.WriteLine(10 / 7); //1
            Console.WriteLine(10 / 4.0); //2.0
            Console.WriteLine("Total: " + 10 + 4); //104
            Console.WriteLine("Total: " + (10 + 4)); //14
            Console.WriteLine(3 + 4 * 2); //11
            Console.WriteLine((3 + 4) * 2); //14
            Console.WriteLine(18 % 5 == 3 && 7 > 2); //True
        }
    }
    
}