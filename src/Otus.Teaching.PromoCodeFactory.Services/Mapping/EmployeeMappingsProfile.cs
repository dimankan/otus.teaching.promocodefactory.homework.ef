using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Services.Models.Employee;

namespace Otus.Teaching.PromoCodeFactory.Services.Mapping
{
    public class EmployeeMappingsProfile : Profile
    {
        public EmployeeMappingsProfile()
        {
            CreateMap<Employee, EmployeeDTO>();

            CreateMap<CreatingEmployeeDTO, Employee>()
                .ForMember(d => d.Id, map => map.Ignore())
                .ForMember(d => d.Role, map => map.Ignore());

            CreateMap<UpdatingEmployeeDTO, Employee>()
                .ForMember(d => d.Id, map => map.Ignore())
                .ForMember(d => d.Role, map => map.Ignore());
        }
    }

}
