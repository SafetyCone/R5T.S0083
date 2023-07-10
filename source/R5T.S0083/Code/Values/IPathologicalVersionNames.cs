using System;

using R5T.T0131;
using R5T.T0185;
using R5T.T0185.Extensions;


namespace R5T.S0083
{
    [ValuesMarker]
    public partial interface IPathologicalVersionNames : IValuesMarker
    {
        /// <summary>
        /// "Apple"
        /// </summary>
        public IVersionName NotAVersion => "Apple".ToVersionName();

        /// <summary>
        /// "3.0.0.0.0"
        /// <para>Note: using <see cref="Version.Parse(string)"/> results in System.ArgumentException: 'Version string portion was too short or too long. (Parameter 'input')'</para>
        /// </summary>
        public IVersionName TooManyTokens => "3.0.0.0.0".ToVersionName();

        /// <summary>
        /// "3.0.00.0"
        /// <para>The <see cref="Version.Parse(string)"/> method has no issue with this value.</para>
        /// </summary>
        public IVersionName MultipleZeros_Two => "3.0.00.0".ToVersionName();

        /// <summary>
        /// "3"
        /// <para>Note: using <see cref="Version.Parse(string)"/> results in System.ArgumentException: 'Version string portion was too short or too long. (Parameter 'input')'</para>
        /// </summary>
        public IVersionName SingleDigit => "3".ToVersionName();

        /// <summary>
        /// "3."
        /// <para>Note: using <see cref="Version.Parse(string)"/> results in System.FormatException: 'Input string was not in a correct format.'</para>
        /// </summary>
        public IVersionName SingleDigit_WithDot => "3.".ToVersionName();
    }
}
