// ***********************************************************************
// <copyright file="ISampleStore.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.State
{
    using Redux;

    /// <summary>
    /// Interface ISampleStore
    /// </summary>
    public interface ISampleStore
    {
        /// <summary>
        /// Gets the State
        /// Gets or sets the store.
        /// </summary>
        IStore<SampleState> State { get; }
    }
}