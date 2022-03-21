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

            Console.WriteLine("Please Enter the discount percentage:");
            newProduct.Discount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Product new price is {newProduct.NewPrice}$");
            if (newProduct.Discount != 0)
            {
                Console.WriteLine($"The amount of discount is {newProduct.DiscountAmount}$");
            }

            //Console.WriteLine($"Product price reported as {newProduct.Price} before tax and discount and {newProduct.NewPrice} after {newProduct.Tax}% tax and {newProduct.Discount}% discount");
        }
    }
}
