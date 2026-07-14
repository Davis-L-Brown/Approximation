using System;

namespace Interpolant.Options.Resolvers
{
    /// <summary>
    /// Class responsible for resolving <see cref="InterpolantOptions"/>
    /// into a <see cref="Resolved.InterpolantOptions"/>.
    /// </summary>
    internal static class InterpolantOptionsResolver
    {
        /// <summary>
        /// Resolve consumer facing <see cref="InterpolantOptions"/> into 
        /// resolved <see cref="Resolved.InterpolantOptions"/>.
        /// </summary>
        /// <param name="options">
        /// The consumer facing interpolant options object.
        /// </param>
        /// <returns>
        /// A <see cref="Resolved.InterpolantOptions"/> object, created by
        /// validating and resolving <paramref name="options"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="options"/> is null.
        /// </exception>
        public static Resolved.InterpolantOptions Resolve(
            InterpolantOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            var input = InputOptionsResolver.Resolve(options.Input);
            var output = OutputOptionsResolver.Resolve(options.Output);
            //var interpolation = InterpolationOptionsResolver.Resolve(options.Interpolation);
            //var extrapolation = ExtrapolationOptionsResolver.Resolve(options.Extrapolation);

            //return new Resolved.InterpolantOptions(
            //    input,
            //    output,
            //    interpolation,
            //    extrapolation);

            return new Resolved.InterpolantOptions(
                input, output);
        }
    }
}
