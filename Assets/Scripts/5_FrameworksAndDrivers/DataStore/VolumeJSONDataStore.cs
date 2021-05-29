using System;
using System.IO;
using UnityEngine;

namespace kodai100.CA.Data.DataStore
{
    public class VolumeJSONDataStore : IVolumeDataStore
    {

        private class VolumeJsonData
        {
            public int Value;
        }

        private readonly string _path = Application.streamingAssetsPath + "/volume.json";
        
        public void Save(int value)
        {
            var data = new VolumeJsonData{ Value = value };
            var serialized = JsonUtility.ToJson(data);

            using var sw = new StreamWriter (_path, false);
            
            try
            {
                sw.Write(serialized);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }

        public int Load()
        {
            
            try
            {
                using var fs = new FileStream(_path, FileMode.OpenOrCreate);
                using var sr = new StreamReader(fs);
                
                var result = sr.ReadToEnd();
                    
                var deserialized =  JsonUtility.FromJson<VolumeJsonData>(result);
                
                return deserialized.Value;
            }
            catch (Exception e)
            {
                Debug.LogError("JSON load failed.");
                    
                return 50;
            }
            
        }
    }

}