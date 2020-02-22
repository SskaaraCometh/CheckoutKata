using System;

namespace CheckOutKata.Interfaces
{
	public interface IItems
	{
		/// <summary>
        /// Gets or sets Item Name
        /// </summary>
		string ItemName { get; set; }

		/// <summary>
        /// Gets or Sets Item Serian Number
        /// </summary>
		string SKU { get; set; }

		/// <summary>
		/// Get or Sets item Price
		/// </summary>
		double ItemPrice { get; set; }
	}
}
