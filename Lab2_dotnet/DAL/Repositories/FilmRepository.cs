using Lab2_dotnet.ClassesOfData;
using Lab2_dotnet.DAL.Util;
using System.Xml;

namespace Lab2_dotnet.DAL.Repositories
{
	public class FilmRepository : BaseRepository
	{
		public FilmRepository(string filePath) : base(filePath)
		{
		}

		public void Add(Film film)
		{
			var doc = new XmlDocument();
			doc.Load(filePath);

			var importedFilm = doc.ImportNode(film.ToXmlElement<Film>(), true);
			doc.DocumentElement!.AppendChild(importedFilm);

			doc.Save(filePath);
		}

		public List<int> GetById()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(filePath);

			List<int> Ids = new List<int>();

			XmlNodeList elements = xmlDocument.SelectNodes("//Film[Id]")!;

			foreach (XmlNode element in elements)
			{
				int Id = int.Parse(element.SelectSingleNode("Id")!.InnerText);
				Ids.Add(Id);
			}

			return Ids;
		}

	}
}
