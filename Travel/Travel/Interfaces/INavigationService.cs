using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Travel.ViewModels;

namespace Travel.Interfaces
{
    public interface INavigationService
    {
        Task NavigateBackAsync();
        Task NavigateToAsync(Type viewModelType);
        Task NavigateToAsync(Type viewModelType, object parameter);
        Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel;
        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel;
    }
}
