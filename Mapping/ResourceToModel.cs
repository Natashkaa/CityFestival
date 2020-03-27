using AutoMapper;
using CoreRegSite.Models;

namespace CoreRegSite.Mapping
{
    public class ResourceToModel : Profile
    {
        public ResourceToModel(){
            CreateMap<Participant, UserModel>();
            CreateMap<Participant, SimpleUserModel>();
        }    
    }
}