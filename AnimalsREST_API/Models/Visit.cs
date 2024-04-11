namespace AnimalsREST_API.Models;

public class Visit
{
    public DateOnly DateOfVisit { get; set; }
    public Animal Animal { get; set; }
    public String Description { get; set; }
    public double Price { get; set; }

    public Visit(DateOnly dateOfVisit, Animal animal, string description, double price)
    {
        DateOfVisit = dateOfVisit;
        Animal = animal;
        Description = description;
        Price = price;
    }
    
}