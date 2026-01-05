using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1
{
    internal static class DataLoaderHelpers
    {

        public static List<ItemInventario> Itens =>
            JsonSerializer.Deserialize<List<ItemInventario>>(File.ReadAllText("Data/itens.json"));

        public static List<Ataque> Armas =>
            JsonSerializer.Deserialize<List<Ataque>>(File.ReadAllText("Data/armas.json"));
    }
}