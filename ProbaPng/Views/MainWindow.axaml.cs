using Avalonia.Controls;
using Avalonia.Input;
using ProbaPng.ViewModels;

namespace ProbaPng.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MyReferences.MainWindowOb = this;
    }
}