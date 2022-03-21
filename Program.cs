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
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the UPC discount percentage:");
            double y = Convert.ToDouble(Console.ReadLine());
            if (newProduct.UPC == x)
            {
                newProduct.UPCDiscount = y;
            }

            Console.WriteLine($"Product new price is {newProduct.NewPrice}$");
            Console.WriteLine($"The amount of discount is {newProduct.DiscountAmount+newProduct.UPCDiscountAmount}$");
            
        }
    }
}
