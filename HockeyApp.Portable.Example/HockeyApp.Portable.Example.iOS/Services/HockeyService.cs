using System;
using HockeyApp.Portable.Example.Services;
using HockeyApp.iOS;
using HockeyApp.Portable.Example.iOS.Services;

[assembly: Xamarin.Forms.Dependency(typeof(HockeyService))]
namespace HockeyApp.Portable.Example.iOS.Services
{
    public class HockeyService : IHockeyService
    {
        public HockeyService()
        {
        }

        public void GetFeedback()
        {
            BITHockeyManager.SharedHockeyManager.FeedbackManager.ShowFeedbackListView();
        }

        public void Init()
        {
            var manager = BITHockeyManager.SharedHockeyManager;
            manager.Configure("HOCKEY_APP_ID");
            manager.StartManager();
        }
    }
}