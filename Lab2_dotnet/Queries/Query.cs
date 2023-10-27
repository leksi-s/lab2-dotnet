using System.Xml.Linq;

namespace Lab2_dotnet.Queries
{
	internal class Query : IQuery
	{
		private readonly string _outputFilePath;
		readonly XDocument doc;

		public Query(string outputPath)
		{
			_outputFilePath = outputPath;
			doc = XDocument.Load(_outputFilePath);
		}

		public IEnumerable<XElement> GetActorsWithIdMoreThanX(int x)//1. get actors with id more than {x}
		{
			var actor = doc.Element("Root")?.Elements("Actor");
			return from q in actor!.Where(a => int.TryParse(a.Element("Id")?.Value, out int actorId) && actorId > x)
				   select q;
		}

		public IEnumerable<string> GetOnlyFullName()//2. get only actor's full name
		{
			return doc.Descendants("FullName").Select(fn => fn.Value);
		}

		public IEnumerable<XElement> GetFilmsThatStartWithX(char x)//3. get films that starts with {x}
		{
			return from film in doc.Element("Root")?.Elements("Film")
				   where film.Element("NameOfFilm")?.Value?.StartsWith(x) == true
				   select film;
		}

		public IEnumerable<object> GetFilmsWhichDirectorIsActor()//4. get films where director is an actor
		{
			return from films in doc.Element("Root")?.Elements("Film")
				   join actors in doc.Element("Root")?.Elements("Actor")! on films.Element("Producer")?.Value equals actors.Element("FullName")?.Value
				   select new { actors.Element("FullName")?.Value };
		}

		public IEnumerable<XElement> GetAllFilms()//5. get all the films
		{
			return from films in doc.Element("Root")?.Elements("Film")
				   select films;
		}

		public IEnumerable<XElement> GetSpectaclesSorted()// 6. output spectacles sorted by alphabet
		{
			return doc.Element("Root")?.Elements("Spectacle")
				.OrderBy(spectacle => spectacle.Element("NameOfSpectacle")?.Value)
				.Select(spectacle => spectacle)!;
		}

		public IEnumerable<object> GetNumberOfFilmsOfActors()// 7. output number of films of all actors
		{
			var query = from aTf in doc.Element("Root")?.Elements("ActorToFilm")!
						join actor in doc.Element("Root")?.Elements("Actor")! on (string)aTf.Element("ActorId")! equals (string)actor.Element("Id")!
						group aTf by actor into g
						select new
						{
							Actor = (string)g.Key.Element("FullName")!,
							NumOfFilms = g.Count()
						};

			return query.ToList();
		}

		public IEnumerable<XElement> GetSpectaclesReversed()//8. output spectacles list reversed
		{
			return from spectacle in doc.Element("Root")?.Elements("Spectacle")!.Reverse()
				   select spectacle;
		}

		public int GetMostFrequentYear()//9. output the most frequent year for films publishing
		{
			var mostFrequentYear = doc.Element("Root")?.Elements("Film")
								  .GroupBy(film => film.Element("YearOfRelease")?.Value)
								  .OrderByDescending(group => group.Count())
								  .Select(group => group.Key)
								  .FirstOrDefault();

			return int.Parse(mostFrequentYear!);
		}

		public IEnumerable<XElement> GetActorsWithoutOneAmplua(string amplua)//10. output actors without ones, who has {n} amplua
		{
			return from actor in doc.Element("Root")?.Elements("Actor")!.
				   Where(actor => actor.Element("Amplua")!.Value!.Equals(amplua))
				   select actor;
		}

		public IEnumerable<XElement> GetSpectaclesTakeWhile(string genre)//11. usage of takewhile, list stops when n genre appears
		{
			return from spectacle in doc.Element("Root")?.Elements("Spectacle")!.
				   TakeWhile(spectacle => spectacle.Element("Genre")!.Value != genre)
				   select spectacle;
		}

		public IEnumerable<XElement> GetFirstNLines(int n)//12. usage of take, takes only n first lines
		{
			return from aTs in doc.Element("Root")?.Elements("ActorToSpectacle")!.Take(n)
				   select aTs;
		}

		public IEnumerable<XElement> GetActorsByAgeRising()//13. output all actors by age rising 
		{
			return doc.Element("Root")?.Elements("Actor")
		   .OrderBy(actor => DateTime.Parse(actor.Element("DateOfBirth")?.Value!))
		   .Select(actor => actor)!;

		}

		public IEnumerable<object> GetActorsFromOneFilm() //14. output all the actors from one film
		{
			var query = from actToFilm in doc.Element("Root")?.Elements("ActorToFilm")!
						where int.Parse(actToFilm.Element("FilmId")!.Value) == 1
						join act in doc.Element("Root")?.Elements("Actor")! on (string)actToFilm.Element("ActorId")! equals (string)act.Element("Id")!
						select (string)act.Element("FullName")!;

			return query.ToList();
		}

		public int GetAmountOfSpectaclesWithOneGenre(string genre)//15. output amount of spectacles with n genre
		{
			var count = doc.Element("Root")?.Elements("Spectacle")!
				.Count(s => s.Element("Genre")?.Value == genre) ?? 0;

			return count;
		}
	}
}
