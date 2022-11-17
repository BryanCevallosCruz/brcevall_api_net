using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Root;
namespace interfaz;


public class PersonaAppService : IPersonaAppService
{
    public PersonaAppService()
    {
    }

    public List<Persona> GetNameId()
    {
        var client = new RestClient("https://rickandmortyapi.com/api/character");
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        

        return 
        //Console.WriteLine(response.Content);
    }

}
