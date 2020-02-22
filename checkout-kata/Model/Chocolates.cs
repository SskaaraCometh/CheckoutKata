using CheckOutKata.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Model
{
    public class Chocolates : IItems
    {
        public string ItemName { get; set; }
        public string SKU { get; set; }
        public double ItemPrice { get; set; }

        public Chocolates()
        {
            ItemName = "Chocolates";
            SKU = "C40";
            ItemPrice = 60;
        }
    }
}
