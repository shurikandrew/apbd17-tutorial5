namespace AnimalsREST_API.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string FurColor { get; set; }

    public Animal(int id, string name, string category, double weight, string furColor)
    {
        Id = id;
        Name = name;
        Category = category;
        Weight = weight;
        FurColor = furColor;
    }
}