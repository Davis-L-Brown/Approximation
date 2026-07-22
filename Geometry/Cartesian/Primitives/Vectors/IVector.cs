namespace Geometry.Cartesian.Primitives.Vectors
{
    /// <summary>
    /// Represents a vector in Cartesian space.
    /// </summary>
    public interface IVector
    {
        /// <summary>
        /// Gets the magnitude of the vector.
        /// </summary>
        double Magnitude { get; }

        /// <summary>
        /// Gets the magnitude squared.
        /// </summary>
        double MagnitudeSquared { get; }
    }


    /// <summary>
    /// Represents a vector in 1D Cartesian Space.
    /// </summary>
    public interface IVector1D : IVector
    {
        /// <summary>
        /// Gets the X direction of the vector.
        /// </summary>
        double X { get;  }
    }


    /// <summary>
    /// Represents a vector in 2D Cartesian space.
    /// </summary>
    public interface IVector2D : IVector1D
    {
        /// <summary>
        /// Gets the Y direction of the Vector.
        /// </summary>
        double Y { get; }
    }


    /// <summary>
    /// Represents a vector in 3D Cartesian space.
    /// </summary>
    public interface IVector3D : IVector2D
    {
        /// <summary>
        /// Gets the Z direction of the vector.
        /// </summary>
        double Z { get; }
    }
}
