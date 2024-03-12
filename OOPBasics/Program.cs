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
			Animals.Add(new Dog("Dogydoug", 9, 30.0, true));
			Animals.Add(new Worm("Wormee", 3, 0.01, true));
			Animals.Add(new Pelican("Pelicante", 6, 10.0, 2.0, true));
			Animals.Add(new Wolfman(age: 40, name: "Wolverine", weight: 120.0, isVegan: true));

			foreach (var Animal in Animals)
			{
				Console.WriteLine("");
				Console.WriteLine(Animal.Stats());


				// Using "is" operator to check if Animal's type can be
				// casted to a new variable "person" of type IPerson
				if (Animal is IPerson person){
					person.Talk();
				} else {
					Animal.DoSound();
				}
				Console.WriteLine("");
			} // foreach loop Ends



			// List<Dog> Dogs = new List<Dog>();
			List<Animal> Dogs = [];

			Dogs.Add(new Dog("Doug", 2, 10.0, true));
			Dogs.Add(new Dog("Smol", 2, 5.0, true));

			// adding a horse to the list of dogs
			Dogs.Add(new Horse("Horsy", 8, 120.0, true));


			foreach (Animal dog in Dogs)
			{
				// using "is" and type casting to check if the object is of type Dog
				if (dog is Dog DogInstance)
				{
					Console.WriteLine(DogInstance.Stats());
				}
			}


			// using "is" and type casting to check if the object is of type Dog
			// and then calling the SomeString() method

			foreach (Animal animal in Animals)
			{
				if (animal is Dog DogInstance)
				{
					Console.WriteLine(DogInstance.SomeString());
				}
				else
				{
					string animalType = animal.GetType().ToString();
					Console.WriteLine($"{animalType.Substring(10)} does not have access to SomeString() method.");
				}
			}

		}// Main method Ends

	} // Class Program Ends
}
