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

            Basket myBasket = new Basket(myItems);
            myBasket.CalculatePrice();

            System.Console.ReadLine();
        }
    }
}
