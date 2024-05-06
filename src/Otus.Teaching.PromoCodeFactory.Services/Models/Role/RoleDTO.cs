using Otus.Teaching.PromoCodeFactory.Services.Models.Employee;

namespace Otus.Teaching.PromoCodeFactory.Services.Models.Role
{
    public class RoleDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<EmployeeDTO> Employees { get; set; }
    }
}
