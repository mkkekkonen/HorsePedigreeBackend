using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using AutoMapper;

using horsesBackend.Db;
using horsesBackend.Models;
using horsesBackend.Dtos;

namespace horsesBackend.Controllers {
  [ApiController]
  [Route("[controller]")]
  public class BreedController : ControllerBase {
    private readonly HorseDbContext _context;
    private readonly IMapper _mapper;

    public BreedController(HorseDbContext context, IMapper mapper) {
      _context = context;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BreedDto>>> GetBreedsAsync() {
      return await _context.Breeds
        .Select(breed => _mapper.Map<BreedDto>(breed))
        .ToListAsync();
    }
  }
}
