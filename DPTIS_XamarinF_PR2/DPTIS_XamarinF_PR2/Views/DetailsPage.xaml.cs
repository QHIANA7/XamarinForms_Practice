using DPTIS_XamarinF_PR2.Models;
using DPTIS_XamarinF_PR2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DPTIS_XamarinF_PR2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        DetailsViewModel viewModel;

        public DetailsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new DetailsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as PracticeItem;
            if (item == null)
                return;

            await Navigation.PushAsync(item.Page);

            // Manually deselect item.
            itemsListView.SelectedItem = null;
        }
    }
}