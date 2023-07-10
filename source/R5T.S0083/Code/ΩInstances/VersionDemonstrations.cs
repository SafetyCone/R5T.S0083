using System;


namespace R5T.S0083
{
    public class VersionDemonstrations : IVersionDemonstrations
    {
        #region Infrastructure

        public static IVersionDemonstrations Instance { get; } = new VersionDemonstrations();


        private VersionDemonstrations()
        {
        }

        #endregion
    }
}
