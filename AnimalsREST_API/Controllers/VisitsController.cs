using AnimalsREST_API.Databases;
using AnimalsREST_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsREST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class VisitsController : ControllerBase
{
    [HttpGet("{animalId}")]
    public IActionResult GetVisitsByAnimalId(int animalId)
    {
        var result = new List<Visit>();
        var visits = StaticData.visits;
        var length = visits.Count;
        for (int i = 0; i < length; i++)
        {
            if (animalId == visits[i].Animal.Id)
            {
                result.Add(visits[i]);
            }
        }

        if (result.Count == 0)
        {
            return NotFound();
        }

        return Ok(result);
    }
    
    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        var visits = StaticData.visits;
        visits.Add(visit);
        return Created();
    }
    
}