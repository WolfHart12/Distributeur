using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur.Model
{
    public class MoneyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }

        public string Status()
        {
            return $"Name : {this.Name}\t - Value : {this.Value}\t - Quantity : {this.Quantity}";
        }
    }
}
