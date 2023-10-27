using Lab2_dotnet.AdditionalClassesOfData;
using Lab2_dotnet.BLL.IServices;
using Lab2_dotnet.DAL.Repositories;

namespace Lab2_dotnet.BLL.Services
{
	internal class ActorToFilmService : IActorToFilmService
	{
		private readonly ActorToFilmRepository _repository;
		private readonly FilmRepository _filmRepository;
		private readonly ActorRepository _actorRepository;
		public ActorToFilmService(ActorToFilmRepository repository, string filePath)
		{
			_repository = repository;
			_filmRepository = new FilmRepository(filePath);
			_actorRepository = new ActorRepository(filePath);
		}
		public void Add(ActorToFilm actorToFilm)
		{
			List<int> actorIds = _actorRepository.GetById();
			List<int> filmIds = _filmRepository.GetById();
			bool actorExists = actorIds.Contains(actorToFilm.ActorId);
			bool filmExists = filmIds.Contains(actorToFilm.FilmId);

			if (actorExists && filmExists)
			{
				_repository.Add(actorToFilm);
			}

			else
			{
				throw new Exception();
			}
		}
	}
}
