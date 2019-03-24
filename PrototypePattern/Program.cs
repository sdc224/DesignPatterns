// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrototypePattern
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
            ShapeCache.LoadCache();

            var clonedShape = (Shape)ShapeCache.GetShape("1");
            Console.WriteLine($"Shape : {clonedShape.GetType()}");

            var clonedShape2 = (Shape)ShapeCache.GetShape("2");
            Console.WriteLine($"Shape : {clonedShape2.GetType()}");

            var clonedShape3 = (Shape)ShapeCache.GetShape("3");
            Console.WriteLine($"Shape : {clonedShape3.GetType()}");
        }
    }
}
