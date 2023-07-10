using System;


namespace R5T.S0083
{
    public class ExampleVersionNameSets : IExampleVersionNameSets
    {
        #region Infrastructure

        public static IExampleVersionNameSets Instance { get; } = new ExampleVersionNameSets();


        private ExampleVersionNameSets()
        {
        }

        #endregion
    }
}
