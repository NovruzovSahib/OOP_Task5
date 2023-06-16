using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    public class Phones
    {
        string productModel;
        string productCountry;
        short productCost;
        short productYear;
        bool isNew;

        public string ProductModel { get; set; }
        public string ProductCountry { get; set; }
        public double ProductCost { get; set; }
        public short ProductYear { get; set; }
        public bool IsNew { get; set; }

        public Phones()
        {
            this.ProductModel = productModel;
            this.ProductCountry = productCountry;
            this.ProductCost = productCost;
            this.ProductYear = productYear;
            this.IsNew = isNew;
        }
        public virtual void GetElectronics()
        {
            Console.WriteLine($"Product Model - {ProductModel}\nProduct Country - {ProductCountry}\nProduct Cost - {ProductCost}\nProduct Year - {ProductYear}\nİs New - {IsNew}");
        }

    }
}
