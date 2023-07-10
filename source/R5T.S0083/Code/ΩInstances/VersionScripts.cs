using System;


namespace R5T.S0083
{
    public class VersionScripts : IVersionScripts
    {
        #region Infrastructure

        public static IVersionScripts Instance { get; } = new VersionScripts();


        private VersionScripts()
        {
        }

        #endregion
    }
}
