// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShapeFactory.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the ShapeFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FactoryPattern
{
    using System;
    using System.Globalization;

    /// <summary>
    /// The shape factory.
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// The get shape.
        /// </summary>
        /// <param name="shapeType">
        /// The shape type.
        /// </param>
        /// <returns>
        /// The <see cref="IShape"/>.
        /// </returns>
        public IShape GetShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
            {
                return null;
            }

            if (string.Compare(shapeType, "RECTANGLE", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                return new Rectangle();
            }

            if (string.Compare(shapeType, "SQUARE", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                return new Square();
            }

            return string.Compare(shapeType, "CIRCLE", StringComparison.CurrentCultureIgnoreCase) == 0
                       ? new Circle()
                       : null;
        }
    }
}
