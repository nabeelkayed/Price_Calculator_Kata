using System;

namespace Price_Calculator_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Product newProduct = new Product("The Little Prince", 12345, 20.25);

            Console.WriteLine("Please Enter the tax percentage:");
            newProduct.Tax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the universal discount percentage:");
            newProduct.Discount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the UPC thar you want to make discount for:");
            int UPC = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the UPC discount percentage:");
            double UPCdiscount = Convert.ToDouble(Console.ReadLine());

            newProduct.SetUPCDiscount(UPC, UPCdiscount);

            Console.WriteLine("Please Enter the packaging cost:");
            newProduct.PackagingCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the transport cost:");
            newProduct.TransportCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Cost = {newProduct.Price}$");
            Console.WriteLine($"Tax = {newProduct.CalculateTaxAmount(newProduct.Price)}$");
            Console.WriteLine($"Discounts = {newProduct.CalculateTotalDiscount()}$");
            Console.WriteLine($"Packaging = {newProduct.CalculatePackagingCost()}$");
            Console.WriteLine($"Transport = {newProduct.TransportCost}$");
            Console.WriteLine($"TOTAL = {newProduct.CalculateNewPrice()}$");

        }
    }
}
