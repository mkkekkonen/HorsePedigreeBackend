using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using AutoMapper;

using horsesBackend.Db;
using horsesBackend.Models;
using horsesBackend.Dtos;

namespace horsesBackend.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class HorseController : ControllerBase
  {
    private readonly HorseDbContext _context;
    private readonly IMapper _mapper;

    public HorseController(HorseDbContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<HorseDto>>> GetHorsesAsync()
    {
      return await _context.Horses
        .Select(horse => _mapper.Map<HorseDto>(horse))
        .ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Horse>> AddHorseAsync([FromForm] HorseDto horseDto)
    {
      var horse = _mapper.Map<Horse>(horseDto);

      _context.Horses.Add(horse);
      await _context.SaveChangesAsync();

      return CreatedAtAction(
        "GetHorses",
        null,
        _mapper.Map<HorseDto>(horse)
      );
    }
  }
}
