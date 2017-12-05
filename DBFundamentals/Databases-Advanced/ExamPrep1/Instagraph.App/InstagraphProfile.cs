using AutoMapper;
using Instagraph.Models;
using Models.Dto;

namespace Instagraph.App
{
    public class InstagraphProfile : Profile
    {
        public InstagraphProfile()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserPicDto, User>()
            .ForMember(u => u.ProfilePicture, p => p.UseValue<Picture>(null)));           
        }
    }
}
