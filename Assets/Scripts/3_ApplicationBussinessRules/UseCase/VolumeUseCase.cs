using kodai100.CA.Adapters.Presenter;
using kodai100.CA.Adapters.Repository;
using kodai100.CA.Domain.Entities;
using kodai100.CA.Domain.OutputData;

namespace kodai100.CA.Domain.UseCase
{

    public class VolumeUseCase : IVolumeUseCase
    {

        private IVolumePresenter _presenter;
        private IVolumeRepository _repository;

        private VolumeEntity _entity;
        
        public VolumeUseCase(IVolumePresenter presenter, IVolumeRepository repository)
        {
            _presenter = presenter;
            _repository = repository;

            Load();
        }
        
        public void VolumeUp()
        {
            _entity.VolumeUp();
            _presenter.SetVolume(new VolumeOutputData(_entity.VolumeData));
        }

        public void VolumeDown()
        {
            _entity.VolumeDown();
            _presenter.SetVolume(new VolumeOutputData(_entity.VolumeData));
        }

        public void Save()
        {
            _repository.Save(new VolumeOutputData(_entity.VolumeData));
        }

        public int Load()
        {
            _entity = new VolumeEntity(_repository.Load().value);
            _presenter.SetVolume(new VolumeOutputData(_entity.VolumeData));
            return _entity.VolumeData;
        }
    }

}