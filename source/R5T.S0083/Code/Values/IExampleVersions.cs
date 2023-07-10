using System;

using R5T.T0131;


namespace R5T.S0083
{
    [ValuesMarker]
    public partial interface IExampleVersions : IValuesMarker
    {
        /// <inheritdoc cref="IExampleVersionNames.V3_1_0"/>
        public Version V3_1_0 => Instances.VersionOperator.From(
            Instances.ExampleVersionNames.V3_1_0);

        /// <inheritdoc cref="IExampleVersionNames.V5_0_0"/>
        public Version V5_0_0 => Instances.VersionOperator.From(
            Instances.ExampleVersionNames.V5_0_0);

        /// <inheritdoc cref="IExampleVersionNames.V6_0_11"/>
        public Version V6_0_11 => Instances.VersionOperator.From(
            Instances.ExampleVersionNames.V6_0_11);

        /// <inheritdoc cref="IExampleVersionNames.V6_0_18"/>
        public Version V6_0_18 => Instances.VersionOperator.From(
            Instances.ExampleVersionNames.V6_0_18);

        /// <inheritdoc cref="IExampleVersionNames.V7_0_0"/>
        public Version V7_0_0 => Instances.VersionOperator.From(
            Instances.ExampleVersionNames.V7_0_0);
    }
}
