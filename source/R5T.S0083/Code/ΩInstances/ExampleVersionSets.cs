using System;


namespace R5T.S0083
{
    public class ExampleVersionSets : IExampleVersionSets
    {
        #region Infrastructure

        public static IExampleVersionSets Instance { get; } = new ExampleVersionSets();


        private ExampleVersionSets()
        {
        }

        #endregion
    }
}
