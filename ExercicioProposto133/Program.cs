using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioProposto133.Entities;

namespace ExercicioProposto133
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prds = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtdPrds = int.Parse(Console.ReadLine());


            for (int i = 1; i <= qtdPrds; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char TpPrd = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Price: ");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (TpPrd)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        double CustomsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        prds.Add(new ImportedProduct(Name, Price, CustomsFee));
                        break;
                    case 'c':
                        prds.Add(new Product(Name, Price));
                        break;
                    case 'u':
                        Console.Write("Manutacture date (DD/MM/YYYY): ");
                        DateTime DateManufacture = DateTime.Parse(Console.ReadLine());
                        prds.Add(new UsedProduct(Name, Price, DateManufacture));
                        break;
                    default:
                        Console.WriteLine("Tipo do produto invalido!");
                        break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in prds)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
