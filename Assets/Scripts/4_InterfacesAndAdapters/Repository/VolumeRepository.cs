using kodai100.CA.Data.DataStore;
using kodai100.CA.Domain.OutputData;

namespace kodai100.CA.Adapters.Repository
{
    public class VolumeRepository : IVolumeRepository
    {

        private IVolumeDataStore dataStore;
        
        public VolumeRepository(IVolumeDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public void Save(VolumeOutputData volumeData)
        {
            dataStore.Save(volumeData.value);
        }

        public VolumeOutputData Load()
        {
            return new VolumeOutputData(dataStore.Load());
        }
        
    }

}