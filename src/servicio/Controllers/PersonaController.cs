using Microsoft.AspNetCore.Mvc;
using Root;

namespace servicio.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonaController : ControllerBase
{
    [HttpGet]
    public List<Persona> GetNameId()
    {
        
    }

  
}