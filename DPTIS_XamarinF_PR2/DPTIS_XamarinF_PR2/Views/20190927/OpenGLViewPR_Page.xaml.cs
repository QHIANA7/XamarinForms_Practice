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
    public partial class OpenGLViewPR_Page : ContentPage
    {
        IOpenGLViewSharedCode sharedCode = DependencyService.Get<IOpenGLViewSharedCode>();

        public OpenGLViewPR_Page()
        {
            InitializeComponent();

            openGLView.IsVisible = sharedCode != null;
            regretsLabel.IsVisible = sharedCode == null;

            if (sharedCode != null)
            {
                openGLView.OnDisplay = sharedCode.RenderLoop;
                openGLView.Display();
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (sharedCode != null)
            {
                openGLView.HasRenderLoop = true;
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (sharedCode != null)
            {
                openGLView.HasRenderLoop = false;
            }
        }
    }

    public interface IOpenGLViewSharedCode
    {
        void RenderLoop(Rectangle rect);
    }
}