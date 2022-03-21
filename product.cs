using System;

namespace Price_Calculator_Kata
{
    public class Product
    {
        public string Name { set; get; }
        public int UPC { set; get; }
        public double Price { set; get; }
        public double Tax { set; get; }
        public double PriceAfterTax { set; get; }

        public Product(string Name, int UPC, double Price)
        {
            this.Name = Name;
            this.UPC = UPC;
            this.Price = Price;
            Tax = 20;
            PriceAfterTax = Math.Round(Price + (Price * Tax / 100), 2);

        }

        public void UpdatePriceAfterNewTax()
        {
            PriceAfterTax = Math.Round(Price + (Price * Tax / 100), 2);
        }
    }
}
