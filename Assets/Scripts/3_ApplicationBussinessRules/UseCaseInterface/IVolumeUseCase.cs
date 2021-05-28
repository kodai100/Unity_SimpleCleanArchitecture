namespace kodai100.CA.Domain.UseCase
{

    public interface IVolumeUseCase
    {
        void VolumeUp();
        void VolumeDown();
        
        void Save();
        int Load();
    }

}