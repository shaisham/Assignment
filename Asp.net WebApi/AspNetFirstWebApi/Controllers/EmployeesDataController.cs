using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetFirstWebApi.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] myEmployees = { "Rajesh", "shameer", "Sreehari" };
        [HttpGet]
        public string[] GetEmployees()
        {
            return myEmployees;
        }
        [HttpGet]
        public string GetEmployeesByIndex(int id)
        {
            return myEmployees[id];
        }

    }
}
