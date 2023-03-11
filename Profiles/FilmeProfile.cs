using AutoMapper;
using FilmesAPI.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile() 
    {
        CreateMap<CreateFilmeDTO, Filme>();
    }
}
