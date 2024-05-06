using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Services.Contracts;
using Otus.Teaching.PromoCodeFactory.Services.Models.Employee;

namespace Otus.Teaching.PromoCodeFactory.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeDTO>> GetAllAsync()
        {
            return _mapper.Map<List<EmployeeDTO>>(await _employeeRepository.GetAllAsync());
        }

        public async Task<EmployeeDTO> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Employee, EmployeeDTO>(await _employeeRepository.GetByIdAsync(id));
        }

        public async Task<Guid> CreateAsync(CreatingEmployeeDTO creatingEmployeeDTO)
        {
            var employee = _mapper.Map<CreatingEmployeeDTO, Employee>(creatingEmployeeDTO);
            var createdEmployee = await _employeeRepository.CreateAsync(employee);
            await _employeeRepository.SaveChangesAsync();

            return createdEmployee.Id;
        }

        public async Task UpdateAsync(Guid id, UpdatingEmployeeDTO updatingEmployeeDTO)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                throw new Exception($"Сущность с id = {id} не найдена");
            }

            _mapper.Map(updatingEmployeeDTO, employee);
            await _employeeRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                throw new Exception($"Сущность с id = {id} не найдена");
            }

            await _employeeRepository.DeleteAsync(employee);
        }
    }
}
