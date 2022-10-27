namespace MovieTicketing
{
    public partial class SignUpPage : BasePage<SignUpViewModel>
    {


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SignUpPage()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public SignUpPage(SignUpViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }





        #endregion



    }
}
