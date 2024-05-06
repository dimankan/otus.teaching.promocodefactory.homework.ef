using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Services.Models.Role;

namespace Otus.Teaching.PromoCodeFactory.Services.Mapping
{
    public class RoleMappingsProfile : Profile
    {
        public RoleMappingsProfile()
        {
            CreateMap<Role, RoleDTO>();
        }
    }

}
