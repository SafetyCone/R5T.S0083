using System;


namespace R5T.S0083
{
    public class VersionExperiments : IVersionExperiments
    {
        #region Infrastructure

        public static IVersionExperiments Instance { get; } = new VersionExperiments();


        private VersionExperiments()
        {
        }

        #endregion
    }
}
