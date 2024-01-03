using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text;

namespace MauiApp6;

public partial class TimerValuePopup : Popup
{
    public TimerValuePopup(TimerValueViewModel timerValueViewModel)
    {
        InitializeComponent();
        BindingContext = new TimerValuePopupViewModel(timerValueViewModel);
        ResultWhenUserTapsOutsideOfPopup = null;
    }

    private void OnCancelButtonClicked(object sender, EventArgs e)
    {
        Close(null);
    }

    private void OnSetButtonClicked(object sender, EventArgs e)
    {
        Close(BindingContext);
    }

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
    }
}

public partial class TimerValuePopupViewModel : ObservableObject
{
    [ObservableProperty]
    private TimerValueViewModel _timerValueViewModel;

    [ObservableProperty]
    private int[] _values;

    public TimerValuePopupViewModel(TimerValueViewModel timerValueViewModel)
    {
        TimerValueViewModel = new TimerValueViewModel();
        Values = new int[] { 1, 2, 3, 4, 5 };
    }
}

public partial class TimerValueViewModel : ObservableObject
{
    [ObservableProperty]
    private int _selectedValue1;


    public TimerValueViewModel()
    {

    }
}