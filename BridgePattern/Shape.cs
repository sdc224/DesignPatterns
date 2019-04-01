// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Shape.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Shape type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BridgePattern
{
    /// <summary>
    /// The shape.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// The draw API.
        /// </summary>
        protected IDrawApiBridgeImplementer DrawApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        /// <param name="drawApi">
        /// The draw API.
        /// </param>
        protected Shape(IDrawApiBridgeImplementer drawApi)
        {
            this.DrawApi = drawApi;
        }

        /// <summary>
        /// The draw.
        /// </summary>
        public abstract void Draw();
    }
}