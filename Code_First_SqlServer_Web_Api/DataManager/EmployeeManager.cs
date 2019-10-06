using Code_First_SqlServer_Web_Api.Dal;
using Code_First_SqlServer_Web_Api.Models;
using Code_First_SqlServer_Web_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_First_SqlServer_Web_Api.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        readonly EmployeeContext _employeeContext;
        public EmployeeManager(EmployeeContext context)
        {
            _employeeContext = context;
        }
        void IDataRepository<Employee>.Add(Employee entity)
        {
            _employeeContext.Employees.Add(entity);
            _employeeContext.SaveChanges();
        }

        void IDataRepository<Employee>.Delete(Employee entity)
        {
            _employeeContext.Employees.Remove(entity);
            _employeeContext.SaveChanges();
        }

        Employee IDataRepository<Employee>.Get(long id)
        {
            return _employeeContext.Employees.FirstOrDefault(r => r.EmployeeId == id);
        }

        IEnumerable<Employee> IDataRepository<Employee>.GetAll()
        {
            return _employeeContext.Employees.ToList();
        }

        void IDataRepository<Employee>.Update(Employee _employee, Employee entity)
        {
            _employee.FirstName = entity.FirstName;
            _employee.LastName = entity.LastName;
            _employee.Gender = entity.Gender;
            _employee.Email = entity.Email;
            _employee.DataOfBirth = entity.DataOfBirth;
            _employee.PhoneNumber = entity.PhoneNumber;

            _employeeContext.SaveChanges();
        }
    }
}
