using AppMaui.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace AppMaui.Services
{
    public class VeiculoService
    {
        List<Veiculo> veiculosList = new();
        HttpClient _httpClient;

        public VeiculoService()
        {
            _httpClient = new();
        }

        public VeiculoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ObservableCollection<Veiculo>> GetAsync()
        {
            try
            {
                //api so retorna um veiculo a cada get (nao tem get all porque os dados sao aleatorios)                
                for (int i = 0; i < 2; i++)
                {

                      //var response = await _httpClient.GetFromJsonAsync<Veiculo>("https://random-data-api.com/api/v3/projects/c1cd8334-1a74-40b5-8926-ca7911f132b2?api_key=LS8tiVrMCylXe-FcGa-tZQ");

                    var response = new Veiculo
                    {
                        Ano = 2021,
                        Cidade = "São Paulo",
                        Cor = "Preto",
                        Marca = "Fiat",
                        Modelo = "Uno",
                        tipoCombustivel = "Gasolina",
                        image_url = "abcd"
                    };

                    if (response != null)
                        veiculosList.Add(response);
                }

                var veiculosCollection = new ObservableCollection<Veiculo>(veiculosList);
                return veiculosCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar veiculos", ex);
            }
        }
    }
}
