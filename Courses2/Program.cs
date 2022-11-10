using Courses2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Courses2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingAcount(1001, "Alex", 500.0, 0.01));
            list.Add(new BussinesAcount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAcount(1003, "Bob", 500.0, 0.01));
            list.Add(new BussinesAcount(1004, "Ana", 500.0, 500.0));

            Double sum = 0.0;
            foreach (Account acc in list)
            {
                sum = acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }


    }

}

