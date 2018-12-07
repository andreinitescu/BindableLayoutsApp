using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace BindableLayoutsApp
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
            BindingContext = new UserProfileViewModel();
        }
    }

    class TechItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate XamarinFormsItemTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (string)item == "Xamarin Forms" ? XamarinFormsItemTemplate : DefaultTemplate;
        }
    }
}
