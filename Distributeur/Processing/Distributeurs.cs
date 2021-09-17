using Distributeur.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur.Processing
{
    public class Distributeurs
    {
        //Atribut
        public DistributeurModel distributeur { get; set; }

        //Methode
        public void Init()
        {
            this.distributeur = new DistributeurModel();

            this.distributeur.ListDrinks = new List<DrinkModel>();
            DrinkModel coca = new DrinkModel();
            coca.Id = 1;
            coca.Name = "Coca";
            coca.Value = 1.25;
            coca.Quantity = 20;
            this.distributeur.ListDrinks.Add(coca);
            DrinkModel sniker = new DrinkModel();
            sniker.Id = 2;
            sniker.Name = "Sniker";
            sniker.Value = 0.90;
            sniker.Quantity = 20;
            this.distributeur.ListDrinks.Add(sniker);
            DrinkModel mars = new DrinkModel();
            mars.Id = 3;
            mars.Name = "Mars";
            mars.Value = 0.85;
            mars.Quantity = 20;
            this.distributeur.ListDrinks.Add(mars);

            this.distributeur.ListMoneys = new List<MoneyModel>();
            MoneyModel euro2 = new MoneyModel();
            euro2.Id = 1;
            euro2.Name = "2 euros";
            euro2.Value = 2;
            euro2.Quantity = 10;
            this.distributeur.ListMoneys.Add(euro2);
            MoneyModel euro1 = new MoneyModel();
            euro1.Id = 2;
            euro1.Name = "1 euro";
            euro1.Value = 1;
            euro1.Quantity = 20;
            this.distributeur.ListMoneys.Add(euro1);
            MoneyModel cent50 = new MoneyModel();
            cent50.Id = 3;
            cent50.Name = "50 cent";
            cent50.Value = 0.5;
            cent50.Quantity = 10;
            this.distributeur.ListMoneys.Add(cent50);
            MoneyModel cent20 = new MoneyModel();
            cent20.Id = 4;
            cent20.Name = "20 cent";
            cent20.Value = 0.2;
            cent20.Quantity = 10;
            this.distributeur.ListMoneys.Add(cent20);
            MoneyModel cent10 = new MoneyModel();
            cent10.Id = 5;
            cent10.Name = "10 cent";
            cent10.Value = 0.1;
            cent10.Quantity = 10;
            this.distributeur.ListMoneys.Add(cent10);
            MoneyModel cent05 = new MoneyModel();
            cent05.Id = 6;
            cent05.Name = "5 cent";
            cent05.Value = 0.05;
            cent05.Quantity = 10;
            this.distributeur.ListMoneys.Add(cent05);
        }

        public string Status()
        {
            string status = "Distributeur status\n\n";

            string moneyStatus = "Money status\n";
            foreach(MoneyModel moeny in this.distributeur.ListMoneys)
            {
                moneyStatus += moeny.Status() + "\n";
            }
            status += moneyStatus + "\n";

            string drinkStatus = "Drink status\n";
            foreach (DrinkModel drink in this.distributeur.ListDrinks)
            {
                drinkStatus += drink.Status() + "\n";
            }
            status += drinkStatus;

            Console.WriteLine(status);
            return status;
        }

        public string ShowDrinks()
        {
            string result = "";

            result += "=============================\n";
            foreach(DrinkModel drink in this.distributeur.ListDrinks)
            {
                result += $"| [{drink.Id}] - {drink.Name} : {drink.Value} €\n";
            }
            result += "=============================\n";

            Console.WriteLine(result);
            return result;
        }
    }
}
