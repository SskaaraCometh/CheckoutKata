using checkout_kata.Model;
using CheckOutKata.Interfaces;
using CheckOutKata.Items;
using System;
using System.Collections.Generic;

namespace checkout_kata.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IItems> myItems = new List<IItems>();
            List<Apples> myApples = new List<Apples>();
            List<Biscuit> myBiscuits = new List<Biscuit>();
            List<Chocolates> myChocolates = new List<Chocolates>();
            double applesModifier = 43.3333333333;
            double biscuitsModifier = 22.5;
            double applesOfferNumber = 3;
            double biscuitOfferNumber = 2;
            for (int i = 0; i < 4; i++)
            {
                myApples.Add(new Apples());
                myBiscuits.Add(new Biscuit());
            }

            for (int i = 0; i < 1; i++)
            {
                myChocolates.Add(new Chocolates());
            }

            foreach (var apple in myApples)
            {
                myItems.Add(apple);
            }

            foreach (var biscuit in myBiscuits)
            {
                myItems.Add(biscuit);
            }

            foreach (var chocolate in myChocolates)
            {
                myItems.Add(chocolate);
            }

            Basket myBasket = new Basket(myItems, applesModifier, biscuitsModifier, applesOfferNumber, biscuitOfferNumber);
            myBasket.CalculatePrice();

            System.Console.ReadLine();
        }
    }
}
