// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Shape.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Shape type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrototypePattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The shape.
    /// </summary>
    public abstract class Shape : ICloneable
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        protected string Type { get; set; }

        /// <summary>
        /// The draw.
        /// </summary>
        public abstract void Draw();

        /// <summary>
        /// The get type.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public new string GetType()
        {
            return this.Type;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// The clone.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Object" />.
        /// </returns>
        public object Clone()
        {
            object clone;

            try
            {
                clone = this.MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            return clone;
        }
    }
}