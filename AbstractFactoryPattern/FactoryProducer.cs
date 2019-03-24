// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryProducer.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the FactoryProducer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    /// <summary>
    /// The factory producer.
    /// </summary>
    public class FactoryProducer
    {
        /// <summary>
        /// The get factory.
        /// </summary>
        /// <param name="rounded">
        /// The rounded.
        /// </param>
        /// <returns>
        /// The <see cref="AbstractFactory"/>.
        /// </returns>
        public static AbstractFactory GetFactory(bool rounded)
        {
            return rounded ? (AbstractFactory)new RoundedShapeFactory() : new ShapeFactory();
        }
    }
}