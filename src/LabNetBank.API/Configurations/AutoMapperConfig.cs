using AutoMapper;
using LabNetBank.API.Models;
using LabNetBank.Business.Models;

namespace LabNetBank.API.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        { 
            CreateMap<Holder, AccountHolderInputModel>().ReverseMap();
        }
    }
}
