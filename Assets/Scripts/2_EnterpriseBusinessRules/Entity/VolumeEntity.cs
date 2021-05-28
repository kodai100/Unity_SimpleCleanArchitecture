using UnityEngine;

namespace kodai100.CA.Domain.Entities
{

    public class VolumeEntity
    {
        public int VolumeData
        {
            get => _volumeData;
            set => _volumeData = Validate(value);
        }

        private int _volumeData;
        
        private const int Step = 10;
        private const int MinVolume = 0;
        private const int MaxVolume = 100;

        public VolumeEntity(int initialVolume)
        {
            VolumeData = initialVolume;
        }
        
        public void VolumeUp()
        {
            VolumeData = Validate(VolumeData + Step);
        }

        public void VolumeDown()
        {
            VolumeData = Validate(VolumeData - Step);
        }

        private static int Validate(int value)
        {
            return Mathf.Clamp(value, MinVolume, MaxVolume);
        }
        
    }

}