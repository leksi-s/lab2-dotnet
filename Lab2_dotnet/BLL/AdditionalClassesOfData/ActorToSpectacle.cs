namespace Lab2_dotnet.BLL.AdditionalClassesOfData
{
	public class ActorToSpectacle
	{
		public int ActorId { get; set; }
		public int SpectacleId { get; set; }

		public ActorToSpectacle(int actorId, int spectacleId)
		{
			ActorId = actorId;
			SpectacleId = spectacleId;
		}
		public ActorToSpectacle()
		{

		}

		public override string ToString()
		{
			return string.Format($"{ActorId}; {SpectacleId};");
		}
	}
}
