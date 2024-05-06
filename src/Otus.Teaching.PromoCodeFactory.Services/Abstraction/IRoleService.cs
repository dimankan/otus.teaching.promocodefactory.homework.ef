using Otus.Teaching.PromoCodeFactory.Services.Models.Role;

namespace Otus.Teaching.PromoCodeFactory.Services.Contracts
{
    public interface IRoleService
    {
        Task<List<RoleDTO>> GetAllAsync();
    }
}
