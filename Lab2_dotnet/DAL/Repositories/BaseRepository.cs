namespace Lab2_dotnet.DAL.Repositories
{
	public class BaseRepository
	{
		protected readonly string filePath;
		public BaseRepository(string filePath)
		{
			this.filePath = filePath;
		}
	}
}
