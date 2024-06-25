using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contactly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            
            
           
            
        }

    }
}
