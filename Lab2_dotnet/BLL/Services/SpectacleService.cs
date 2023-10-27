using Lab2_dotnet.BLL.ClassesOfData;
using Lab2_dotnet.BLL.IServices;
using Lab2_dotnet.DAL.Repositories;

namespace Lab2_dotnet.BLL.Services
{
	internal class SpectacleService : ISpectacleService
	{
		private readonly SpectacleRepository _repository;
		public SpectacleService(SpectacleRepository repository)
		{
			_repository = repository;
		}
		public void Add(Spectacle spectacle)
		{
			_repository.Add(spectacle);
		}
	}
}
