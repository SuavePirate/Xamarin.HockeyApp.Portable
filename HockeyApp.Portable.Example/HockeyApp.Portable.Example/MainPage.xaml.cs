using HockeyApp.Portable.Example.Services;
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
        }

        private void Feedback_Clicked(object sender, EventArgs e)
        {
            HockeyManager.Current.GetFeedback();
        }
    }
}
