using System.ComponentModel.DataAnnotations;

namespace Root;
public class Persona
{
    [Required]
    public string Ig {get;set;}

    [Required]
    public string Nombre {get;set;}
}

