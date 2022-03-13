using System;
using System.Collections.Generic;
using System.Linq;
using FoodShortage.Buyer;
namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());
            IBuyer buyer = default;

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] inputInfo = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    buyer = Creator.CreateBuyer(inputInfo);
                    buyers.Add(buyer);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                var person = buyers.FirstOrDefault  (n => n.Name == input);
                if (person != null)
                {
                    person.BuyFood();
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }

    }
}
