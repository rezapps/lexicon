namespace OOPBasics
{
	public class Program
	{
		static void Main(string[] args)
		{
			// PersonHandler methods are static now so we don't need to instantiate it
			Person johnDoe = PersonHandler.CreatePerson(25, "John", "Doe", 1.80, 75.0);
			PersonHandler.SetAge(johnDoe, 30);
			Console.WriteLine($"Person 1: {johnDoe.FirstName} {johnDoe.LastName}, Age: {johnDoe.Age}");


			List<UserError> errors = new List<UserError> { new NumericInputError(), new TextInputError() };

			foreach (var error in errors)
			{
				Console.WriteLine(error.UEMessage());
			}
		}
	}
}
