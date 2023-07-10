using System;


namespace R5T.S0083
{
    public class PathologicalVersionNames : IPathologicalVersionNames
    {
        #region Infrastructure

        public static IPathologicalVersionNames Instance { get; } = new PathologicalVersionNames();


        private PathologicalVersionNames()
        {
        }

        #endregion
    }
}
