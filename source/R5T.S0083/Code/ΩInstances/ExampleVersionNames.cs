using System;


namespace R5T.S0083
{
    public class ExampleVersionNames : IExampleVersionNames
    {
        #region Infrastructure

        public static IExampleVersionNames Instance { get; } = new ExampleVersionNames();


        private ExampleVersionNames()
        {
        }

        #endregion
    }
}
