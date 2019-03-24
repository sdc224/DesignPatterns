// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Rectangle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrototypePattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The rectangle.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle() => this.Type = "Rectangle";

        /// <inheritdoc />
        /// <summary>
        /// The draw.
        /// </summary>
        public override void Draw() => Console.WriteLine("Drawing a rectangle!");
    }
}