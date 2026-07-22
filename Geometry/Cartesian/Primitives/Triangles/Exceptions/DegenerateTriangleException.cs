using System;

namespace Geometry.Cartesian.Primitives.Triangles.Exceptions
{
    public class DegenerateTriangleException : ArgumentException
    {
        public DegenerateTriangleException(string messsage = "") 
            : base (messsage) { }
    }
}
