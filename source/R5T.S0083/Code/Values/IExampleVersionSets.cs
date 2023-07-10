using System;

using R5T.T0131;


namespace R5T.S0083
{
    [ValuesMarker]
    public partial interface IExampleVersionSets : IValuesMarker
    {
        public Version[] N_001 => new[]
        {
            Instances.ExampleVersions.V3_1_0,
            Instances.ExampleVersions.V5_0_0,
            Instances.ExampleVersions.V6_0_11,
            Instances.ExampleVersions.V6_0_18,
            Instances.ExampleVersions.V7_0_0,
        };
    }
}
