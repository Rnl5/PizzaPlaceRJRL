using System.Text.Json;

namespace PizzaPlaceRJRL.Extension;

public static class Depuracion
{
    private static JsonSerializerOptions opciones = new JsonSerializerOptions {WriteIndented = true};

    public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, opciones);
}