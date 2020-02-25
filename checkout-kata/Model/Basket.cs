using checkout_kata.Interfaces;
using CheckOutKata.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Model
{
    public class Basket : IBasket
    {
        public double AppleCount { get; set; }
        public double BiscuitCount { get; set; }
        public double ChocolateCount { get; set; }
        public double TrifleCount { get; set; }
        public double TotalPrice { get; set; }
        public static List<IItems> ItemsInBasket { get; set; }
        public double AppleOfferModifier { get; set; }
        public double ApplesFinalPrice { get; set; }
        public double AppleUnitPrice { get; set; }
        public double AppleOfferNumber { get; set; }
        public double BiscuitsFinalPrice {get; set;}
        public double BiscuitUnitPrice { get; set; }
        public double BiscuisOfferModifier { get; set; }
        public double BiscuitsOfferNumber { get; set; }

        public Basket(List<IItems> newBasket, double InitialApplesModifier, double InitialBiscuitsModifier, double AppleOfferNo, double BiscuitOfferNo)
        {
            ItemsInBasket = newBasket;
            AppleOfferModifier = InitialApplesModifier;
            BiscuisOfferModifier = InitialBiscuitsModifier;
            AppleOfferNumber = AppleOfferNo;
            BiscuitsOfferNumber = BiscuitOfferNo;

            CalculateItemCount();
        }

        public void CalculateItemCount()
        {
            foreach (var item in ItemsInBasket)
            {
                if (item.ItemName == "Apples")
                {
                    AppleCount++;
                }
                else if (item.ItemName == "Biscuits")
                {
                    BiscuitCount++;
                }
                else if (item.ItemName == "Chocolates")
                {
                    ChocolateCount++;
                }
                else
                {
                    TrifleCount++;
                }
            }
        }

        public void ApplesOffers()
        {
            try
            {
                double unitPrice = 50;

                if (AppleCount % AppleOfferNumber != 0)
                {
                    double remainder = AppleCount % AppleOfferNumber;
                    double numberOfDiscounts = AppleCount - remainder;

                    TotalPrice += (numberOfDiscounts * AppleOfferModifier) + (remainder * unitPrice);
                    TotalPrice = Math.Round(TotalPrice, 2);

                }
                else
                {
                    ApplesFinalPrice = AppleCount * AppleOfferModifier;
                    ApplesFinalPrice = Math.Round(ApplesFinalPrice, 2);
                    TotalPrice += ApplesFinalPrice;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
           
        }

        public void BiscuitOffers()
        {
            try
            {
                double unitPrice = 30;
                
                if (BiscuitCount % BiscuitsOfferNumber != 0)
                {
                    double remainder = BiscuitCount % BiscuitsOfferNumber;

                    double numberOfDiscounts = BiscuitCount - remainder;

                    TotalPrice += (numberOfDiscounts * BiscuisOfferModifier) + (remainder * unitPrice);
                }
                else
                {
                    BiscuitsFinalPrice = BiscuitCount * BiscuisOfferModifier;
                    BiscuitsFinalPrice = Math.Round(BiscuitsFinalPrice, 2);
                    TotalPrice += BiscuitsFinalPrice;
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
           
        }

        public double CalculatePrice()
        {
            try
            {
                if (BiscuitCount < 2 && AppleCount < 3)
                {
                    foreach (var item in ItemsInBasket)
                    {
                        TotalPrice += item.ItemPrice;
                    }
                }
                else if (BiscuitCount >= 2 && AppleCount >= 3)
                {
                    foreach (var item in ItemsInBasket)
                    {
                        if (item.ItemName != "Apples" && item.ItemName != "Biscuits")
                        {
                            TotalPrice += item.ItemPrice;
                        }
                    }
                }

                if (AppleCount != 0)
                {
                    ApplesOffers();
                }
                
                if(BiscuitCount != 0)
                {
                    BiscuitOffers();
                }
                             
                //TotalPrice = Math.Round(TotalPrice, 2);

                return TotalPrice;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
           
        }
    }
}
