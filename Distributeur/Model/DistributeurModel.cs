using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur.Model
{
    public class DistributeurModel
    {
        public List<MoneyModel> ListMoneys { get; set; }
        public List<DrinkModel> ListDrinks { get; set; }

        public List<DrinkModel> ListSoldDrinks { get; set; }
        public List<MoneyModel> ListRecievedMoney { get; set; }
    }
}
