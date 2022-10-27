using MovieTicketing.Core;
using System.Diagnostics;

namespace MovieTicketing
{
    /// <summary>
    /// Extension method for 
    /// </summary>
    public static class PageHelper
    {

        /// <summary>
        /// Takes a <see cref="ApplicationPage"/> and a view model, if any, and creates the desired page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public static Page ToBasePage(this ApplicationPage page, object viewModel = null)
        {
            // Find the appropriate page
            switch (page)
            {
                case ApplicationPage.Login:
                    return new LoginPage(viewModel as LoginViewModel);

                case ApplicationPage.Main:
                    return new MainPage(viewModel as HomeViewModel);

               

                default:
                    Debugger.Break();
                    return null;
            }
        }

        /// <summary>
        /// Converts a <see cref="BasePage"/> to the specific <see cref="ApplicationPage"/> that is for that type of page
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static ApplicationPage ToApplicationPage(this BasePage page)
        {
            // Find application page that matches the base page
            if (page is LoginPage)
                return ApplicationPage.Login;

            if (page is LoginPage)
                return ApplicationPage.Login;

            if (page is LoginPage)
                return ApplicationPage.Register;

            // Alert developer of issue
            Debugger.Break();
            return default(ApplicationPage);
        }
    }
}
