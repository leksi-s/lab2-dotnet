using Lab2_dotnet.BLL.AdditionalClassesOfData;
using Lab2_dotnet.DAL.Util;
using System.Xml;

namespace Lab2_dotnet.DAL.Repositories
{
	internal class ActorToSpectacleRepository : BaseRepository
	{
		public ActorToSpectacleRepository(string filePath) : base(filePath)
		{
		}

		public void Add(ActorToSpectacle actorToSpectacle)
		{

			var doc = new XmlDocument();
			doc.Load(filePath);

			var importedActorToSpectacle = doc.ImportNode(actorToSpectacle.ToXmlElement<ActorToSpectacle>(), true);
			doc.DocumentElement!.AppendChild(importedActorToSpectacle);

			doc.Save(filePath);
		}
	}
}
