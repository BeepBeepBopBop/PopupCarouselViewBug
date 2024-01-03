using CommunityToolkit.Maui.Views;

namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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

            // App is frozen after this call.
            var result = await Shell.Current.ShowPopupAsync(timerValuePopup);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
        }
    }
}
