using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Project.Lab_2
{
    internal class Iintrest_Iheritance
    {
        public static void Main(string[] args)
        {
            Intrest obj = new Intrest();
            obj.GetAccountDetails();
            obj.IntrestDetails();
            obj.DisplayIntrest();
        }
    }

    public class Account_Details
    {
        public string HolderName;
        public int AccountNumber;
        public double Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Holder Name : ");
            HolderName = Console.ReadLine();

            Console.WriteLine("Enter Account Number : ");
            AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Balance : ");
            Balance = Convert.ToDouble(Console.ReadLine());


        }
          
    }

    public class Intrest : Account_Details 
    {
        public double Rate;
        public int Time;
        public double TotalInterest;

        public void IntrestDetails()
        {
            Console.WriteLine("Enter Bank Rate : ");
            Rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time (in years): ");
            Time= Convert.ToInt32(Console.ReadLine());

            TotalInterest = (Balance * Rate * Time) / 100;

        }


        public void DisplayIntrest()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Account Holder : " + HolderName);
            Console.WriteLine("Balance : " + Balance);
            Console.WriteLine("Total Intrest : " + TotalInterest);
        }

    }
    
}
