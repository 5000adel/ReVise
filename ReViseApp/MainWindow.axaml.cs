using Avalonia.Controls;
using ReViseApp.Views;
using ReViseApp.Models;

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
    private void Bikes_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = new Views.BikesView();
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