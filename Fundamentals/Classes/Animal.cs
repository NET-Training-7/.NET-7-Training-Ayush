using System;

internal class Animal
{
    internal int id;
    internal string name;
    internal string species;
    internal short weight;
    internal short age;

    internal void AnimalDetail()
    {
        Console.WriteLine($"Id:{id} Name:{name} Species:{species} Weight:{weight} Age:{age}");
    }

}