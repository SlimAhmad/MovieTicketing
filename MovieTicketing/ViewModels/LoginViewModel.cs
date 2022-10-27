using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MovieTicketing
{

    public partial class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        [ObservableProperty]
        private string email;



        /// <summary>
        /// The password of the user
        /// </summary>
        [ObservableProperty]
        private string password;

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        [ObservableProperty] 
        public bool loginIsRunning;

        #endregion

  
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
       
        }

        #endregion

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        [RelayCommand]
        public async Task LoginAsync()
        {
          
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task RegisterAsync()
        {

            // Go to register page?
            //await ViewModelApplication.GoToPageAsync(ApplicationPage.Register);

            await Task.Delay(1);
        }
    }
}

