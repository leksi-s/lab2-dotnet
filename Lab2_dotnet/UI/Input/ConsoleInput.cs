using Lab2_dotnet.AdditionalClassesOfData;
using Lab2_dotnet.BLL.AdditionalClassesOfData;
using Lab2_dotnet.BLL.ClassesOfData;
using Lab2_dotnet.BLL.IServices;
using Lab2_dotnet.ClassesOfData;

namespace Lab2_dotnet.UI.Input
{
	internal class ConsoleInput : IConsoleInput
	{
		public void InputActor(IActorService actorService)
		{
			Console.WriteLine("enter name:");
			string fullName = Console.ReadLine()!;
			Console.WriteLine("enter amplua:");
			string amplua = Console.ReadLine()!;
			Console.WriteLine("enter date of birth in format yyyy, mm, dd");
			DateOnly dateOfBirth = DateOnly.Parse(Console.ReadLine()!);
			Console.WriteLine("enter if this actor is producer in format 0/1");
			bool isProducer = bool.Parse(Console.ReadLine()!);

			Actor actor = new(fullName, amplua, dateOfBirth, isProducer);
			actorService.Add(actor);
		}

		public void InputActorToFilm(IActorToFilmService actorToFilmService)
		{
			Console.WriteLine("enter actor id:");
			int actorId = int.Parse(Console.ReadLine()!);
			Console.WriteLine("enter film id:");
			int filmId = int.Parse(Console.ReadLine()!);

			ActorToFilm actorToFilm = new(actorId, filmId);
			actorToFilmService.Add(actorToFilm);
		}

		public void InputActorToSpectacle(IActorToSpectacleService actorToSpectacleService)
		{
			Console.WriteLine("enter actor id:");
			int actorId = int.Parse(Console.ReadLine()!);
			Console.WriteLine("enter spectacle id:");
			int spectacleId = int.Parse(Console.ReadLine()!);

			ActorToSpectacle actorToSpectacle = new(actorId, spectacleId);
			actorToSpectacleService.Add(actorToSpectacle);
		}

		public void InputFilm(IFilmService filmService)
		{
			Console.WriteLine("enter name of film:");
			string nameOfFilm = Console.ReadLine()!;
			Console.WriteLine("enter year of release:");
			int year = int.Parse(Console.ReadLine()!);
			Console.WriteLine("enter genre");
			string genre = Console.ReadLine()!;
			Console.WriteLine("enter producer");
			string producer = Console.ReadLine()!;

			Film film = new(nameOfFilm, year, genre, producer);
			filmService.Add(film);
		}

		public void InputSpectacle(ISpectacleService spectacleService)
		{
			Console.WriteLine("enter name of spectacle:");
			string nameOfSpectacle = Console.ReadLine()!;
			Console.WriteLine("enter genre");
			string genre = Console.ReadLine()!;

			Spectacle spectacle = new(nameOfSpectacle, genre);
			spectacleService.Add(spectacle);
		}
	}
}
