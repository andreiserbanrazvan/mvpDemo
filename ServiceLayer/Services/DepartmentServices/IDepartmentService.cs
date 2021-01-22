using DomainLayer.Models.Department;

namespace ServiceLayer.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        void ValidateModel(DepartmentModel departmentModel);
    }
}
