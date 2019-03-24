// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Square.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Square type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrototypePattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The square.
    /// </summary>
    public class Square : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        public Square() => this.Type = "Square";

        /// <inheritdoc />
        /// <summary>
        /// The draw.
        /// </summary>
        public override void Draw() => Console.WriteLine("Drawing a Square!");
    }
}