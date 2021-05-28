using kodai100.CA.Domain.OutputData;

namespace kodai100.CA.Adapters.Repository
{
    public interface IVolumeRepository
    {
        void Save(VolumeOutputData value);
        VolumeOutputData Load();
    }

}
