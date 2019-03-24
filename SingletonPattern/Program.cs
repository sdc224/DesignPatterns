// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SingletonPattern
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
            var singleObjectInstance = SingleObject.GetSingleObjectInstance();
            singleObjectInstance.ShowMessage();

            Console.ReadKey();
        }
    }
}
