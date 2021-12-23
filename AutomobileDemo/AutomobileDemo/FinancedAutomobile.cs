using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    class FinancedAutomobile : Automobile
    {
        const int PERIOD_OF_PAYMENT = 24;

        public double AmountFinanced { get; set; }
        public double InterestRate { get; set; }

        public override string ToString()
        {
            string temp = base.ToString();
            temp += "/nAmount financed " + AmountFinanced.ToString("C");
            temp += "/nInterest Rate " + InterestRate.ToString();
            return temp;
        }

        public double GetPaymentAmount()
        {
            return AmountFinanced / PERIOD_OF_PAYMENT;
        }

    }
}
