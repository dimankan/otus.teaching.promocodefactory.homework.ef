using Otus.Teaching.PromoCodeFactory.Services.Models.Employee;

namespace Otus.Teaching.PromoCodeFactory.Services.Contracts
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDTO>> GetAllAsync();

        Task<EmployeeDTO> GetByIdAsync(Guid id);

        Task<Guid> CreateAsync(CreatingEmployeeDTO creatingEmployeeDTO);

        Task UpdateAsync(Guid id, UpdatingEmployeeDTO updatingEmployeeDTO);

        Task DeleteAsync(Guid id);
    }
}
