using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_Project.Lab_2
{
    internal class Bank_Account
    {
        int Account_No;
        string Email;
        string User_Name;
        string Account_Type;
        double Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Number  : ");
            Account_No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();

            Console.WriteLine("Enter User Name : ");
            User_Name = Console.ReadLine();

            Console.WriteLine("Enter Account Type  : ");
            Account_Type = Console.ReadLine();

            Console.WriteLine("Enter Account Balance : ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Details of Bank Member is : ");
            Console.WriteLine(Account_No);
            Console.WriteLine(Email);
            Console.WriteLine(User_Name);
            Console.WriteLine(Account_Type);
            Console.WriteLine(Account_Balance);

        }

    }
}
