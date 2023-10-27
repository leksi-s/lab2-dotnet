using Lab2_dotnet.BLL.IServices;
using Lab2_dotnet.ClassesOfData;
using Lab2_dotnet.DAL.Repositories;

namespace Lab2_dotnet.BLL.Services
{
	internal class FilmService : IFilmService
	{
		private readonly FilmRepository _repository;
		public FilmService(FilmRepository repository)
		{
			_repository = repository;
		}
		public void Add(Film film)
		{
			_repository.Add(film);
		}
	}
}
