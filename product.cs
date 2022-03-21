using System;

namespace Price_Calculator_Kata
{
    public class Product
    {
        public string Name { set; get; }
        public int UPC { set; get; }
        public double Price { set; get; }
        public double Tax { set; get; }
        public double TaxAmount
        {
            set
            {
            }
            get
            {
                return Math.Round(Price * Tax / 100, 2);
            }
        }
        public double NewPrice
        {
            get
            {
                return Math.Round(Price + TaxAmount - DiscountAmount, 2);
            }
        }
        public double Discount { get; set; }
        public double DiscountAmount
        {
            set
            {
            }
            get
            {
                return Math.Round(Price * Discount / 100, 2);
            }
        }

        public Product(string Name, int UPC, double Price)
        {
            this.Name = Name;
            this.UPC = UPC;
            this.Price = Price;
            Tax = 20;
            Discount = 0;
        }
    }
}
