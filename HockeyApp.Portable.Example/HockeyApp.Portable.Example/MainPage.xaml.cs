using HockeyApp.Portable.Example.Services;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HockeyApp.Portable.Example
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance<MainPageViewModel>();
        }

       
    }
}
