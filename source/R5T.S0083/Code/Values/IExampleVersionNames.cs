using System;

using R5T.T0131;
using R5T.T0185;
using R5T.T0185.Extensions;


namespace R5T.S0083
{
    [ValuesMarker]
    public partial interface IExampleVersionNames : IValuesMarker
    {
        /// <summary>
        /// "3.0"
        /// </summary>
        public IVersionName V3_0 => "3.0".ToVersionName();

        /// <summary>
        /// "3.1.0"
        /// </summary>
        public IVersionName V3_1_0 => "3.1.0".ToVersionName();

        /// <summary>
        /// "5.0.0"
        /// </summary>
        public IVersionName V5_0_0 => "5.0.0".ToVersionName();

        /// <summary>
        /// "6.0.11"
        /// </summary>
        public IVersionName V6_0_11 => "6.0.11".ToVersionName();

        /// <summary>
        /// "6.0.18"
        /// </summary>
        public IVersionName V6_0_18 => "6.0.18".ToVersionName();

        /// <summary>
        /// "7.0.0"
        /// </summary>
        public IVersionName V7_0_0 => "7.0.0".ToVersionName();
    }
}
