using kodai100.CA.Adapters.Controllers;
using kodai100.CA.Adapters.Presenter;
using kodai100.CA.Adapters.Repository;
using kodai100.CA.Data.DataStore;
using kodai100.CA.Domain.UseCase;
using Zenject;

namespace kodai100.CA.Installers
{
    public class CleanArchitectureInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {

            Container.Bind<IVolumeDataStore>().To<VolumePlayerPrefsDataStore>().AsSingle();
            Container.Bind<IVolumePresenter>().To<VolumePresenter>().AsSingle();
            Container.Bind<IVolumeRepository>().To<VolumeRepository>().AsSingle();
            Container.Bind<IVolumeUseCase>().To<VolumeUseCase>().AsSingle();
            
            Container.Bind<VolumeController>().AsSingle().NonLazy();

        }
    }
    
}