// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoundedSquare.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the RoundedSquare type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The rounded square.
    /// </summary>
    public class RoundedSquare : IShape
    {
        /// <inheritdoc />
        /// <summary>
        /// The draw.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a Rounded Square");
        }
    }
}