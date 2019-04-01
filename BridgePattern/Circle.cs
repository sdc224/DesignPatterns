// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Circle.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Circle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BridgePattern
{
    /// <inheritdoc />
    /// <summary>
    /// The circle.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// The x.
        /// </summary>
        private readonly int x;

        /// <summary>
        /// The y.
        /// </summary>
        private readonly int y;

        /// <summary>
        /// The radius.
        /// </summary>
        private readonly int radius;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BridgePattern.Circle" /> class.
        /// </summary>
        /// <param name="drawApi">
        /// The draw API.
        /// </param>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <param name="radius">
        /// The radius.
        /// </param>
        public Circle(int x, int y, int radius, IDrawApiBridgeImplementer drawApi)
            : base(drawApi)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        /// <summary>
        /// The draw.
        /// </summary>
        public override void Draw()
        {
            this.DrawApi.DrawCircle(this.x, this.y, this.radius);
        }
    }
}