// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Rectangle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The rectangle.
    /// </summary>
    public class Rectangle : IShape
    {
        /// <inheritdoc />
        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}