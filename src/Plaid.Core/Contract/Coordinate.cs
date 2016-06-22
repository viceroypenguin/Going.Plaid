namespace Gigobyte.Plaid.Contract
{
    /// <summary> Represents a X & Y coordinate of a location. </summary>
    public class Coordinate
    {
        /// <summary>
        /// Gets or sets the 'X' coordinate.
        /// </summary>
        /// <value>The latitude.</value>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the 'Y' coordinate.
        /// </summary>
        /// <value>The longitude.</value>
        public double Longitude { get; set; }
    }
}