# Questions from assignment no.3

## Encapsulation questions

Question 13:
in class bird

Question 14:
in Animal class

```cs

```

## Polymorphism questions

Question 9:
If we add a horse to the dog list, program cant convert from type horse to type dog, this will throw an Error:

```cs
// Program.cs(52,13): error CS1503: Argument 1: cannot convert from 'OOPBasics.Horse' to 'OOPBasics.Dog'
```

Question 10:
List should be of type Animal so that it can hold all animal types.

Question 13:
By converting the list from Dog (sub class) type to Animal (base class) Type, it can hold all types of animals. Then cast types to dog to only print dog instance Stats().

```cs
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
```

Question 17:
foreach loop iterates over list elements from base class Animal which does not have access to SomeString() method inside Dog class.
