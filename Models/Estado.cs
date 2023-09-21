namespace PizzaPlaceRJRL.Shared;

public class Estado
{
    public Menu Menu {get;} = new Menu();

    public CanastaCompras Canasta {get;} = new CanastaCompras();

    public Interfaz Interfaz {get; set;} = new Interfaz();

    public decimal PrecioTotal => Canasta.Ordenes.Sum(id => Menu.GetPizza(id)!.Precio);
}