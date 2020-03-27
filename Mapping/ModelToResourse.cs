using AutoMapper;
using CoreRegSite.Models;

namespace CoreRegSite.Mapping
{
    public class ModelToResourse : Profile
    {
        public ModelToResourse()
        {
            CreateMap<UserModel, Participant>();
        }
    }
}