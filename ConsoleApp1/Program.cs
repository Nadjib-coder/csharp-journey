using ConsoleApp1.People;
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // string name = "nadjib";
        // name = name.ToUpper();
        // Console.WriteLine(name);

        Person me = new Person();

        me.Name = "Nadjib";
        me.Age = 23;
        me.HasPet = true;
        me.Greeting();
    }
}



