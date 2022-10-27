using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MovieTicketing
{
    [ObservableObject]
    public partial class ApplicationViewModel
    {
        [ObservableProperty]
        public INavigation navigationService;

        [ObservableProperty]
        public Page pageService;

        [ObservableProperty]
        protected IApiService _appApiService;

        public ApplicationViewModel(IApiService appApiService) : base()
        {
            _appApiService = appApiService;
        }

        [RelayCommand]
        private async Task NavigateBack() =>
            await NavigationService.PopAsync();

        [RelayCommand]
        private async Task CloseModal() =>
            await NavigationService.PopModalAsync();
    }
}
