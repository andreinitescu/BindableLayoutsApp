using ImageCircle.Forms.Plugin.UWP;

namespace BindableLayoutsApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            ImageCircleRenderer.Init();

            LoadApplication(new BindableLayoutsApp.App());
        }
    }
}
