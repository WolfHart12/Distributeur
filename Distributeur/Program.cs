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
            Console.WriteLine("Distributeur Online");

            // Convert special symbols to show on console ex : €
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Distributeurs dist = new Distributeurs();
            dist.Init();
            //dist.Status();
            int selectedDrink = 0;
            while (selectedDrink != -999)
            {
                selectedDrink = dist.SelectDrink();
                Console.WriteLine($"Boisson choisi: {selectedDrink}");

            }
            Console.WriteLine("Distributeur Ofline");
        }
    }
}
