using Avalonia.Controls;
using ReViseApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReViseApp.Views
{
    public partial class BikesView : UserControl
    {
        public ObservableCollection<BikeModels> Motorcycles { get; } = new ObservableCollection<BikeModels>();

        public BikesView()
        {
            InitializeComponent();

            // Add sample motorcycles
            Motorcycles.Add(new BikeModels { Type = "Sport Bike", Brand = "Toyota", Model = "2020", Displacement = "2.0L" });
            Motorcycles.Add(new BikeModels { Type = "Motorcycle", Brand = "Honda", Model = "2019", Displacement = "600cc" });
            Motorcycles.Add(new BikeModels { Type = "Underbone", Brand = "Ford", Model = "2021", Displacement = "3.5L" });

            // Set the DataContext to this view itself
            DataContext = this;
        }
    }
}
