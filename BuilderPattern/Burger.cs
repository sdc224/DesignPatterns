// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Burger.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Burger type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <summary>
    /// The burger.
    /// </summary>
    public abstract class Burger : IItem
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
            return new Wrapper();
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