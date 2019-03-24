// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoundedRectangle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the RoundedRectangle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The rounded rectangle.
    /// </summary>
    public class RoundedRectangle : IShape
    {
        /// <inheritdoc />
        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a Rounded Rectangle");
        }
    }
}