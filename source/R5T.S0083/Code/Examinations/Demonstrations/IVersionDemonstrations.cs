using System;

using R5T.T0141;
using R5T.T0185.Extensions;


namespace R5T.S0083
{
    /// <summary>
    /// Demonstrations involving versions.
    /// </summary>
    [DemonstrationsMarker]
    public partial interface IVersionDemonstrations : IDemonstrationsMarker
    {
        public void Choose_HighestSubVersionOf()
        {
            /// Inputs.
            var versions = Instances.ExampleVersionSets.N_001;
            var majorVersion = 6.ToMajorVersionNumber();


            /// Run.
            var output = Instances.VersionOperator.Choose_HighestSubVersionOf(
                versions,
                majorVersion);

            Console.WriteLine(output);
        }

        public void Get_VersionNameFromVersion()
        {
            /// Inputs.
            var version = Instances.ExampleVersions.V5_0_0;


            /// Run.
            var versionName = Instances.VersionOperator.ToVersionName(version);

            Console.WriteLine($"{version} => {versionName}");
        }

        /// <summary>
        /// Given a version name, get a version.
        /// </summary>
        public void Get_VersionFromVersionName()
        {
            /// Inputs.
            var versionName = Instances.ExampleVersionNames.V5_0_0;


            /// Run.
            var version = Instances.VersionOperator.From(versionName);

            Console.WriteLine($"{versionName} => {version}");
        }
    }
}
