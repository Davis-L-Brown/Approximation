namespace Interpolant.Options
{
    /// <summary>
    /// Defines custom options for an interpolator object.
    /// </summary>
    public sealed class InterpolantOptions
    {
        /// <summary>
        /// Represents the <see cref="OutputOptions"/> for an interpolator object. 
        /// </summary>
        public OutputOptions Output { get; set; }

        /// <summary>
        /// Represents the <see cref="InputOptions"/> for an interpolator object.
        /// </summary>
        public InputOptions Input { get; set; }

        /// <summary>
        /// Represents the <see cref="InterpolationOptions"/> for an interpolator object.
        /// </summary>
        public InterpolationOptions Interpolation { get; set; }

        /// <summary>
        /// Represents the <see cref="ExtrapolationOptions"/> for an interpolator object.
        /// </summary>
        public ExtrapolationOptions Extrapolation { get; set; }
    }
}
