// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactoryPattern
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            // get normal shape factory
            var shapeFactory = FactoryProducer.GetFactory(false);

            // get an object of shape rectangle and call its draw method
            var rectangleShape = shapeFactory.GetShape("rectangle");
            rectangleShape.Draw();

            // get an object of shape square and call its draw method
            shapeFactory.GetShape("Square").Draw();

            // get rounded shape factory
            var roundedShapeFactory = FactoryProducer.GetFactory(true);
            
            // get an object of rounded shape rectangle and call its draw method
            roundedShapeFactory.GetShape("Rectangle").Draw();

            // get an object of rounded shape square and call its draw method
            roundedShapeFactory.GetShape("Square").Draw();

            Console.ReadKey();
        }
    }
}
