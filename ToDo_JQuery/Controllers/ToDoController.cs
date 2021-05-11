using Microsoft.AspNetCore.Mvc;


namespace ToDo_JQuery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "ToDo";
        }
    }
}
