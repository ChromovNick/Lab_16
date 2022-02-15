using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Lab_16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader read = new StreamReader("C:/Users/Никита/Desktop/test/Products.json"))
            {
                jsonString = read.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product expensive = products[0];
            foreach (Product p in products)
            {
                if (p.Price>expensive.Price)
                {
                    expensive = p;
                }
            }
            Console.WriteLine("Cамый дорогой товар:");
            Console.WriteLine("Код    Наименование    Цена,руб.");
            Console.WriteLine($"{expensive.Code}        {expensive.Name}         {expensive.Price}");
            Console.ReadKey();
        }
    }
}
