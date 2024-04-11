using AnimalsREST_API.Databases;
using AnimalsREST_API.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsREST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = StaticData.animals;
        
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        var animals = StaticData.animals;
        var length = animals.Count;
        for (int i = 0; i < length; i++)
        {
            if (id == animals[i].Id)
            {
                return Ok(animals[i]);
            }
        }
        return NotFound();
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        var animals = StaticData.animals;
        animals.Add(animal);
        return Created();
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animals = StaticData.animals;
        var length = animals.Count;
        for (int i = 0; i < length; i++)
        {
            if (id == animals[i].Id)
            {
                animals[i] = animal;
                return Ok();
            }
        }
        return NotFound();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animals = StaticData.animals;
        var length = animals.Count;
        for (int i = 0; i < length; i++)
        {
            if (id == animals[i].Id)
            {
                animals.RemoveAt(i);
                return Ok();
            }
        }
        return NotFound();
    }
}