// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bottle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Bottle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <inheritdoc />
    /// <summary>
    /// The bottle.
    /// </summary>
    public class Bottle : IPacking
    {
        /// <inheritdoc />
        /// <summary>
        /// The pack.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.String" />.
        /// </returns>
        public string Pack()
        {
            return "Bottle";
        }
    }
}