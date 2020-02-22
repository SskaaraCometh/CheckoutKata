using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Interfaces
{
    interface IBasket
    {
        double CalculatePrice();
        void ApplesOffers();
        void BiscuitOffers();
        double AppleCount { get; set; }
        double BiscuitCount { get; set; }
        double ChocolateCount { get; set; }
        double TrifleCount { get; set; }
        double TotalPrice { get; set; }
    }
}
