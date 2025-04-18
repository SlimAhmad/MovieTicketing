﻿using Dna;

namespace MovieTicketing
{
    /// <summary>
    /// A shorthand access class to get DI services with nice clean short code
    /// </summary>
    public static class DI
    {


        /// <summary>
        /// A shortcut to access the <see cref="ApplicationViewModel"/>
        /// </summary>
        public static ApplicationViewModel ViewModelApplication => Framework.Service<ApplicationViewModel>();

        /// <summary>
        /// A shortcut to access the <see cref="SettingsViewModel"/>
        /// </summary>
        public static SettingsViewModel ViewModelSettings => Framework.Service<SettingsViewModel>();

   

        /// <summary>
        /// A shortcut to access the <see cref="HomeViewModel"/>
        /// </summary>
        public static HomeViewModel ViewModelHome => Framework.Service<HomeViewModel>();

      




    }
}

