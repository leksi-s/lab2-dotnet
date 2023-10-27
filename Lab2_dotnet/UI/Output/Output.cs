using Lab2_dotnet.Queries;

namespace Lab2_dotnet.UI.Output
{
	internal class Output : IOutput
	{
		private readonly IQuery _queries;
		public Output(string outputPath)
		{
			_queries = new Query(outputPath);
		}
		public static void OutputItems<T>(IEnumerable<T> q)
		{
			foreach (var item in q)
				Console.WriteLine(item);
		}

		public void GetActorsWithIdMoreThanX_Output(int x)
		{
			Console.WriteLine();
			Console.WriteLine("1. get actors with id more than {x}");
			var q = _queries.GetActorsWithIdMoreThanX(x);
			OutputItems(q);
		}

		public void GetOnlyFullName_Output()
		{
			Console.WriteLine();
			Console.WriteLine("2. get only actor's full name");
			var q = _queries.GetOnlyFullName();
			OutputItems(q);
		}

		public void GetFilmsThatStartWithX_Output(char x)
		{
			Console.WriteLine();
			Console.WriteLine("3. get films that starts with {x}");
			var q = _queries.GetFilmsThatStartWithX(x);
			OutputItems(q);
		}

		public void GetFilmsWhichDirectorIsActor_Output()
		{
			Console.WriteLine();
			Console.WriteLine("4. get films where director is an actor");
			var q = _queries.GetFilmsWhichDirectorIsActor();
			OutputItems(q);
		}

		public void GetAllFilms_Output()
		{
			Console.WriteLine();
			Console.WriteLine("5. get all the films");
			var q = _queries.GetAllFilms();
			OutputItems(q);
		}

		public void GetSpectaclesSorted_Output()
		{
			Console.WriteLine();
			Console.WriteLine("6. output spectacles sorted by alphabet");
			var q = _queries.GetSpectaclesSorted();
			OutputItems(q);
		}

		public void GetNumberOfFilmsOfActors_Output()
		{
			Console.WriteLine();
			Console.WriteLine("7. output number of films of all actors");
			var q = _queries.GetNumberOfFilmsOfActors();
			OutputItems(q);
		}

		public void GetSpectaclesReversed_Output()
		{
			Console.WriteLine();
			Console.WriteLine("8. output spectacles list reversed");
			var q = _queries.GetSpectaclesReversed();
			OutputItems(q);
		}

		public void GetMostFrequentYear_Output()
		{
			Console.WriteLine();
			Console.WriteLine("9. output the most frequent year for films publishing");
			var q = _queries.GetMostFrequentYear();
			Console.WriteLine(q);
		}

		public void GetActorsWithoutOneAmplua_Output(string amplua)
		{
			Console.WriteLine();
			Console.WriteLine("10. output actors without ones, who has {n} amplua");
			var q = _queries.GetActorsWithoutOneAmplua(amplua);
			OutputItems(q);
		}

		public void GetSpectaclesTakeWhile_Output(string genre)
		{
			Console.WriteLine();
			Console.WriteLine("11. usage of takewhile, list stops when n genre appears");
			var q = _queries.GetSpectaclesTakeWhile(genre);
			OutputItems(q);
		}

		public void GetFirstNLines_Output(int n)
		{
			Console.WriteLine();
			Console.WriteLine("12. usage of take, takes only n first lines");
			var q = _queries.GetFirstNLines(n);
			OutputItems(q);
		}

		public void GetActorsByAgeRising_Output()
		{
			Console.WriteLine();
			Console.WriteLine("13. output all actors by age rising");
			var q = _queries.GetActorsByAgeRising();
			OutputItems(q);
		}

		public void GetActorsFromOneFilm_Output()
		{
			Console.WriteLine();
			Console.WriteLine("14. output all the actors from one film");
			var q = _queries.GetActorsFromOneFilm();
			OutputItems(q);
		}

		public void GetAmountOfSpectaclesWithOneGenre_Output(string genre)
		{
			Console.WriteLine();
			Console.WriteLine("15. output amount of spectacles with n genre");
			var q = _queries.GetAmountOfSpectaclesWithOneGenre(genre);
			Console.WriteLine(q);
		}


	}
}
