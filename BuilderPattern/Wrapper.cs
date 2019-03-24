// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Wrapper.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Wrapper type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <inheritdoc />
    /// <summary>
    /// The wrapper.
    /// </summary>
    public class Wrapper : IPacking
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
            return "Wrapper";
        }
    }
}