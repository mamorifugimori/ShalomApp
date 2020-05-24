namespace ShalomApp
{
    using Xamarin.Forms;
    using Views;
    public partial class App : Application
    {
        #region Constructores
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage( new EnviarAlertaPage());
        }
        #endregion

        #region Metodos
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        } 
        #endregion
    }
}
