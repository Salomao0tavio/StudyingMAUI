using AppMaui.Models;
using AppMaui.Services;
using AppMaui.ViewModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AppMaui.ViewsModels
{
    public partial class VeiculoViewModel : BaseViewModel 
    {
        public ObservableCollection<Veiculo> Veiculos { get; } = new();
        
        private VeiculoService VeiculoService;

        public VeiculoViewModel()
        {
            Title = "Veiculos";
            VeiculoService = new VeiculoService();
        }

        [RelayCommand]
        public async Task LoadDataAsync()
        {
            try
            {
                if (IsBusy)
                    return;

                IsBusy = true;

                if (Veiculos.Count != 0)
                    Veiculos.Clear();

                var veiculos = await VeiculoService.GetAsync();

                foreach (var veiculo in veiculos)
                    Veiculos.Add(veiculo);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Nao foi possivel encontrar os Veiculos: {ex.Message}");
                await Shell.Current.DisplayAlert("Erro!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }


}
