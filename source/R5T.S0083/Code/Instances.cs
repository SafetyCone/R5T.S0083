using System;


namespace R5T.S0083
{
    public static class Instances
    {
        public static IExampleVersionNames ExampleVersionNames => S0083.ExampleVersionNames.Instance;
        public static IExampleVersions ExampleVersions => S0083.ExampleVersions.Instance;
        public static IExampleVersionSets ExampleVersionSets => S0083.ExampleVersionSets.Instance;
        public static IPathologicalVersionNames PathologicalVersionNames => S0083.PathologicalVersionNames.Instance;
        public static L0035.IVersionOperator VersionOperator => L0035.VersionOperator.Instance;
    }
}