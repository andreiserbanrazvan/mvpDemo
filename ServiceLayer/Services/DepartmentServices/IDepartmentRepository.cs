using DomainLayer.Models.Department;
using System.Collections.Generic;

namespace ServiceLayer.Services.DepartmentServices
{
    public interface IDepartmentRepository
    {
        void Add(DepartmentModel departmentModel);
        void Update(DepartmentModel departmentModel);
        void Delete(DepartmentModel departmentModel);
        IEnumerable<DepartmentModel> GetAll();
        DepartmentModel GetById(int id);

    }
}
