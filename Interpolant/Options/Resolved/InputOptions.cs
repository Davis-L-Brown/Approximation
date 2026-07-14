using Interpolant.Options.Enums;

namespace Interpolant.Options.Resolved
{
    /// <summary>
    /// Defines a resolved version of the consumer facing 
    /// <see cref="Options.InputOptions"/>. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// Resolved output options are guaranteed to have the required option
    /// fields validated and populated.
    /// </para>
    /// <para>
    /// Resolved output options are meant to be consumed by the concrete 
    /// interpolant class that will perform evaluation. 
    /// <br/>
    /// Because the options are
    /// resolved, there should be no need to verify options after the creation
    /// of the interpolant.
    /// </para>
    /// </remarks>
    internal sealed class InputOptions
    {
        /// <summary>
        /// Get the policy for duplicate inputed (x,y) coordinates.
        /// </summary>
        public DuplicateCoordinatePolicy DuplicatePolicy { get; }


        /// <summary>
        /// Create an instance of <see cref="InputOptions"/>.
        /// </summary>
        public InputOptions(DuplicateCoordinatePolicy duplicatePolicy)
        {
            DuplicatePolicy = duplicatePolicy;
        }
    }
}
