// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IItem.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the IItem type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BuilderPattern
{
    /// <summary>
    /// The Item interface.
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// The name.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string Name();

        /// <summary>
        /// The packing.
        /// </summary>
        /// <returns>
        /// The <see cref="IPacking"/>.
        /// </returns>
        IPacking Packing();

        /// <summary>
        /// The price.
        /// </summary>
        /// <returns>
        /// The <see cref="float"/>.
        /// </returns>
        float Price();
    }
}