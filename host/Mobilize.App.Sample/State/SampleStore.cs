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
    public class SampleStore : ISampleStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStore"/> class.
        /// </summary>
        public SampleStore()
        {
            this.State = new Store<SampleState>(Reducers.ReduceApplication);
        }

        /// <summary>
        /// Gets the State
        /// Gets  the store.
        /// </summary>
        public IStore<SampleState> State { get; }
    }
}