namespace Urbanyo.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPageDemo();
        }
    }
}