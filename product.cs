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
        public double PackagingCost { get; set; }
        public double TransportCost { get; set; }

        public void SetUPCDiscount(int UPC, double UPCDiscount)
        {
            if (this.UPC == UPC)
            {
                this.UPCDiscount = UPCDiscount;
            }
        }
        public double CalculateDiscountAmount(double price)
        {
            return Math.Round(price * Discount / 100, 2);
        }
        public double CalculateUPCDiscountAmount(double price)
        {
            return Math.Round(price * UPCDiscount / 100, 2);
        }
        public double CalculateTaxAmount(double price)
        {
            return Math.Round(price * Tax / 100, 2);
        }
        public double CalculateNewPrice()
        {
            return Math.Round(Price +TransportCost + CalculatePackagingCost() - CalculateUPCDiscountAmount(Price) + CalculateTaxAmount(Price) - CalculateDiscountAmount(Price), 2);
            
        }
        public double CalculateTotalDiscount()
        {
          
            return Math.Round(CalculateUPCDiscountAmount(Price) + CalculateDiscountAmount(Price), 2);
        }

        public double CalculatePackagingCost()
        {
            return Math.Round(Price * PackagingCost / 100, 2);
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
