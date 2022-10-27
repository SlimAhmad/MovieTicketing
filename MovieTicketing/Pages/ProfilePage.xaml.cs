namespace MovieTicketing
{
    public partial class ProfilePage : BasePage<ProfileViewModel>
    {


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProfilePage()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public ProfilePage(ProfileViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }





        #endregion



    }
}
