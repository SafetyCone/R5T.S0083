using System;

using R5T.T0141;


namespace R5T.S0083
{
    /// <summary>
    /// Experiments involving versions.
    /// </summary>
    [ExperimentsMarker]
    public partial interface IVersionExperiments : IExperimentsMarker
    {
        public void ParsingTwoDigits()
        {
            /// Instances.
            var versionName = Instances.ExampleVersionNames.V3_0;


            /// Run.
            // System.FormatException: 'Input string was not in a correct format.'
            var version = Version.Parse(versionName.Value);

            Console.WriteLine(version);
        }

        /// <summary>
        /// What happens if the version string is just a number and a dot? (Example: "3.")
        /// <para>Result: System.FormatException: 'Input string was not in a correct format.'</para>
        /// </summary>
        public void ParsingSingleDigit_WithDot()
        {
            /// Instances.
            var versionName = Instances.PathologicalVersionNames.SingleDigit_WithDot;


            /// Run.
            // System.FormatException: 'Input string was not in a correct format.'
            var version = Version.Parse(versionName.Value);

            Console.WriteLine(version);
        }

        /// <summary>
        /// What happens if the version string is just a number? (Example: "3")
        /// <para>Result: System.ArgumentException: 'Version string portion was too short or too long. (Parameter 'input')'</para>
        /// </summary>
        public void ParsingSingleDigit()
        {
            /// Instances.
            var versionName = Instances.PathologicalVersionNames.SingleDigit;


            /// Run.
            // System.ArgumentException: 'Version string portion was too short or too long. (Parameter 'input')'
            var version = Version.Parse(versionName.Value);

            Console.WriteLine(version);
        }

        /// <summary>
        /// What happens if one of the version name tokens has multiple zeros? (Example 3.0.00.0)
        /// Result: no issues.
        /// </summary>
        public void ParsingMultipleZeros()
        {
            /// Instances.
            var versionName = Instances.PathologicalVersionNames.MultipleZeros_Two;


            /// Run.
            // No issues.
            var version = Version.Parse(versionName.Value);

            Console.WriteLine(version);
        }

        /// <summary>
        /// What happens when you parse a version name that has too many tokens?
        /// Result: System.ArgumentException: 'Version string portion was too short or too long. (Parameter 'input')'
        /// </summary>
        public void ParsingTooManyTokens()
        {
            /// Instances.
            var versionName = Instances.PathologicalVersionNames.TooManyTokens;


            /// Run.
            // System.ArgumentException: 'Version string portion was too short or too long. (Parameter 'input')'
            var version = Version.Parse(versionName.Value);

            Console.WriteLine(version);
        }
    }
}
