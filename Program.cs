namespace CSharpOOPInheritance;

public class Animal 
{
    public string _name { get; set; }

    public Animal(string name)
    {
        _name = name;
    }

    #region Access Modifier (access levels)

    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    protected void Environment()
    {
        Console.WriteLine("Environment");
    }

    private void Kind()
    {
        Console.WriteLine("Animal's kind");
    }

    internal void Species()
    {
        Console.WriteLine("Animal Species");
    }

    #endregion Access Modifier (access levels)

    public virtual void ShowName()
    {
        Kind();
        Species();
        Console.WriteLine(_name);
    }
}

public class Dog : Animal
{
    public string _breed { get; set; }

    public Dog(string name, string breed) : base(name)
    {
        _breed = breed;
    }

    public void Run()
    {
        Console.WriteLine("Dog is running.");
    }

    // Polymorphism.
    public override void ShowName()
    {
        Environment();
        // Kind(); cannot do this right here due to private level.
        Species(); // this be able to call here because it is compiled in the same assembly.
        Console.WriteLine($"This dog name is {_name} and breed: {_breed}.");
    }
}

public class Fish : Animal
{
    public string _type { get; set; }

    public Fish(string name, string type) : base(name)
    {
        _type = type;
    }

    public void Swim()
    {
        Console.WriteLine("Fish is swimming.");
    }

    // Polymorphism.
    public override void ShowName()
    {
        Environment();
        // Kind(); cannot do this right here due to private level.
        Species(); // this be able to call here because it is compiled in the same assembly.
        Console.WriteLine($"This fish name is {_name} and type: {_type}.");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", "Golden Retriever");
        dog.Eat();
        dog.Run();
        dog.ShowName();
        // dog.Environment(); cannot do this right here due to protected level.
        dog.Species(); // this be able to call here because it is compiled in the same assembly.

        Fish fish = new Fish("John", "COD");
        fish.Eat();
        fish.Swim();
        fish.ShowName();
        // fish.Environment(); cannot do this right here due to protected level.
        fish.Species(); // this be able to call here because it is compiled in the same assembly.
    }
}
