using System.Collections.Generic;
using System.Linq;
using kodai100.CA.Domain.OutputData;
using kodai100.CA.View.UIComponents;
using UnityEngine;

namespace kodai100.CA.Adapters.Presenter
{
    public class VolumePresenter : IVolumePresenter
    {

        private IEnumerable<IVolumeTextUI> volumeTextUIList;
        
        private VolumePresenter()
        {
            volumeTextUIList = Object.FindObjectsOfType<MonoBehaviour>().OfType<IVolumeTextUI>().ToList();
        }

        public void SetVolume(VolumeOutputData volume)
        {
            foreach (var ui in volumeTextUIList)
            {
                ui.Set(volume.value.ToString());
            }
        }
    }

}
