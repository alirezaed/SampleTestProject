using Microsoft.AspNetCore.Mvc;
using TestProject.Services;

namespace TestProject.Controllers
{
    public class UserController : ControllerBase
    {
        public IActionResult Index()
        {
            var list = new List<User>();
            list.Add(new User { Name = "Ahmad", Email = "ahmad@gmail.com" });
            list.Add(new User { Name = "Reza", Email = "reza@gmail.com" });
            list.Add(new User { Name = "Hosein", Email = "ahmad@gmail.com" });
            list.Add(new User { Name = "Ahmad2", Email = "ahmad2@gmail.com" });
            return Ok(list);
        }
    }
}
