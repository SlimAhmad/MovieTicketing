namespace MovieTicketing
{
    public partial class HomePage : BasePage<HomeViewModel>
    {


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public HomePage()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public HomePage(HomeViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }





        #endregion



    }
}
