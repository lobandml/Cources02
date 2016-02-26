using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string Article { get; set; }
        private int Quantity { get; set; }
        private double Price { get; set; }

        public int Account
        {
            get
            {
                return account;
            }
        }
        public string Customer
        {
            get
            {
                return customer;
            }
        }
        public string Provider
        {
            get
            {
                return provider;
            }
        }

        public Invoice(int account, string customer, string provider, string article, int quantity, double price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

            this.Article = article;
            this.Quantity = quantity;
            this.Price = price;
        }
        public double OfferPrice(bool additionalcost)
        {
            double coef = additionalcost ? 1.2 : 1.0;
            return this.Quantity *Price* coef;
        }
    }
}
