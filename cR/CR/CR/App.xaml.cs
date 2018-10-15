﻿using System;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CR
{
    using Views;
    using Xamarin.Forms;

    public partial class App : Application
    {
        #region Constructors 
        public App()
        {
            InitializeComponent();

            this.MainPage = new LoginPage();
        }
        #endregion

        #region Metods
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
        #endregion

    }
}
