using ConsoleApp1.People;
using ConsoleApp1.Calc;
namespace ConsoleApp1;


class Program
{
    static void Main(string[] args)
    {
        // string name = "nadjib";
        // name = name.ToUpper();
        // Console.WriteLine(name);

        /*
        Person me = new Person();

        me.Name = "Nadjib";
        me.Age = 23;
        me.HasPet = true;
        me.Greeting();
        */
        int sum = Calculator.Add(23, 19);
        Console.WriteLine(sum);
    }
}



