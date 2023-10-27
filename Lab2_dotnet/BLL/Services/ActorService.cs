using Lab2_dotnet.BLL.IServices;
using Lab2_dotnet.ClassesOfData;
using Lab2_dotnet.DAL.Repositories;

namespace Lab2_dotnet.BLL.Services
{
	internal class ActorService : IActorService
	{
		private readonly ActorRepository _repository;
		public ActorService(ActorRepository repository)
		{
			_repository = repository;
		}

		public void Add(Actor actor)
		{
			_repository.Add(actor);
		}
	}
}
