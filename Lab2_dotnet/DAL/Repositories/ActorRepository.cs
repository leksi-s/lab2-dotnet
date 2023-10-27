using Lab2_dotnet.ClassesOfData;
using Lab2_dotnet.DAL.Util;
using System.Xml;

namespace Lab2_dotnet.DAL.Repositories
{
	internal class ActorRepository : BaseRepository
	{
		public ActorRepository(string filePath) : base(filePath)
		{
		}

		public void Add(Actor actor)
		{
			var doc = new XmlDocument();
			doc.Load(filePath);

			var importedActor = doc.ImportNode(actor.ToXmlElement<Actor>(), true);
			doc.DocumentElement!.AppendChild(importedActor);

			doc.Save(filePath);
		}

		public List<int> GetById()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(filePath);

			List<int> actorIds = new();

			XmlNodeList elements = xmlDocument.SelectNodes("//Actor[Id]")!;

			foreach (XmlNode element in elements)
			{
				int actorId = int.Parse(element.SelectSingleNode("Id")!.InnerText);
				actorIds.Add(actorId);
			}

			return actorIds;
		}
	}
}
