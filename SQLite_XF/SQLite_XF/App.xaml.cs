﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite_XF.DAO;
using Xamarin.Forms;

namespace SQLite_XF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.PersonListPage());
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
