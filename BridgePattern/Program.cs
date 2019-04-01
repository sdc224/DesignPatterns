// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BridgePattern
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            var redCircle = new Circle(100, 100, 20, new RedCircle());
            var greenCircle = new Circle(200, 200, 10, new GreenCircle());

            redCircle.Draw();
            Console.WriteLine();
            greenCircle.Draw();
        }
    }
}
