using System;


namespace R5T.S0083
{
    public class ExampleVersions : IExampleVersions
    {
        #region Infrastructure

        public static IExampleVersions Instance { get; } = new ExampleVersions();


        private ExampleVersions()
        {
        }

        #endregion
    }
}
