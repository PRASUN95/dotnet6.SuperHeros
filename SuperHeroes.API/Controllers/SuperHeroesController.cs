using Microsoft.AspNetCore.Mvc;
using SuperHeroes.API.Models;

namespace SuperHeroes.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuperHeroesController : ControllerBase
{
    private static readonly List<SuperHero> _superHeroes = new List<SuperHero>(){
        new SuperHero{
            Id = 1,
            Name = "Iron Man",
            FirstName = "Tony",
            LastName = "Stark",
            Location = "New York",
        }
    };

    [HttpGet]
    public async Task<ActionResult<List<SuperHero>>> Get()
    {
        await Task.Delay(1000);
        return Ok(_superHeroes);
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<SuperHero>> Get(int Id)
    {
        await Task.Delay(1000);
        var superHero = _superHeroes.FirstOrDefault(hero => hero.Id == Id);
        if (superHero == null) return NotFound();
        return Ok(superHero);
    }

    [HttpPost]
    public async Task<ActionResult<List<SuperHero>>> Post(SuperHero superHero)
    {
        await Task.Delay(1000);
        _superHeroes.Add(superHero);
        return Ok(_superHeroes);
    }

    [HttpPut]
    public async Task<ActionResult<List<SuperHero>>> Put(SuperHero request)
    {
        await Task.Delay(1000);
        if (request.Id == null) return BadRequest();
        var superHero = _superHeroes.Find(hero => hero.Id == request.Id);
        if (superHero == null) return NotFound();
        superHero.Name = request.Name;
        superHero.FirstName = request.FirstName;
        superHero.LastName = request.LastName;
        superHero.Location = request.Location;
        return Ok(_superHeroes);
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(int Id)
    {
        await Task.Delay(1000);
        var superHero = _superHeroes.Find(hero => hero.Id == Id);
        if (superHero == null) return NotFound();
        _superHeroes.Remove(superHero);
        return Ok(_superHeroes);
    }
}

