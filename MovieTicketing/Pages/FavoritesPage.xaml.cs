namespace MovieTicketing
{
    public partial class FavoritesPage : BasePage<FavoritesViewModel>
    {


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public FavoritesPage()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public FavoritesPage(FavoritesViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }





        #endregion



    }
}
