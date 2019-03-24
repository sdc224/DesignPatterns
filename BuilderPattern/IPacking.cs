// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPacking.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the IPacking type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <summary>
    /// The Packing interface.
    /// </summary>
    public interface IPacking
    {
        /// <summary>
        /// The pack.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string Pack();
    }
}