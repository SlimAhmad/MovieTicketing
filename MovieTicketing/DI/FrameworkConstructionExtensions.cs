using Dna;
using MovieTicketing;

namespace MovieTicketing
{
    /// <summary>
    /// Extension methods for the <see cref="FrameworkConstruction"/>
    /// </summary>
    public static class FrameworkConstructionExtensions
    {
        /// <summary>
        /// Injects the view models needed for jpr application
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddJPRViewModels(this FrameworkConstruction construction)
        {
            // Bind to a single instance of Application view model
            construction.Services.AddSingleton<ApplicationViewModel>();

            // Bind to a single instance of Settings view model
            construction.Services.AddSingleton<SettingsViewModel>();

            // Bind to a single instance of home view model
            construction.Services.AddSingleton<HomeViewModel>();

            // Bind to a single instance of details view model
            construction.Services.AddSingleton<LoginViewModel>();

    

            // Return the construction for chaining
            return construction;
        }

        /// <summary>
        /// Injects the Fasetto Word client application services needed
        /// for the Fasetto Word application
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddJPRClientServices(this FrameworkConstruction construction)
        {



            // Bind a UI Manager
         

            // Return the construction for chaining
            return construction;
        }
    }
}
