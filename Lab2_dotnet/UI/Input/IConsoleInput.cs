using Lab2_dotnet.BLL.IServices;

namespace Lab2_dotnet.UI.Input
{
	internal interface IConsoleInput
	{
		void InputActor(IActorService actorService);
		void InputFilm(IFilmService filmService);
		void InputSpectacle(ISpectacleService spectacleService);
		void InputActorToSpectacle(IActorToSpectacleService actorToSpectacleService);
		void InputActorToFilm(IActorToFilmService actorToFilmService);
	}
}
