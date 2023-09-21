using System.Runtime.CompilerServices;

namespace PizzaPlaceRJRL.Shared;

public class Clientes
{
    public int Id {get; set;}

    public string Nombre {get; set;} = default!;

    public string Calle {get; set;} = default!;

    public string Ciudad {get; set;} = default!;
}