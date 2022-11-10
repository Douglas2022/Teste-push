using Courses2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses2
{
    class SavingAcount : Account
    {
        public double InterestRaste { get; set; }
        public SavingAcount()
        {
        }

        public SavingAcount(int number, string holder, double balance, double interestRaste) : base(number,holder,balance)
        {
            InterestRaste = interestRaste;
        }
        public void UpDateBalance()
        {
            Balance += Balance * InterestRaste;
        }
        public override void withdraw(double amount)
        {
            base.withdraw(amount);
            Balance -= 2.0;
        }
    }
}
