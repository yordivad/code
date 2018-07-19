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
        /// Gets or sets the store.
        /// </summary>
        /// <value>The store.</value>
        IStore<SampleState> Store { get; }
    }
}