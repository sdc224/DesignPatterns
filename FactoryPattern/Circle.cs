// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Circle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Circle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FactoryPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The circle.
    /// </summary>
    public class Circle : IShape
    {
        /// <inheritdoc />
        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a circle!");
        }
    }
}