using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Travel.Models;
using Xamarin.Forms;

namespace Travel.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        public ICommand BackBtnCommand => new Command(async () => await OnBackBtnPressed());
        private Location _destination;
        public Location Destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged();
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Location destination)
            {
                Destination = destination;
            }

            return base.InitializeAsync(navigationData);
        }

        private async Task OnBackBtnPressed()
        {
            try
            {
                await Navigation.NavigateBackAsync();
            }
            catch (Exception)
            {

            }
        }
    }
}
