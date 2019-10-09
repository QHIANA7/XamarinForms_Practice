using DPTIS_XamarinF_PR2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using OpenTK.Graphics.ES30;

[assembly: Dependency(typeof(DPTIS_XamarinF_PR2.Shared.OpenGLViewSharedCode))]

namespace DPTIS_XamarinF_PR2.Shared
{
    public class OpenGLViewSharedCode : IOpenGLViewSharedCode
    {
        DateTime startTime = DateTime.Now;

        public void RenderLoop(Rectangle rect)
        {
            // Seconds since the program started
            double seconds = (DateTime.Now - startTime).TotalSeconds;

            // t from 0 to 1 every 5 seconds
            double t = (seconds % 5) / 5;

            // Find a Xamarin.Forms color
            Color color = Color.FromHsla(t, 1.0, 0.5, 1.0);

            // Set background color using OpenGL
            GL.ClearColor((float)color.R, (float)color.G, (float)color.B, 1.0f);
            GL.Clear((ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit));
        }
    }
}
