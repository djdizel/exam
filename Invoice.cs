using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void SetOrder(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }

        public (double withVAT, double withoutVAT) CalculateCost(double pricePerUnit)
        {
            double withoutVAT = pricePerUnit * quantity;
            double withVAT = withoutVAT * 1.20; // НДС 20%
            return (withVAT, withoutVAT);
        }
    }
}
