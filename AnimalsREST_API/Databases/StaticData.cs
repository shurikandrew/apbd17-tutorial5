using AnimalsREST_API.Models;

namespace AnimalsREST_API.Databases;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Bob", "dog",12.1,"white"),
        new Animal(2, "Bobby", "cat", 9.3,"orange"),
        new Animal(3, "Bobo", "hamster", 0.2, "white"),
        new Animal(4, "Boba", "cat", 15.2, "black"),
    };
    
    public static List<Visit> visits = new List<Visit>()
    {
        new Visit(new DateOnly(2024, 1, 3), animals[0], "everything was fine",1500.0),
        new Visit(new DateOnly(2023, 2, 23), animals[0], "everything was not fine, prescription from vet",1800.4),
        new Visit(new DateOnly(2024, 2, 10), animals[1], "everything was ok",2000.0),
        new Visit(new DateOnly(2024, 3, 3), animals[0], "everything was bad",0.0),
    };
}