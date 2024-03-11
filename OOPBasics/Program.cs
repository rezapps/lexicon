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

			/*
			List<UserError> errors = new List<UserError> { new NumericInputError(), new TextInputError() };
			*/
			List<UserError> errors = [new NumericInputError(), new TextInputError()];

			foreach (var error in errors)
			{
				Console.WriteLine(error.UEMessage());
			}



			List<Animal> Animals = [];

			Animals.Add(new Horse("Horsy", 5, 220.0, true));
			Animals.Add(new Dog("Dogo", 2, 10.0, true));
			Animals.Add(new Worm("Wormee", 3, 0.01, true));
			Animals.Add(new Pelican("Pelicante", 6, 10.0, 2.0, true));

			foreach (var Animal in Animals)
			{
				Console.WriteLine("");
				Console.WriteLine(Animal.Stats());
				Animal.DoSound();
				Console.WriteLine("");
			}
		}


	}
}
