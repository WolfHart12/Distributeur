using Distributeur.Processing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Distributeur
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert special symbols to show on console ex : €
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Distributeurs dist = new Distributeurs();
            dist.Init();
            //dist.Status();
            int chooseDrink = 0;
            List<int> listDrinkID = dist.distributeur.ListDrinks.Select(s => s.Id).ToList();
            do
            {
                dist.ShowDrinks();
                Console.Write("Veullez chsoisir votre article : ");
                int.TryParse(Console.ReadLine(), out chooseDrink);
            } while (!listDrinkID.Contains(chooseDrink));

            Console.WriteLine($"Boisson choisi: {chooseDrink}");
            
        }
    }
}
