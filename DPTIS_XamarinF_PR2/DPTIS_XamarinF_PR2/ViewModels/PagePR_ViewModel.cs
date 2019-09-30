using DPTIS_XamarinF_PR2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DPTIS_XamarinF_PR2.ViewModels
{
    public class PagePR_ViewModel
    {
        public ObservableCollection<PagePR_Item> Items { get; set; }

        public PagePR_ViewModel()
        {
            Items = new ObservableCollection<PagePR_Item>()
            {
                new PagePR_Item{ Text = "ContentPage", StyleId = "PagePR_Page"},
                new PagePR_Item{ Text = "MasterDetailPage", StyleId = "PagePR_Page"},
            };
        }
    }
}
