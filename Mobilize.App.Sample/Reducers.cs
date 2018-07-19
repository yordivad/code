// ***********************************************************************
// <copyright file="Reducers.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample
{
    using Mobilize.App.Sample.State;

    using Redux;

    /// <summary>
    /// Class Reducers.
    /// </summary>
    public static class Reducers
    {
        /// <summary>
        /// Reduces the application.
        /// </summary>
        /// <param name="previous">The previous.</param>
        /// <param name="action">The action.</param>
        /// <returns>The SampleState.</returns>
        public static SampleState ReduceApplication(SampleState previous, IAction action)
        {
            return new SampleState();
        }
    }
}