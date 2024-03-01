using System.Text.Json.Serialization;

namespace AppMaui.Models
{
    public class Vehicle
    {
        public string tipoCombustivel { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cidade { get; set; }
        public string image_url{ get; set; }
    }

    [JsonSerializable(typeof(List<Vehicle>))]
    internal sealed partial class VehicleContext : JsonSerializerContext
    {
    }
}
