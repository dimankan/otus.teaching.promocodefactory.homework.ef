using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Services.Contracts;

namespace Otus.Teaching.PromoCodeFactory.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Employee> _repository;

        public EmployeeService(IMapper mapper, IRepository<Employee> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
    }
}
