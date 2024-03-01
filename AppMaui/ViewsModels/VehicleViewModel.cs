using AppMaui.Models;
using AppMaui.Services;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AppMaui.ViewsModels
{
    public partial class VehicleViewModel : BaseViewModel 
    {
        public ObservableCollection<Vehicle> Vehicles { get; } = new();
             

        public VehicleViewModel()
        {
            Title = "Vehicles";
            _ = LoadDataAsync();
        }

        [RelayCommand]
        public async Task LoadDataAsync()
            {   
            try
            {
                if (IsBusy)
                    return;

                IsBusy = true;

                if (Vehicles.Count != 0)
                    Vehicles.Clear();

                var vehicles = await VehicleService.GetAsync();

                foreach (var veiculo in vehicles)
                    Vehicles.Add(veiculo);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Nao foi possivel encontrar os veiculos: {ex.Message}");
                await Shell.Current.DisplayAlert("Erro!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }


}
