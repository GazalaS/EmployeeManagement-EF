using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int EmployeeID);
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(int EmployeeID);
        void Save();
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext _context;
        public EmployeeRepository()
        {
            _context = new EmployeeDBContext();
        }
        public EmployeeRepository(EmployeeDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        public Employee GetById(int EmployeeID)
        {
            return _context.Employees.Find(EmployeeID);
        }
        public void Create(Employee employee)
        {
            _context.Employees.Add(employee);
        }
        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }
        public void Delete(int EmployeeID)
        {
            Employee employee = _context.Employees.Find(EmployeeID);
            _context.Employees.Remove(employee);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
