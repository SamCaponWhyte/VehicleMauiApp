using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.Models
{
    public partial class Vehicle : ObservableObject
    {
        [ObservableProperty]
        private Guid id;

        [ObservableProperty]
        private string make;

        [ObservableProperty]
        private string model;

        [ObservableProperty]
        private string imageUrl;

        public Vehicle(string make, string model, string imgurl)
        {
            this.Id = Guid.NewGuid();
            this.Make = make;
            this.Model = model;
            this.ImageUrl = imgurl;
        }

    }
}