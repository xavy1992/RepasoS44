﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Repaso.Vistas;
namespace Repaso
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Inicio());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
