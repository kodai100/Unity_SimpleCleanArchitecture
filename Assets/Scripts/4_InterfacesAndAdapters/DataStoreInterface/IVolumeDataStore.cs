namespace kodai100.CA.Data.DataStore
{
    public interface IVolumeDataStore
    {
        void Save(int value);
        int Load();
    }

}