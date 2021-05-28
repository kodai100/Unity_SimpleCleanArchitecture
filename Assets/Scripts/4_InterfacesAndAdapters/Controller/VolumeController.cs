using System.Linq;
using kodai100.CA.Domain.UseCase;
using kodai100.CA.View.UIComponents;
using UnityEngine;

namespace kodai100.CA.Adapters.Controllers
{

    public class VolumeController
    {

        private VolumeController(IVolumeUseCase useCase)
        {
            Object.FindObjectsOfType<MonoBehaviour>().OfType<IVolumeDownUI>().ToList().ForEach(downUI =>
            {
                downUI.AddClickHandler(useCase.VolumeDown);
            });
            
            Object.FindObjectsOfType<MonoBehaviour>().OfType<IVolumeUpUI>().ToList().ForEach(downUI =>
            {
                downUI.AddClickHandler(useCase.VolumeUp);
            });
            
            Object.FindObjectsOfType<MonoBehaviour>().OfType<IVolumeSaveUI>().ToList().ForEach(downUI =>
            {
                downUI.AddClickHandler(useCase.Save);
            });
        }
        
    }
    
}