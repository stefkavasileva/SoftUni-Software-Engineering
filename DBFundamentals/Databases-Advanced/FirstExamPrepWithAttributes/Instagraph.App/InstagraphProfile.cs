using AutoMapper;
using Instagraph.DataProcessor.Models.Dto.Import;
using Instagraph.Models;

namespace Instagraph.App
{
    public class InstagraphProfile : Profile
    {
        public InstagraphProfile()
        {
            CreateMap<PictureDto, Picture>();
        }
    }
}
