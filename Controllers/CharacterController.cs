using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rpg.Models;
using rpg.Services.CharacterService;

namespace rpg.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CharacterController : ControllerBase
  {
    public ICharacterService CharacterService { get; }

    public CharacterController(ICharacterService characterService)
    {
      CharacterService = characterService;
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> Get()
    {
      return Ok(await CharacterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSingle(int id)
    {
      return Ok(await CharacterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<IActionResult> AddCharacter(Character newCharacter)
    {
      return Ok(await CharacterService.AddCharacter(newCharacter));
    }
  }
}