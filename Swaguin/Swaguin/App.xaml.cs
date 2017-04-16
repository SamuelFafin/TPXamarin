using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Swaguin
{
    public partial class App : Application
    {
        public static string dbPath { get; set; }
        public App(String dbPathApp)
        {
            InitializeComponent();

            dbPath = dbPathApp;

            MainPage = new Swaguin.ContactList();
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
