using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public  IEnumerable<Employee> GetAll()
        {
            var model = _employeeRepository.GetAll();
            return model;
        }

        //[HttpGet]
        //public ActionResult Index()
        //{
        //    var model = _employeeRepository.GetAll();
        //    return View(model);
        //}

        //[HttpGet]
        //public ActionResult AddEmployee()
        //{
        //    return View();
        //}

        [Route("CreateEmployee")]
        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Create(model);
                _employeeRepository.Save();
                return Ok(model);
            }
            return BadRequest("Invalid data.");
        }

        //[HttpGet]
        //public ActionResult EditEmployee(int EmployeeId)
        //{
        //    Employee model = _employeeRepository.GetById(EmployeeId);
        //    return View(model);
        //}

        [Route("EditEmployee")]
        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(model);
                _employeeRepository.Save();
                return Ok(model);
            }
            else
            {
                return BadRequest("Invalid data.");
            }
        }

        //[HttpGet]
        //public ActionResult DeleteEmployee(int EmployeeId)
        //{
        //    Employee model = _employeeRepository.GetById(EmployeeId);
        //    return View(model);
        //}
        [Route("DeleteEmployee")]
        [HttpPost]

        public ActionResult Delete(int EmployeeID)
        {
            _employeeRepository.Delete(EmployeeID);
            _employeeRepository.Save();
            return Ok();
        }
    }
}
