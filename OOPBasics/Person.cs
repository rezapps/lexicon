namespace OOPBasics
{
	public class Person
	{
		private int _age;
		private string? _firstName;
		private string? _lastName;
		private double _height;
		private double _weight;

		public int Age
		{
			get => _age;
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Age must be greater than 0.");
				}

				_age = value;
			}
		}

		public string FirstName
		{
			// setting default value to empty string
			get => _firstName ?? "";
			set
			{
				if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
				{
					throw new ArgumentException("First name must be between 2 and 10 characters long.");
				}

				_firstName = value;
			}
		}

		public string LastName
		{
			// setting default value to empty string
			get => _lastName ?? "";
			set
			{
				if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
				{
					throw new ArgumentException("Last name must be between 3 and 15 characters long.");
				}

				_lastName = value;
			}
		}

		public double Height
		{
			get => _height;
			set => _height = value;
		}

		public double Weight
		{
			get => _weight;
			set => _weight = value;
		}

		public Person(int age, string firstName, string lastName)
		{
			Age = age;
			FirstName = firstName;
			LastName = lastName;
		}

	} // Class Person Ends
}
