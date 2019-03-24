// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoundedShapeFactory.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the RoundedShapeFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The rounded shape factory.
    /// </summary>
    public class RoundedShapeFactory : AbstractFactory
    {
        /// <inheritdoc />
        /// <summary>
        /// The get shape.
        /// </summary>
        /// <param name="shapeType">
        /// The shape type.
        /// </param>
        /// <returns>
        /// The <see cref="T:AbstractFactoryPattern.IShape" />.
        /// </returns>
        public override IShape GetShape(string shapeType)
        {
            if (string.Compare(shapeType, "RECTANGLE", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                return new RoundedRectangle();
            }

            return string.Compare(shapeType, "SQUARE", StringComparison.CurrentCultureIgnoreCase) == 0
                       ? new RoundedSquare()
                       : null;
        }
    }
}