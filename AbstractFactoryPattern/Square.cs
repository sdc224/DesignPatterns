// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Square.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Square type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The square.
    /// </summary>
    public class Square : IShape
    {
        /// <inheritdoc />
        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
}