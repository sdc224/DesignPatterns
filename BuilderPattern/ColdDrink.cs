// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColdDrink.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the ColdDrink type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <inheritdoc />
    /// <summary>
    /// The cold drink.
    /// </summary>
    public abstract class ColdDrink : IItem
    {
        /// <inheritdoc />
        /// <summary>
        /// The name.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.String" />.
        /// </returns>
        public abstract string Name();

        /// <inheritdoc />
        /// <summary>
        /// The packing.
        /// </summary>
        /// <returns>
        /// The <see cref="T:BuilderPattern.IPacking" />.
        /// </returns>
        public IPacking Packing()
        {
            return new Bottle();
        }

        /// <inheritdoc />
        /// <summary>
        /// The price.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Single" />.
        /// </returns>
        public abstract float Price();
    }
}