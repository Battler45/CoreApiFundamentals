using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>();
            CreateMap<Location, LocationModel>();
            CreateMap<Talk, TalkModel>();
            CreateMap<Speaker, SpeakerModel>();
        }
    }
}
