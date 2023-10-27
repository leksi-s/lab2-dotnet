using System.Xml.Serialization;

namespace Lab2_dotnet.ClassesOfData
{
	public class Actor
	{
		private static int lastId = 0;
		public int Id { get; set; }
		public string? FullName { get; set; }
		public string? Amplua { get; set; }

		[XmlElement(DataType = "date")]
		public DateOnly DateOfBirth { get; set; }
		public bool IsProducer { get; set; }

		public Actor(string fullName, string amplua, DateOnly dateOfBirth, bool isProducer)
		{
			lastId++;
			Id = lastId;
			FullName = fullName;
			Amplua = amplua;
			DateOfBirth = dateOfBirth;
			IsProducer = isProducer;
		}

		public Actor() { }

		public override string ToString()
		{
			return string.Format($"{Id};  {FullName};  {Amplua};  {DateOfBirth};  {IsProducer};");
		}
	}
}
