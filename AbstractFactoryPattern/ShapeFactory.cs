// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShapeFactory.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the ShapeFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The shape factory.
    /// </summary>
    public class ShapeFactory : AbstractFactory
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
                return new Rectangle();
            }

            return string.Compare(shapeType, "SQUARE", StringComparison.CurrentCultureIgnoreCase) == 0
                       ? new Square()
                       : null;
        }
    }
}