
using Root;
namespace interfaz;


public class PersonaAppService
{

    public List<Persona> GetNameId()
    {
        var client = new RestClient("https://rickandmortyapi.com/api/character");
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);


        //Console.WriteLine(response.Content);
    }

}


public interface IPersona
{
    Task<Persona> GetNameId();
    
}
