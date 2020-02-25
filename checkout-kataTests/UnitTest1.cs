using checkout_kata.Model;
using CheckOutKata.Interfaces;
using CheckOutKata.Items;
using NUnit.Framework;
using System.Collections.Generic;

namespace checkout_kataTests
{
    public class CheckoutkataTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddingItemsToBasket_AddingApplesToList_ApplesToBeAdded()
        {
            //Arrange
            List<IItems> myItems = new List<IItems>();
            List<Apples> myApples = new List<Apples>();
            for (int i = 0; i < 4; i++)
            {
                myApples.Add(new Apples());
                
            }

            foreach (var apple in myApples)
            {
                myItems.Add(apple);
            }

            int itemCount = 4;
            //Act
            Basket myBasket = new Basket(myItems,0,0,0,0);

            //Assert     
            Assert.AreEqual(Basket.ItemsInBasket.Count, itemCount);
            Assert.Pass();
        }

        [Test]
        public void AddingItemsToBasket_AddingBiscuitsToList_BiscuitsToBeAdded()
        {
            List<IItems> myItems = new List<IItems>();
            List<Biscuit> myBiscuits = new List<Biscuit>();
            for (int i = 0; i < 4; i++)
            {
                myBiscuits.Add(new Biscuit());

            }

            foreach (var biscuits in myBiscuits)
            {
                myItems.Add(biscuits);
            }

            int itemCount = 4;
            //Act
            Basket myBasket = new Basket(myItems,0,0,0,0);

            //Assert     
            Assert.AreEqual(Basket.ItemsInBasket.Count, itemCount);
            Assert.Pass();
        }

        [Test]
        public void AddingItemsToBasket_AddingChocolatesToList_ChocolatesToBeAdded()
        {
            List<IItems> myItems = new List<IItems>();
            List<Chocolates> myChocolates = new List<Chocolates>();

            for (int i = 0; i < 4; i++)
            {
                myChocolates.Add(new Chocolates());

            }

            foreach (var chocolate in myChocolates)
            {
                myItems.Add(chocolate);
            }

            int itemCount = 4;

            //Act
            Basket myBasket = new Basket(myItems,0,0,0,0);

            //Assert     
            Assert.AreEqual(Basket.ItemsInBasket.Count, itemCount);
            Assert.Pass();
        }

        [Test]
        public void AddingItemsToBasket_AddingTriflesToList_TriflesToBeAdded()
        {
            List<IItems> myItems = new List<IItems>();
            List<Trifles> myTrifles = new List<Trifles>();
            for (int i = 0; i < 4; i++)
            {
                myTrifles.Add(new Trifles());

            }

            foreach (var trifle in myTrifles)
            {
                myItems.Add(trifle);
            }

            int itemCount = 4;

            //Act
            Basket myBasket = new Basket(myItems,0,0,0,0);

            //Assert     
            Assert.AreEqual(Basket.ItemsInBasket.Count, itemCount);
            Assert.Pass();
        }

        [Test]
        public void ApplesOffers_ChangingModifier_ModifierToBeChangedAndResultCorrect()
        {
            //Arrange
            List<IItems> myItems = new List<IItems>();
            List<Apples> myApples = new List<Apples>();
            for (int i = 0; i < 3; i++)
            {
                myApples.Add(new Apples());

            }

            foreach (var apple in myApples)
            {
                myItems.Add(apple);
            }
            double applesModifier = 43.3333333333;
            double applesOfferNumber = 3;
            double collectivePrice = 130;

            //Act
            Basket myBasket = new Basket(myItems, applesModifier, 0, applesOfferNumber, 0);
            myBasket.CalculatePrice();
            System.Console.WriteLine(myBasket.TotalPrice);

            //Assert     
            Assert.AreEqual(myBasket.TotalPrice, collectivePrice);
            Assert.Pass();
        }

        [Test]
        public void BiscuitOffers_ChangingModifier_ModifierToBeChangedAndResultCorrect()
        {
            //Arrange
            List<IItems> myItems = new List<IItems>();
            List<Biscuit> myBiscuits = new List<Biscuit>();
            for (int i = 0; i < 2; i++)
            {
                myBiscuits.Add(new Biscuit());

            }

            foreach (var biscuits in myBiscuits)
            {
                myItems.Add(biscuits);
            }
            double biscuitsModifier = 22.5;
            double biscuitOfferNumber = 2;
            double collectivePrice = 45;

            //Act
            Basket myBasket = new Basket(myItems, 0, biscuitsModifier, 0, biscuitOfferNumber);
            myBasket.CalculatePrice();
            System.Console.WriteLine(myBasket.TotalPrice);

            //Assert     
            Assert.AreEqual(myBasket.TotalPrice, collectivePrice);
            Assert.Pass();
        }
    }
}