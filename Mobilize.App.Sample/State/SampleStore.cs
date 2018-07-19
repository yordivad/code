// ***********************************************************************
// <copyright file="SampleStore.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.State
{
    using Redux;

    /// <summary>
    /// Class SampleStore.
    /// </summary>
    /// <seealso cref="Mobilize.App.Sample.State.ISampleStore" />
    public class SampleStore : ISampleStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStore"/> class.
        /// </summary>
        public SampleStore()
        {
            this.Store = new Store<SampleState>(Reducers.ReduceApplication);
        }

        /// <summary>
        /// Gets  the store.
        /// </summary>
        /// <value>The store.</value>
        public IStore<SampleState> Store { get; }
    }
}