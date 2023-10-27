namespace Lab2_dotnet.ClassesOfData
{
	public class Film
	{
		private static int lastId = 0;
		public int Id { get; set; }
		public string? NameOfFilm { get; set; }
		public int YearOfRelease { get; set; }
		public string? Genre { get; set; }
		public string? Producer { get; set; }

		public Film(string name, int year, string genre, string producer)
		{
			lastId++;
			Id = lastId;
			this.NameOfFilm = name;
			this.YearOfRelease = year;
			this.Genre = genre;
			this.Producer = producer;
		}

		public Film() { }

		public override string ToString()
		{
			return string.Format($"{Id};  {NameOfFilm};  {YearOfRelease};  {Genre};  {Producer};");
		}
	}
}
