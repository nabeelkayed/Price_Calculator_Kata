using System;

namespace Price_Calculator_Kata
{
    public class Product
    {
        public string Name { set; get; }
        public int UPC { set; get; }
        public double Price { set; get; }
        public double Tax { set; get; }
        public double UPCDiscount { get; set; }
        public double Discount { get; set; }


        public double TaxAmount
        {
            get
            {
                return Math.Round(Price * Tax / 100, 2);
            }
        }
        public double NewPrice
        {
            get
            {
                return Math.Round(Price + TaxAmount - DiscountAmount - UPCDiscountAmount, 2);
            }
        }
        public double DiscountAmount
        {
            get
            {
                return Math.Round(Price * Discount / 100, 2);
            }
        }

        public double UPCDiscountAmount
        {
            get
            {
                return Math.Round(Price * UPCDiscount / 100, 2);
            }
        }

        public Product(string Name, int UPC, double Price)
        {
            this.Name = Name;
            this.UPC = UPC;
            this.Price = Price;
            Tax = 20;
            Discount = 0;
            UPCDiscount = 0;
        }
    }
}
