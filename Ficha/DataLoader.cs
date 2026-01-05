using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public static class DataLoader
    {
        public static List<Ritual> Rituais
        {
            get
            {
                return JsonSerializer.Deserialize<List<Ritual>>(File.ReadAllText("Data\\rituais.json"));
            }
        }

        public static List<Poder> Poderes
        {
            get
            {
                return JsonSerializer.Deserialize<List<Poder>>(File.ReadAllText("Data\\poderes.json"));
            }
        }

        public static List<ItemInventario> Itens
        {
            get
            {
                return JsonSerializer.Deserialize<List<ItemInventario>>(File.ReadAllText("Data\\itens.json"));
            }
        }

        public static List<Ataque> Armas
        {
            get
            {
                return JsonSerializer.Deserialize<List<Ataque>>(File.ReadAllText("Data\\armas.json"));
            }
        }
    }

}

