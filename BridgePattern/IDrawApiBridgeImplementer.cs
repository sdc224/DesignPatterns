// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDrawApiBridgeImplementer.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the IDrawAPI type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BridgePattern
{
    /// <summary>
    /// The DrawAPI interface.
    /// </summary>
    public interface IDrawApiBridgeImplementer
    {
        /// <summary>
        /// The draw circle.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        void DrawCircle(int x, int y, int radius);
    }
}