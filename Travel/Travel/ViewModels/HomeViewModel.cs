using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Travel.Autofac;
using Travel.Interfaces;
using Travel.Models;
using Travel.Services;
using Xamarin.Forms;

namespace Travel.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private IMockDbService MockDbService = DIContainer.MockDbService;
        public ICommand ViewDetailCommand => new Command<Location>(
            async (item) => await OnViewDetailPressed(item));

        private ObservableCollection<Location> _recommendedDestinations;
        public ObservableCollection<Location> RecommendedDestinations
        {
            get => _recommendedDestinations;
            set
            {
                _recommendedDestinations = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Location> _topDestinations;
        public ObservableCollection<Location> TopDestinations
        {
            get => _topDestinations;
            set
            {
                _topDestinations = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel()
        {
            RecommendedDestinations = new ObservableCollection<Location>(
                MockDbService.GetRecommendedItems());
            TopDestinations = new ObservableCollection<Location>(
                MockDbService.GetTopItems());
        }

        private async Task OnViewDetailPressed(Location item)
        {
            await Navigation.NavigateToAsync<DetailViewModel>(item);
        }
    }
}
