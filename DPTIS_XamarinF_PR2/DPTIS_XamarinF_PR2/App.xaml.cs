using DPTIS_XamarinF_PR2.Data;
using DPTIS_XamarinF_PR2.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DPTIS_XamarinF_PR2
{
    public partial class App : Application
    {
        #region 다중 페이지 Xamarin.Forms App 탐색

        public static String FolderPath { get; private set; }

        #endregion

        #region 로컬 SQLite.NET 데이터베이스 응용

        static NoteDatabase database;

        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        #endregion

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
