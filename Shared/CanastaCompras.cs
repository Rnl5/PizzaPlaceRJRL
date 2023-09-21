namespace PizzaPlaceRJRL.Shared;

public class CanastaCompras
{
    public Clientes clientes {get; set;} = new Clientes();

    public List<int> Ordenes {get; set;} = new List<int>();

    public bool Pagado{get; set;}

    public void Agregar(int pizzaId) => Ordenes.Add(pizzaId);
}