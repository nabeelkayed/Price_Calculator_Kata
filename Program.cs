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
            newProduct.UpdatePriceAfterNewTax();

            Console.WriteLine($"Product price reported as {newProduct.Price} before tax and {newProduct.PriceAfterTax} after {newProduct.Tax}% tax");
        }
    }
}
