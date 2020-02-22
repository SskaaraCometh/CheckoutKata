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
        List<IItems> ItemsInBasket { get; set; }

        public Basket(List<IItems> newBasket)
        {
            ItemsInBasket = newBasket;

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
                double ApplesFinalPrice = 0;
                double offerMultiplier = 43.3333333333;
                double unitPrice = 50;

                if (AppleCount % 3 != 0)
                {
                    double remainder = AppleCount % 3;
                    double numberOfDiscounts = AppleCount - remainder;

                    TotalPrice += (numberOfDiscounts * offerMultiplier) + (remainder * unitPrice);
                    
                }
                else
                {
                    ApplesFinalPrice = AppleCount * offerMultiplier;
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
                double BiscuitsFinalPrice = 0;
                double offerMultiplyer = 22.5;
                double unitPrice = 30;
                
                if (BiscuitCount % 2 != 0)
                {
                    double remainder = BiscuitCount % 2;

                    double numberOfDiscounts = BiscuitCount - remainder;

                    TotalPrice += (numberOfDiscounts * offerMultiplyer) + (remainder * unitPrice);
                }
                else
                {
                    BiscuitsFinalPrice = BiscuitCount * offerMultiplyer;
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
                

                ApplesOffers();
                BiscuitOffers();

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
