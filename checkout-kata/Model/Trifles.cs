using CheckOutKata.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Model
{
    public class Trifles : IItems
    {
        public string ItemName { get; set; }
        public string SKU { get; set; }
        public double ItemPrice { get; set; }

        public Trifles()
        {
            ItemName = "Trifles";
            SKU = "A99";
            ItemPrice = 99;
        }
    }
}
