using System.ComponentModel.DataAnnotations;


public class Persona{
    public string cedula {get; set;} = string.Empty;
    public string nombre {get; set;} = string.Empty;
    public string apellido {get; set;} = string.Empty;
    public string telefono {get; set;} = string.Empty;
}

public class Aplicacion{
    public string Id {get; set;} = string.Empty;
    public Persona persona {get; set;} = new Persona();
    public string correo {get; set;} = string.Empty;
    public string direccion {get; set;} = string.Empty;
    public string estadoCivil {get; set;} = string.Empty;
    public string profesion {get; set;} = string.Empty;
    public string motivo {get; set;} = string.Empty;
    public List<Persona> amigos {get; set;} = new List<Persona>();
}

public class PersonaJce
{
    public string Cedula { get; set; } = string.Empty;
    public string Nombres { get; set; } = string.Empty;
    public string Apellido1 { get; set; } = string.Empty;
    public string Apellido2 { get; set; } = string.Empty;
    public string FechaNacimiento { get; set; } = string.Empty;
    public string LugarNacimiento { get; set; } = string.Empty;
    public string IdSexo { get; set; } = string.Empty;
    public string IdEstadoCivil { get; set; } = string.Empty;
    public string IDEstatus { get; set; } = string.Empty;
    public string EstatusCedulaAzul { get; set; } = string.Empty;
    public string CedulaAnterior { get; set; } = string.Empty;
    public bool ok { get; set; } 
    public string foto { get; set; } = string.Empty;
}