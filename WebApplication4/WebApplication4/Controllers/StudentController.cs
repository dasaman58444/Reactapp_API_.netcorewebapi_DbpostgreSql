using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Data;
using WebApplication4.Repo;

namespace WebApplication4.Controllers
{
    [Route("student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("GetAllStudent")]
        public IActionResult GetStudentList(int id = 0)
        {
            StudentContext con = new StudentContext();
            //var data=con.GetStudentList();
            var data = con.GetStudentDatasFromDB(id);

            return Ok(data);
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] StudentData data)
        {

            StudentContext s = new StudentContext();
            s.InsertIntoStudent(data);
            return Ok(data);
        }

     

        [HttpGet]
        [Route("LoadAllData")]
        public IActionResult LoadAllData()
        {

            StudentContext s = new StudentContext();
            var res = s.LoadAllData();
            return Ok(res);
        }



    }
}
