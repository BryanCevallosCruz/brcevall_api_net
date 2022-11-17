using Microsoft.AspNetCore.Mvc;
using Root;
using interfaz;

namespace servicio.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonaController : ControllerBase
{
        private readonly IPersonaAppService personaAppService;
    public PersonaController(IPersonaAppService personaAppService)
    {
        this.personaAppService = personaAppService;
    }

    [HttpGet]
    public List<Persona> GetNameId()
    {
        return personaAppService.GetNameId();
    }

  
}