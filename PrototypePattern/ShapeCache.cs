// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShapeCache.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the ShapeCache type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrototypePattern
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The shape cache.
    /// </summary>
    public class ShapeCache
    {
        /// <summary>
        /// The shape hash table.
        /// </summary>
        private static readonly Hashtable ShapeHashtable = new Hashtable(new Dictionary<string, Shape>());

        /// <summary>
        /// The get shape.
        /// </summary>
        /// <param name="shapeId">
        /// The shape id.
        /// </param>
        /// <returns>
        /// The <see cref="Shape"/>.
        /// </returns>
        public static Shape GetShape(string shapeId)
        {
            var cachedShape = (Shape)ShapeHashtable[shapeId];
            return (Shape)cachedShape.Clone();
        }

        /// <summary>
        /// The load cache.
        /// </summary>
        public static void LoadCache()
        {
            var circle = new Circle { Id = "1" };
            ShapeHashtable.Add(circle.Id, circle);

            var square = new Square { Id = "2" };
            ShapeHashtable.Add(square.Id, square);

            var rectangle = new Rectangle { Id = "3" };
            ShapeHashtable.Add(rectangle.Id, rectangle);
        }
    }
}