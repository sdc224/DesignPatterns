// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            var mealBuilder = new MealBuilder();
            
            // create an object of veg meal
            var vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal...");
            vegMeal.ShowItems();
            Console.WriteLine($"Total Cost: {vegMeal.GetCost()}\n");

            // create an object of non veg meal
            var nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("Non Veg Meal...");
            nonVegMeal.ShowItems();
            Console.WriteLine($"Total Cost: {nonVegMeal.GetCost()}\n");
        }
    }
}
