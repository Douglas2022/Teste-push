using Courses2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses2
{
    class BussinesAcount : Account
    {
        public double LoanLimit { get; set; }
        public BussinesAcount()
        {
        }

        public BussinesAcount(int number, string holder, double balance, double loanLimit) : base(number,holder,balance)
        {
            LoanLimit = loanLimit;
        }
        public void Loan(Double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += LoanLimit;
            }
        }
    }
}
