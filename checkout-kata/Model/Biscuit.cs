using CheckOutKata.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Model
{
    public class Biscuit : IItems
    {
        public string ItemName { get; set; }
        public string SKU { get; set; }
        public double ItemPrice { get; set; }  

        public Biscuit()
        {
            ItemName = "Biscuits";
            SKU = "B15";
            ItemPrice = 30;
        }

    }
}
