// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pepsi.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Pepsi type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <inheritdoc />
    /// <summary>
    /// The pepsi.
    /// </summary>
    public class Pepsi : ColdDrink
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
            return "Pepsi";
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
            return 28f;
        }
    }
}