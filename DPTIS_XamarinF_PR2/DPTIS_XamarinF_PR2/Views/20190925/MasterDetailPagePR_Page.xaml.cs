using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DPTIS_XamarinF_PR2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPagePR_Page : MasterDetailPage
    {
        public MasterDetailPagePR_Page()
        {
            InitializeComponent();

            listView.SelectedItem = (listView.ItemsSource as IList)?[0];
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Show the detail page.
            IsPresented = false;
        }

        private void CallMasterButton_Clicked(object sender, EventArgs e)
        {
            IsPresented = true;
        }
    }
}