using System.Xml;
using System.Xml.Serialization;

namespace Lab2_dotnet.DAL.Util
{
	public static class XmlElementExtensions
	{
		public static XmlElement ToXmlElement<T>(this object obj)
		{
			XmlDocument doc = new XmlDocument();

			using (XmlWriter writer = doc.CreateNavigator()!.AppendChild())
			{
				new XmlSerializer(obj.GetType()).Serialize(writer, obj);
			}

			return doc.DocumentElement!;
		}
	}
}
