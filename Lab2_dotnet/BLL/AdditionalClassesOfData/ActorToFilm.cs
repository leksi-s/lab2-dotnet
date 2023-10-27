namespace Lab2_dotnet.AdditionalClassesOfData
{
	public class ActorToFilm
	{
		public int ActorId { get; set; }
		public int FilmId { get; set; }

		public ActorToFilm(int actorId, int filmId)
		{
			ActorId = actorId;
			FilmId = filmId;
		}
		public ActorToFilm()
		{

		}

		public override string ToString()
		{
			return string.Format($"{ActorId}; {FilmId};");
		}
	}
}
