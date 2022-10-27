namespace MovieTicketing
{
    public partial class MainPage : BasePage<HomeViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public MainPage(HomeViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }

    }
}
