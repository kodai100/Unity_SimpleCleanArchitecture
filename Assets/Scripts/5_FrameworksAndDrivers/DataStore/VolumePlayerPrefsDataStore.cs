using kodai100.CA.Infrastructure;
using UnityEngine;

namespace kodai100.CA.Data.DataStore
{
    
    public class VolumePlayerPrefsDataStore : IVolumeDataStore
    {
        public void Save(int value)
        {
            PlayerPrefs.SetInt("volume", value);
            MyLogger.Log($"Saved : {value}");
        }

        public int Load()
        {
            var value =  PlayerPrefs.GetInt("volume", 50);
            MyLogger.Log($"Loaded : {value}");
            return value;
        }
    }

}