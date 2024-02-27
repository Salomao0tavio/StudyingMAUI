using AppMaui.Views;

namespace AppMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateBtn_Clicked(object sender, EventArgs e)
        {            
            Navigation.PushAsync(new VeiculosDetail());            
        }

        private void NavigateBtn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToDo());
        }
    }

}
