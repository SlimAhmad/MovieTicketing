namespace MovieTicketing
{
    public partial class SeatsPage : BasePage<SeatsViewModel>
    {


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SeatsPage()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public SeatsPage(SeatsViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }





        #endregion



    }
}
