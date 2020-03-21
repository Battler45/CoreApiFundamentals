using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>()
                .ReverseMap();
            CreateMap<Location, LocationModel>()
                .ReverseMap();
            CreateMap<Talk, TalkModel>()
                .ReverseMap();
            CreateMap<Speaker, SpeakerModel>()
                .ReverseMap();
        }
    }
}
