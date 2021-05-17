using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operations : ContentPage
    {
        public Operations()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.OperationsViewModel();

        }
    }
}