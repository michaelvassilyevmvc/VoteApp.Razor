using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace VoteApp.WebApi
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Vote, VoteDto>();
            CreateMap<User, UserDto>()
                .ForCtorParam("DateOfBirth", opt => opt.MapFrom(x => x.DoB));
            CreateMap<ProductCandidate, ProductCandidateDto>();
            CreateMap<PoliticCandidate, PoliticCandidateDto>();
                
        }
    }
}
