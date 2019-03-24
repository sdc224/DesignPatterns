// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VegBurger.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the VegBurger type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <inheritdoc />
    /// <summary>
    /// The veg burger.
    /// </summary>
    public class VegBurger : Burger
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
            return "Veg Burger";
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
            return 60f;
        }
    }
}