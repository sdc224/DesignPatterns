// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Meal.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Meal type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The meal.
    /// </summary>
    public class Meal
    {
        /// <summary>
        /// The items.
        /// </summary>
        private IList<IItem> items = new List<IItem>();

        /// <summary>
        /// The add item.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        /// <summary>
        /// The remove item.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        /// <summary>
        /// The get cost.
        /// </summary>
        /// <returns>
        /// The <see cref="float"/>.
        /// </returns>
        public float GetCost()
        {
            return this.items.Sum(item => item.Price());
        }

        /// <summary>
        /// The show items.
        /// </summary>
        public void ShowItems()
        {
            foreach (var item in this.items)
            {
                Console.WriteLine($"Name : {item.Name()}");
                Console.WriteLine($"Packing : {item.Packing().Pack()}");
                Console.WriteLine($"Price : {item.Price()}");
            }
        }
    }
}