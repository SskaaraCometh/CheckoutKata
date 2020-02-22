using CheckOutKata.Interfaces;
using System;

namespace CheckOutKata.Items
{
	public class Apples : IItems
	{
		public string ItemName { get; set; }
		public string SKU { get; set; }
		public double ItemPrice { get; set; }
		public double UnitIncrement { get; set; }

		public Apples()
		{
			ItemName = "Apples";
			SKU = "A99";
			ItemPrice = 50;
			UnitIncrement = 0;
		}

	}
}
