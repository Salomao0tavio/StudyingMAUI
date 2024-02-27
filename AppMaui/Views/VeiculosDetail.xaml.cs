using AppMaui.ViewsModels;

namespace AppMaui.Views
{
    public partial class VeiculosDetail : ContentPage
    {
        private readonly VeiculoViewModel _viewModel = new();

        public VeiculosDetail()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadDataAsync();
        }
    }
}
