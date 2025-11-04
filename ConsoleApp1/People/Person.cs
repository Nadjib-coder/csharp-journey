namespace ConsoleApp1.People;

public class Person
{
    public string? Name;
    public int Age;
    public bool HasPet;

    public void Greeting()
    {
        Console.WriteLine($"Hello everyone, I am {Name}, a {Age} years old FullStack Software engineer at Trading economics");
    }

}