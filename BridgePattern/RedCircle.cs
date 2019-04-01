// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RedCircle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the RedCircle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BridgePattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The red circle.
    /// </summary>
    public class RedCircle : IDrawApiBridgeImplementer
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
            Console.WriteLine($"Drawing circle\nColor : Red\nCentre : ({x}, {y})\nRadius: {radius}");
        }
    }
}