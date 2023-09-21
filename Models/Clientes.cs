using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PizzaPlaceRJRL.Shared;

public class Clientes
{
    [Key]
    public int Id {get; set;}

    [Required(ErrorMessage ="Por favor, inserte un nombre")]
    public string Nombre {get; set;} = default!;

    [Required(ErrorMessage ="Por favor, inserte una calle")]
    public string Calle {get; set;} = default!;

    [Required(ErrorMessage ="Por favor, inserte una ciudad")]
    public string Ciudad {get; set;} = default!;
}