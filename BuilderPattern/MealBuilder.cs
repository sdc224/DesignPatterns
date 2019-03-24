// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MealBuilder.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the MealBuilder type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <summary>
    /// The meal builder.
    /// </summary>
    public class MealBuilder
    {
        /// <summary>
        /// The prepare veg meal.
        /// </summary>
        /// <returns>
        /// The <see cref="Meal"/>.
        /// </returns>
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        /// <summary>
        /// The prepare non veg meal.
        /// </summary>
        /// <returns>
        /// The <see cref="Meal"/>.
        /// </returns>
        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}