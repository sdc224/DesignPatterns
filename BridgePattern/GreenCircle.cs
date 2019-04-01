// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GreenCircle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the GreenCircle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BridgePattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The green circle.
    /// </summary>
    public class GreenCircle : IDrawApiBridgeImplementer
    {
        /// <inheritdoc />
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
        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine($"Drawing circle\nColor : Green\nCentre : ({x}, {y})\nRadius: {radius}");
        }
    }
}