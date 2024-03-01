using AppMaui.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text.Json;

namespace AppMaui.Services
{
    public static class VehicleService
    {
       private static List<Vehicle> vehiclesList = new();
        
       

        public static async Task<ObservableCollection<Vehicle>> GetAsync()
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync("vehiclesData.json");
                using var reader = new StreamReader(stream);
                var contents = await reader.ReadToEndAsync();
                vehiclesList = JsonSerializer.Deserialize(contents, VehicleContext.Default.ListVehicle);
                ObservableCollection<Vehicle> vehiclesCollection = new ObservableCollection<Vehicle>(vehiclesList);
                return vehiclesCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
