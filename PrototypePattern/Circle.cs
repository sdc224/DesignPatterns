// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Circle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Circle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrototypePattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The circle.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle() => this.Type = "Circle";

        /// <inheritdoc />
        /// <summary>
        /// The draw.
        /// </summary>
        public override void Draw() => Console.WriteLine("Drawing a Circle!");
    }
}