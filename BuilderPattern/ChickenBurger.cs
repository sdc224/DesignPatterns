// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChickenBurger.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the ChickenBurger type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <inheritdoc />
    /// <summary>
    /// The chicken burger.
    /// </summary>
    public class ChickenBurger : Burger
    {
        /// <inheritdoc />
        /// <summary>
        /// The name.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.String" />.
        /// </returns>
        public override string Name()
        {
            return "Chicken Burger";
        }

        /// <inheritdoc />
        /// <summary>
        /// The price.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Single" />.
        /// </returns>
        public override float Price()
        {
            return 80f;
        }
    }
}