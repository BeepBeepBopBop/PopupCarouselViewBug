using CommunityToolkit.Maui.Views;

namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var timerValuePopup = new TimerValuePopup(new TimerValueViewModel())
            {
                Size = new Size(Width, Height),
                HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center,
                VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center
            };

            // App is freezed after this called.
            var result = await Shell.Current.ShowPopupAsync(timerValuePopup);
        }
    }
}
