namespace Interpolant.Options.Resolved
{
    /// <summary>
    /// Defines a resolved verion of the consumer facing 
    /// <see cref="Options.InterpolantOptions"/>.
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
    internal class InterpolantOptions
    {
        /// <summary>
        /// Get the resolved <see cref="InputOptions"/>.
        /// </summary>
        public InputOptions Input { get; }

        /// <summary>
        /// Get the resolved <see cref="OutputOptions"/>.
        /// </summary>
        public OutputOptions Output { get; }


        /// <summary>
        /// Create a new instance of <see cref="Options.Resolved.InterpolantOptions"/>,
        /// which is a resolved version of <see cref="Options.InterpolantOptions"/>
        /// </summary>
        public InterpolantOptions(
            InputOptions input,
            OutputOptions output)
        {
            Input = input;
            Output = output;
        }
    }
}
