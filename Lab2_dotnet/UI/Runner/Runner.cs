using Lab2_dotnet.BLL.IServices;
using Lab2_dotnet.BLL.Services;
using Lab2_dotnet.DAL.Repositories;
using Lab2_dotnet.UI.Input;
using Lab2_dotnet.UI.Output;
using System.Xml;

namespace Lab2_dotnet.UI.Runner
{
	internal class Runner : IRunner
	{
		private bool _isTrue = true;
		private int x;
		private static string _path = "C:\\Users\\Admin\\source\\repos\\Lab2_dotnet\\Lab2_dotnet\\XMLs\\WriteData.xml";
		public void Run()
		{
			_ = new XmlWriterSettings()
			{
				Indent = true,
				WriteEndDocumentOnClose = true,

			};

			ActorRepository actorRepository = new ActorRepository(_path);
			IActorService actorService = new ActorService(actorRepository);

			FilmRepository filmRepository = new FilmRepository(_path);
			IFilmService filmService = new FilmService(filmRepository);

			SpectacleRepository spectacleRepository = new SpectacleRepository(_path);
			ISpectacleService spectacleService = new SpectacleService(spectacleRepository);

			ActorToFilmRepository actorToFilmRepository = new ActorToFilmRepository(_path);
			IActorToFilmService actorToFilmService = new ActorToFilmService(actorToFilmRepository, _path);

			ActorToSpectacleRepository actorToSpectacleRepository = new ActorToSpectacleRepository(_path);
			IActorToSpectacleService actorToSpectacleService = new ActorToSpectacleService(actorToSpectacleRepository, _path);

			IConsoleInput consoleInput = new ConsoleInput();

			do
			{
				Console.WriteLine("what do you want to do?\n1. exit\n2. add actor\n3. add film\n4. add spectacle\n5. add actor to film\n6. add actor to spectacle");
				x = int.Parse(Console.ReadLine()!);
				switch (x)
				{
					case 1:
						_isTrue = false;
						break;
					case 2:
						consoleInput.InputActor(actorService);
						break;
					case 3:
						consoleInput.InputFilm(filmService);
						break;
					case 4:
						consoleInput.InputSpectacle(spectacleService);
						break;
					case 5:
						consoleInput.InputActorToFilm(actorToFilmService);
						break;
					case 6:
						consoleInput.InputActorToSpectacle(actorToSpectacleService);
						break;
				}
			} while (_isTrue);

			IOutput output = new Output.Output("C:\\Users\\Admin\\source\\repos\\Lab2_dotnet\\Lab2_dotnet\\XMLs\\WriteData.xml");
			output.GetActorsWithIdMoreThanX_Output(1);
			output.GetOnlyFullName_Output();
			output.GetFilmsThatStartWithX_Output('Д');
			output.GetFilmsWhichDirectorIsActor_Output();
			output.GetAllFilms_Output();
			output.GetSpectaclesSorted_Output();
			output.GetNumberOfFilmsOfActors_Output();
			output.GetSpectaclesReversed_Output();
			output.GetMostFrequentYear_Output();
			output.GetActorsWithoutOneAmplua_Output("амплуа3");
			output.GetSpectaclesTakeWhile_Output("пригодницькi");
			output.GetFirstNLines_Output(3);
			output.GetActorsByAgeRising_Output();
			output.GetActorsFromOneFilm_Output();
			output.GetAmountOfSpectaclesWithOneGenre_Output("лiричнi");

		}
	}
}
