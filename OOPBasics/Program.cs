namespace OOPBasics
{
	public class Program
	{
		static void Main(string[] args)
		{
			Person johnDoe = PersonHandler.CreatePerson(25, "John", "Doe", 1.80, 75.0);
			PersonHandler.SetAge(johnDoe, 30);
			Console.WriteLine($"Person 1: {johnDoe.FirstName} {johnDoe.LastName}, Age: {johnDoe.Age}");
		}
	}
}
