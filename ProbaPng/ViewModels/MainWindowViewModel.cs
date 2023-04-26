using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ProbaPng.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private double _leftPosition = 100;
    [ObservableProperty] private double _topPosition = 100;
    
    [RelayCommand]
    void OnLeft()
    {
        if (LeftPosition >= 5.0)
        {
            LeftPosition -= 5.0;
        }
    }
    
    [RelayCommand]
    void OnRight()
    {
        if (LeftPosition <= MyReferences.MainWindowOb.Width - 100.0)
        {
            LeftPosition += 5.0;
        }
    }
    
    [RelayCommand]
    void OnUp()
    {
        if (TopPosition >= 5.0)
        {
            TopPosition -= 5.0;
        }
    }
    
    [RelayCommand]
    void OnDown()
    {
        if (TopPosition <= MyReferences.MainWindowOb.Height - 100.0)
        {
            TopPosition += 5.0;
        }
    }
}