// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbstractFactory.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the AbstractFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    /// <summary>
    /// The abstract factory.
    /// </summary>
    public abstract class AbstractFactory
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
        public abstract IShape GetShape(string shapeType);
    }
}