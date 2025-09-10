using Avalonia.Controls;
using ReViseApp.Views;

namespace ReViseApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ContentArea.Content = new Views.DashboardView();
    }

    private void Dashboard_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = new Views.DashboardView();
    }
    private void Vehicles_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = new Views.VehiclesView();
    }
    private void Logs_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = new Views.LogsView();
    }
    private void History_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = new Views.HistoryView();
    }
    private void Settings_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = new Views.SettingsView();
    }
}