namespace OOPBasics
{
	public class PersonHandler
	{
		// Member 'SetAge' does not access instance data and can be marked as staticCA1822
		// public void SetAge(Person person, int newAge)
		public static void SetAge(Person person, int newAge)
		{
			person.Age = newAge;
		}

		// Member 'CreatePerson' does not access instance data and can be marked as staticCA1822
		// public Person CreatePerson(int age, string firstName, string lastName, double height, double weight)
		public static Person CreatePerson(int age, string firstName, string lastName, double height, double weight)
		{
			return new Person(age, firstName, lastName)
			{
				Height = height,
				Weight = weight
			};
		}

	}
}
