using System.Security.Cryptography.X509Certificates;

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


		public abstract void DoSound();
	}


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
	}

	public class Dog(string name, int age, double weight, bool isHunter) : Animal(name, age, weight)
	{
		public bool IsHunter { get; set; } = isHunter;

		public override void DoSound()
		{
			Console.WriteLine("Dog says AUAUAUAUAUAU");
		}

	}


	public class Hedgehog(string name, int age, double weight, int nrOfSpikes) : Animal(name, age, weight)
	{
		public int NrOfSpikes { get; set; } = nrOfSpikes;

		public override void DoSound()
		{
			Console.WriteLine("Hedgehog says GOTTA GO FAST");
		}
	}


	public class Worm(string name, int age, double weight, bool isPoisonous) : Animal(name, age, weight)
	{
		public bool IsPoisonous { get; set; } = isPoisonous;
		public override void DoSound()
		{
			Console.WriteLine("Worm says hishshs");
		}
	}


	public class Wolf(string name, int age, double weight, bool isVegan) : Animal(name, age, weight)
	{
		public bool IsVegan { get; set; } = isVegan;
		public override void DoSound()
		{
			Console.WriteLine("Wolf says oooOOOOOOUUUUUUU");
		}
	}


	// Bird is drived from Animal class and inherits all properties
	public class Bird(string name, int age, double weight, double wingSpan) : Animal(name, age, weight)
	{
		public double WingSpan { get; set; } = wingSpan;
		public override void DoSound()
		{
			Console.WriteLine("Bird says Chirp Chirp");
		}
	}


	// Pelican is sub-drived from Bird
	public class Pelican(string name, int age, double weight, double wingSpan, bool lovesSwim) : Bird(name, age, weight, wingSpan)
	{

		public bool LovesSwim { get; set; } = lovesSwim;
		public override void DoSound()
		{
			Console.WriteLine("Plican says shoooooooooooow");
		}
	}

	public class Flamingo(string name, int age, double weight, double wingspan, bool isNotPink) : Bird(name, age, weight, wingspan)
	{
		public bool IsNotPink { get; set; } = isNotPink;

		public override void DoSound()
		{
			Console.WriteLine("Flamingo says HAKHAKHAKHAK");
		}
	}


	public class Swan(string name, int age, double weight, double wingspan, bool doAttack) : Bird(name, age, weight, wingspan)
	{

		public bool DoAttack { get; set; } = doAttack;
		public override void DoSound()
		{
			Console.WriteLine("Swan says Quack Quack");
		}
	}


	// Interface
	public interface IPerson
	{
		void Talk();
	}


	public class Wolfman(string name, int age, double weight, bool isVegan) : Wolf(name, age, weight, isVegan), IPerson
	{
		public void Talk()
		{
			Console.WriteLine("Wolfman says oooOOOOOOUUUUUUU");
		}
	}



}

