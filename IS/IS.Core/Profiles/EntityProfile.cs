using AutoMapper;
using IS.Domain.Models.Dtos;
using IS.Domain.Models.Entities;

namespace IS.Core.Profiles;

public class EntityProfile : Profile
{
    public EntityProfile()
    {
        CreateMap<Employee, EmployeeDto>()
            .ForMember(dst => dst.Gender, opt => opt.MapFrom(src => src.Gender.ToString()))
            .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dst => dst.LastModifiedOn, opt => opt.MapFrom(src => src.ModifiedOn ?? src.CreatedOn))
            .ForMember(dst => dst.LastModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy ?? src.CreatedBy));
    }
}