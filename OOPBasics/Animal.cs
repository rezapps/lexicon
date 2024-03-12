namespace OOPBasics
{
	public abstract class Animal
	{
		protected string Name { get; set; }
		protected int Age { get; set; }
		protected double Weight { get; set; }

		public Animal (string name, int age, double weight)
		{
			Name = name;
			Age = age;
			Weight = weight;
		}


		// Virtual method that can be overriden in derived classes
		public virtual string Stats()
		{
			return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
		}


		public abstract void DoSound();
		// internal abstract bool SomeString();
	} // Class Animal Ends


	/*
	public class Horse : Animal
	{
		public bool IsTamed { get; set; }
		public Horse (string name, int age, double weight, bool isTamed) : base(name, age, weight)
		{
			IsTamed = isTamed;
		}
		public override void DoSound()
		{
			Console.WriteLine("Horse says HIHIHIHIHI");
		}
	}

	######################################################################

	C# Intellisense suggests to create a "primary class" that inherits
	from Animal instead of the base class.

	######################################################################
	*/
	public class Horse(string name, int age, double weight, bool isTamed) : Animal(name, age, weight)
	{
		public bool IsTamed { get; set; } = isTamed;

		public override void DoSound()
		{
			Console.WriteLine("Horse says HIHIHIHIHI");
		}

		public override string Stats()
		{
			return base.Stats() + $", Is Tamed: {IsTamed}";
		}
	} // Class Horse Ends

	public class Dog(string name, int age, double weight, bool isHunter) : Animal(name, age, weight)
	{
		public bool IsHunter { get; set; } = isHunter;

		public override void DoSound()
		{
			Console.WriteLine("Dog says AUAUAUAUAUAU");
		}

		public string SomeString()
		{
			return "Some String from the Dog class";
		}


		public override string Stats()
		{
			return base.Stats() + $", Is Hunter: {IsHunter}";
		}

	} // Class Dog Ends


	public class Hedgehog(string name, int age, double weight, int nrOfSpikes) : Animal(name, age, weight)
	{
		public int NrOfSpikes { get; set; } = nrOfSpikes;

		public override void DoSound()
		{
			Console.WriteLine("Hedgehog says GOTTA GO FAST");
		}


		public override string Stats()
		{
			return base.Stats() + $", Number of spikes: {NrOfSpikes}";
		}
	} // Class Hedgehog Ends


	public class Worm(string name, int age, double weight, bool isPoisonous) : Animal(name, age, weight)
	{
		public bool IsPoisonous { get; set; } = isPoisonous;
		public override void DoSound()
		{
			Console.WriteLine("Worm says hishshs");
		}

		public override string Stats()
		{
			return base.Stats() + $", is poisonous: {IsPoisonous}";
		}
	} // Class Worm Ends


	public class Wolf(string name, int age, double weight, bool isVegan) : Animal(name, age, weight)
	{
		public bool IsVegan { get; set; } = isVegan;
		public override void DoSound()
		{
			Console.WriteLine("Wolf says oooOOOOOOUUUUUUU");
		}

		public override string Stats()
		{
			return base.Stats() + $", is vegan: {IsVegan}";
		}

	} // Class Wolf Ends


	// Bird is drived from Animal class and inherits all properties
	public class Bird(string name, int age, double weight, double wingSpan) : Animal(name, age, weight)
	{
		public double WingSpan { get; set; } = wingSpan;
		public override void DoSound()
		{
			Console.WriteLine("Bird says Chirp Chirp");
		}

		public override string Stats()
		{
			return base.Stats() + $", has a wingspan: {WingSpan} meters";
		}
	} // Class Bird Ends


	// Pelican is sub-drived from Bird
	public class Pelican(string name, int age, double weight, double wingSpan, bool isDancer) : Bird(name, age, weight, wingSpan)
	{

		public bool IsDancer { get; set; } = isDancer;
		public override void DoSound()
		{
			Console.WriteLine("Plican says shoooooooooooow");
		}

		public override string Stats()
		{
			return base.Stats() + $", is a dancer: {IsDancer}";
		}
	} // Class Pelican Ends

	public class Flamingo(string name, int age, double weight, double wingspan, bool isPink) : Bird(name, age, weight, wingspan)
	{
		public bool IsPink { get; set; } = isPink;

		public override void DoSound()
		{
			Console.WriteLine("Flamingo says HAKHAKHAKHAK");
		}

		public override string Stats()
		{
			return base.Stats() + $", is pink: {IsPink}";
		}
	} // Class Flamingo Ends


	public class Swan(string name, int age, double weight, double wingspan, bool doAttack) : Bird(name, age, weight, wingspan)
	{

		public bool DoAttack { get; set; } = doAttack;
		public override void DoSound()
		{
			Console.WriteLine("Swan says Quack Quack");
		}
		public override string Stats()
		{
			return base.Stats() + $", does attack: {DoAttack}";
		}
	} // Class Swan Ends


	// Interface
	public interface IPerson
	{
		void Talk();
	}


	public class Wolfman(string name, int age, double weight, bool isVegan) : Wolf(name, age, weight, isVegan), IPerson
	{
		public void Talk()
		{
			Console.WriteLine("Wolfman says: AwwwwoooOOOLLFF-man is not the same as a ware-wooooooooollf");
		}
	} // Class Wolfman Ends

}
