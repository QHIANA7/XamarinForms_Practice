using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DPTIS_XamarinF_PR2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutPR_Page : ContentPage
    {
        public LayoutPR_Page()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.StyleId;

            Assembly assembly = GetType().GetTypeInfo().Assembly;
            Type pageType = assembly.GetType("DPTIS_XamarinF_PR2.Views." + id);
            Page page = (Page)Activator.CreateInstance(pageType);
            await Navigation.PushAsync(page);
        }
    }
}