using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DPTIS_XamarinF_PR2.Models
{
    //TabbedPagePR_Page, CarouselPageDemoPage, MasterDetailPagePR_Page에서 사용됩니다.
    public class NamedColor
    {
        public NamedColor()
        {
            ;
        }
        public NamedColor(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public string Name { set; get; }

        public Color Color { set; get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
