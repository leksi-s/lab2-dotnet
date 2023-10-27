using System.Xml.Linq;

namespace Lab2_dotnet.Queries
{
	internal interface IQuery
	{
		IEnumerable<XElement> GetActorsWithIdMoreThanX(int x);
		IEnumerable<string> GetOnlyFullName();
		IEnumerable<XElement> GetFilmsThatStartWithX(char x);
		IEnumerable<object> GetFilmsWhichDirectorIsActor();
		IEnumerable<XElement> GetAllFilms();
		public IEnumerable<XElement> GetSpectaclesSorted();
		IEnumerable<object> GetNumberOfFilmsOfActors();
		IEnumerable<XElement> GetSpectaclesReversed();
		int GetMostFrequentYear();
		IEnumerable<XElement> GetActorsWithoutOneAmplua(string amplua);
		IEnumerable<XElement> GetSpectaclesTakeWhile(string genre);
		IEnumerable<XElement> GetFirstNLines(int n);
		IEnumerable<XElement> GetActorsByAgeRising();
		IEnumerable<object> GetActorsFromOneFilm();
		int GetAmountOfSpectaclesWithOneGenre(string genre);

	}
}
