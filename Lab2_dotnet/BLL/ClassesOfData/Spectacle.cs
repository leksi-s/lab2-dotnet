namespace Lab2_dotnet.BLL.ClassesOfData
{
	public class Spectacle
	{
		private static int lastId = 0;
		public int Id { get; set; }
		public string? NameOfSpectacle { get; set; }
		public string? Genre { get; set; }
		public Spectacle(string name, string genre)
		{
			lastId++;
			Id = lastId;
			this.NameOfSpectacle = name;
			this.Genre = genre;
		}
		public Spectacle() { }

		public override string ToString()
		{
			return string.Format($"{Id};  {NameOfSpectacle};  {Genre};");
		}
	}
}
