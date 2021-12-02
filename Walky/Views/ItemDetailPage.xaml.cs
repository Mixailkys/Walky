using System.ComponentModel;
using Walky.ViewModels;
using Xamarin.Forms;

namespace Walky.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}