using Lab2_dotnet.AdditionalClassesOfData;
using Lab2_dotnet.DAL.Util;
using System.Xml;

namespace Lab2_dotnet.DAL.Repositories
{
	internal class ActorToFilmRepository : BaseRepository
	{
		public ActorToFilmRepository(string filePath) : base(filePath)
		{
		}

		public void Add(ActorToFilm actorToFilm)
		{
			var doc = new XmlDocument();
			doc.Load(filePath);

			var importedActor = doc.ImportNode(actorToFilm.ToXmlElement<ActorToFilm>(), true);
			doc.DocumentElement!.AppendChild(importedActor);

			doc.Save(filePath);
		}
	}
}
