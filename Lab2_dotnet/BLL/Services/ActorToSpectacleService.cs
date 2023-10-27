
using Lab2_dotnet.BLL.AdditionalClassesOfData;
using Lab2_dotnet.BLL.IServices;
using Lab2_dotnet.DAL.Repositories;

namespace Lab2_dotnet.BLL.Services
{
	internal class ActorToSpectacleService : IActorToSpectacleService
	{
		private readonly ActorToSpectacleRepository _repository;
		private readonly SpectacleRepository _spectacleRepository;
		private readonly ActorRepository _actorRepository;
		public ActorToSpectacleService(ActorToSpectacleRepository repository, string filePath)
		{
			_repository = repository;
			_spectacleRepository = new SpectacleRepository(filePath);
			_actorRepository = new ActorRepository(filePath);
		}
		public void Add(ActorToSpectacle actorToSpectacle)
		{

			List<int> actorIds = _actorRepository.GetById();
			List<int> spectacleIds = _spectacleRepository.GetById();
			bool actorExists = actorIds.Contains(actorToSpectacle.ActorId);
			bool spectacleExists = spectacleIds.Contains(actorToSpectacle.SpectacleId);

			if (actorExists == true && spectacleExists == true)
			{
				_repository.Add(actorToSpectacle);
			}

			else
			{
				return;
			}
		}
	}
}
