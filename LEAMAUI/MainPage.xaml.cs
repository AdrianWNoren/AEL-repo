namespace LEAMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ToggleSwitchMode(object sender, EventArgs e)
        {
            BackgroundColor = Color.FromArgb("#808080");
        }

    }

}
