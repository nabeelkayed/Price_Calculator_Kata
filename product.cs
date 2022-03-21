using System;

namespace Price_Calculator_Kata
{
    public class Product
    {
        public string Name { set; get; }
        public int UPC { set; get; }
        public double Price { set; get; }
        public double Tax { set; get; }
        public double Discount { get; set; }
        public double UPCDiscount { get; set; }

        public void SetUPCDiscount(int UPC, double UPCDiscount)
        {
            if (this.UPC == UPC)
            {
                this.UPCDiscount = UPCDiscount;
            }
        }
        private double CalculateDiscountAmount(double price)
        {
            return Math.Round(price * Discount / 100, 2);
        }
        private double CalculateUPCDiscountAmount(double price)
        {
            return Math.Round(price * UPCDiscount / 100, 2);
        }
        private double CalculateTaxAmount(double price)
        {
            return Math.Round(price * Tax / 100, 2);
        }
        public double CalculateNewPrice()
        {
            double price = Price - CalculateUPCDiscountAmount(Price);
            return Math.Round(price + CalculateTaxAmount(price) - CalculateDiscountAmount(price), 2);
        }
        public double CalculateTotalDiscount()
        {
            double UPCDiscountAmount = CalculateUPCDiscountAmount(Price);
            double price = Price - UPCDiscountAmount;
            return Math.Round(UPCDiscountAmount + CalculateDiscountAmount(price), 2);
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
