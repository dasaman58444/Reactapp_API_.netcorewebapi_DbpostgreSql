
using Microsoft.AspNetCore.Mvc;

using WebApplication4.Data;
using WebApplication4.Repo;


namespace WebApplication4.Controllers
{
  
        [Route("student")]
        public class RegistrationController : ControllerBase
        {
            IService service;
            IRepo repo;
            public RegistrationController(IService service1, IRepo repo1)
            {
                service = service1;
                repo = repo1;
            }

            [HttpGet]
            [Route("GetSomething")]
            public IActionResult GetSomething()
            {
                var res = service.Insert();

                return Ok(res);
            }

        }

    }

