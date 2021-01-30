using System;

using AutoMapper;

using horsesBackend.Models;
using horsesBackend.Dtos;

namespace horsesBackend.MapperProfiles {
  public class HorseProfile : Profile {
    public HorseProfile() {
      CreateMap<Horse, HorseDto>();
      CreateMap<HorseDto, Horse>();

      CreateMap<Breed, BreedDto>();
      CreateMap<BreedDto, Breed>();
    }
  }
}
