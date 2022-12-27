using LearningDI.Injectors;
using LearningDI.Interfaces;
using LearningDI.Services;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(String[] args)
    {
        Service1 serv1 = new Service1();
        Service2 serv2 = new Service2();

        Injector InjectorObj = new Injector(serv1,serv2);

        Console.Write("Enter name : ");

        string name = Console.ReadLine();

        Console.WriteLine($"Long : {InjectorObj.isLong(name)}");
        Console.WriteLine($"Short : {InjectorObj.isShort(name)}");

    }
}
