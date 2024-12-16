using MauiApp1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class CommunityViewModel : ObservableObject
    {
        private static object ford_fiesta;
        [ObservableProperty]
        ObservableCollection<Vehicle> vehicles;

        private string _samplePictureUrl = "https://picsum.photos/300/200";
        private string _ford_fiestaUrl = "ford_fiesta.png";
        private string _ford_focusUrl = "ford_focus.png";
        private string _ford_mustangUrl = "ford_mustang.png";

        public CommunityViewModel()
        {
            this.Vehicles = new ObservableCollection<Vehicle>();
            AddSampleData();
        }

        void AddSampleData()
        {
            Vehicles.Add(new Vehicle("Ford", "Fiesta", _ford_fiestaUrl));
            Vehicles.Add(new Vehicle("Ford", "Focus", _ford_focusUrl));
            Vehicles.Add(new Vehicle("Ford", "Mustang", _ford_mustangUrl));
            Vehicles.Add(new Vehicle("Chevrolet", "Camaro", _samplePictureUrl));
            Vehicles.Add(new Vehicle("Chevrolet", "Corvette", _samplePictureUrl));
            Vehicles.Add(new Vehicle("Chevrolet", "Impala", _samplePictureUrl));
            Vehicles.Add(new Vehicle("Dodge", "Challenger", _samplePictureUrl));
            Vehicles.Add(new Vehicle("Dodge", "Charger", _samplePictureUrl));
            Vehicles.Add(new Vehicle("Dodge", "Viper", _samplePictureUrl));
        }
    }
}