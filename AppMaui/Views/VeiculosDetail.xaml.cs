using AppMaui.ViewsModels;

namespace AppMaui.Views
{
    public partial class VehiclesDetail : ContentPage
    {

        public VehiclesDetail()
        {
            InitializeComponent();
            BindingContext = new VehicleViewModel();
        }        
    }
}
