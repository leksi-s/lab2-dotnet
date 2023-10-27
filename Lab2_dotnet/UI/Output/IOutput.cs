namespace Lab2_dotnet.UI.Output
{
	internal interface IOutput
	{
		void GetActorsWithIdMoreThanX_Output(int x);
		void GetOnlyFullName_Output();
		void GetFilmsThatStartWithX_Output(char x);
		void GetFilmsWhichDirectorIsActor_Output();
		void GetAllFilms_Output();
		void GetSpectaclesSorted_Output();
		void GetNumberOfFilmsOfActors_Output();
		void GetSpectaclesReversed_Output();
		void GetMostFrequentYear_Output();
		void GetActorsWithoutOneAmplua_Output(string amplua);
		void GetSpectaclesTakeWhile_Output(string genre);
		void GetFirstNLines_Output(int n);
		void GetActorsByAgeRising_Output();
		void GetActorsFromOneFilm_Output();
		void GetAmountOfSpectaclesWithOneGenre_Output(string genre);
	}
}
