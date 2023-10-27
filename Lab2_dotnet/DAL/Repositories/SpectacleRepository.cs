using Lab2_dotnet.BLL.ClassesOfData;
using Lab2_dotnet.DAL.Util;
using System.Xml;

namespace Lab2_dotnet.DAL.Repositories
{
	internal class SpectacleRepository : BaseRepository
	{
		public SpectacleRepository(string filePath) : base(filePath)
		{
		}

		public void Add(Spectacle spectacle)
		{
			var doc = new XmlDocument();
			doc.Load(filePath);

			var importedSpectacle = doc.ImportNode(spectacle.ToXmlElement<Spectacle>(), true);
			doc.DocumentElement!.AppendChild(importedSpectacle);

			doc.Save(filePath);
		}

		public List<int> GetById()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(filePath);

			List<int> Ids = new List<int>();

			XmlNodeList elements = xmlDocument.SelectNodes("//Spectacle[Id]")!;

			foreach (XmlNode element in elements)
			{
				int Id = int.Parse(element.SelectSingleNode("Id")!.InnerText);
				Ids.Add(Id);
			}

			return Ids;
		}
	}
}
