using System.Text.Json.Serialization;

namespace AppMaui.Models
{
    public class Veiculo
    {
        public string tipoCombustivel;
        public int Ano;
        public string Cor;
        public string Modelo;
        public string Marca;
        public string Cidade;
        public string image_url;        
    }

    [JsonSerializable(typeof(List<Veiculo>))]
    internal sealed partial class VeiculoContext : JsonSerializerContext
    {
    }
}