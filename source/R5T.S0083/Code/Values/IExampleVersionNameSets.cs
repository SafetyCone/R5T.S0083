using System;

using R5T.T0131;
using R5T.T0185;


namespace R5T.S0083
{
    [ValuesMarker]
    public partial interface IExampleVersionNameSets : IValuesMarker
    {
        public IVersionName[] N_001 => new[]
        {
            Instances.ExampleVersionNames.V3_1_0,
            Instances.ExampleVersionNames.V5_0_0,
            Instances.ExampleVersionNames.V6_0_11,
            Instances.ExampleVersionNames.V6_0_18,
            Instances.ExampleVersionNames.V7_0_0,
        };
    }
}
