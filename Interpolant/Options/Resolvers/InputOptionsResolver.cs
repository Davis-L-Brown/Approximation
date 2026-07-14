using Interpolant.Options.Enums;
using System;

namespace Interpolant.Options.Resolvers
{
    /// <summary>
    /// Class responsible for resolving <see cref="InputOptions"/>
    /// into a <see cref="Resolved.InputOptions"/>.
    /// </summary>
    internal static class InputOptionsResolver
    {
        /// <summary>
        /// Resolve consumer facing <see cref="InputOptions"/> object into 
        /// a resolved <see cref="Resolved.InputOptions"/> object.
        /// </summary>
        /// <returns>
        /// An <see cref="Resolved.InputOptions"/> object, created by
        /// validating and resolving <paramref name="options"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="options"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="options"/> has a duplicate policy is not
        /// a valid <see cref="DuplicateCoordinatePolicy"/>.
        /// </exception>
        public static Resolved.InputOptions Resolve(
            InputOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (!Enum.IsDefined(typeof(DuplicateCoordinatePolicy), options.DuplicatePolicy))
                throw new ArgumentOutOfRangeException(nameof(options.DuplicatePolicy));

            return new Resolved.InputOptions(
                duplicatePolicy: options.DuplicatePolicy);
        }
    }
}
