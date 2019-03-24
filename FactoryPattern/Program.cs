// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FactoryPattern
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
            var shapeFactory = new ShapeFactory();

            // get an object of rectangle and call its draw method
            var rectangleShape = shapeFactory.GetShape("RECTANGLE");
            rectangleShape.Draw();

            // get an object of square and call its draw method
            var squareShape = shapeFactory.GetShape("SQUARE");
            squareShape.Draw();

            // get an object of circle and call its draw method
            var circleShape = shapeFactory.GetShape("CIRCLE");
            circleShape.Draw();

            Console.ReadKey();
        }
    }
}
