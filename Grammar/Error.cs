// ***********************************************************************
// <copyright file="Error.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar
{
    /// <summary>
    /// The error class
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Gets the character line.
        /// </summary>
        /// <value>The character line.</value>
        public int CharLine { get; internal set; }

        /// <summary>
        /// Gets the line.
        /// </summary>
        /// <value>The line.</value>
        public int Line { get; internal set; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; internal set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>The source.</value>
        public string Source { get; internal set; }
    }
}