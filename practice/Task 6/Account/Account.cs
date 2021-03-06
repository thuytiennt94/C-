// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank1
{
    class Account
    {
        static void Main(string[] args)
        {
            int[] customerID = new int[3];
            int[] accountNumber = new int[3];

            //array of string to store account type 
            string[] accountType = new string[3];

            //array of datetime to store the date on which the account is opened
            DateTime[] dateOpened = new DateTime[3];

            //array of double to store deposit and balance
            double[] deposit = new double[3];
            double[] balance = new double[3];

            //integer variable to store the account number entered
            int choice = 0;

            int i = 0;
            bool found = false;

        //accepting the details of account using goto and return statements
        accept:
            {
                Console.Write("Enter the id of customer: ");
                customerID[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account:");
                accountNumber[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account type [Fixed/Savings]: {F/S} ");
                accountType[i] = Console.ReadLine();
                Console.Write("Enter the date of opening account [MM/DD/YYYY]: ");
                dateOpened[i] = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the account deposited : ");
                deposit[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                if (deposit[i] <= 0)
                {
                    Console.WriteLine("invalid date entry ");
                    return;
                }
                else
                {
                    //calculating the balance
                    balance[i] = balance[i] + deposit[i];
                }
                i++;
            }
            if (i < customerID.Length)
            {
                goto accept;
            }

            //displaying the accoung details
            Console.WriteLine("Enter the id of customer: ");
            Console.WriteLine("ID\tA/c no.\tA/c type opening date\tDeposit($)   Balance($)");
            for (i = 0; i < customerID.Length; i++)
            {
                Console.WriteLine("{0}\t{1} \t", customerID[i], accountNumber[i]);
                Console.WriteLine("{0}\t  {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                Console.WriteLine("{0}\t    {1} ", deposit[i], balance[i]);
            }

            //displaying the details of all except those that were ceated today
            Console.WriteLine("\n\nAccount Details: \n");
            Console.WriteLine("ID\tA/c No.\tA/c type opening Date \tDeposit($)      Balance($)");
            DateTime today = DateTime.Today.Date;
            for (i = 0; i < customerID.Length; i++)
            {
                //calculate the difference between dates
                int num = (today.Subtract(dateOpened[i])).Days;
                if (num == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write("{0}\t{1} \t", customerID[i], accountNumber[i]);
                    Console.Write("{0}\t    {1} \t", accountType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t    {1} ", dateOpened[i], balance[i]);
                }
            }
            //accepting an account number to view details
            Console.Write("\nEnter the account number whose details you want to view: ");
            choice = Convert.ToInt32(Console.ReadLine());

            //displaying the account details according to the choice entered using break statement
            for (i = 0; i < accountNumber.Length; i++)
            {
                if (accountNumber[i] == choice)
                {
                    found = true;

                    Console.WriteLine("Record Found!");
                    Console.WriteLine("ID\tA/c No.\tA/c Type opening date\tDeposit($)   Balance($)");
                    Console.WriteLine("{0}\t{1}\t", customerID[i], accountNumber[i]);
                    Console.WriteLine("{0}\t    {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t    {1}", deposit[i], balance[i]);
                    break;
                }
            }
            if (!found)
                Console.WriteLine("account does not exist.");
        }
    }
}