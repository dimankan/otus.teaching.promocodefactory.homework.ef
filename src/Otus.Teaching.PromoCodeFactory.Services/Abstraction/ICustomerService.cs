using Otus.Teaching.PromoCodeFactory.Services.Models.Customer;

namespace Otus.Teaching.PromoCodeFactory.Services.Contracts
{
    public interface ICustomerService
    {
        Task<List<CustomerDTO>> GetAllAsync();

        Task<CustomerDTO> GetByIdAsync(Guid id);

        Task<Guid> CreateAsync(CreatingCustomerDTO creatingCustomerDTO);

        Task UpdateAsync(Guid id, UpdatingCustomerDTO updatingCustomerDTO);

        Task DeleteAsync(Guid id);
    }
}
