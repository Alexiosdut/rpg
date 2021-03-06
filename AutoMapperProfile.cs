using AutoMapper;
using rpg.Dtos.Character;
using rpg.Models;

namespace rpg
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}