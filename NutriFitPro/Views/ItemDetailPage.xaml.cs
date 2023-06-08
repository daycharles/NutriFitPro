using NutriFitPro.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NutriFitPro.Views
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