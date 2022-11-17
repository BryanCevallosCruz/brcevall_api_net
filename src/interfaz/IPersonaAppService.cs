using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Root;
namespace interfaz;

public interface IPersonaAppService
{
    List<Persona> GetNameId();
    
}
