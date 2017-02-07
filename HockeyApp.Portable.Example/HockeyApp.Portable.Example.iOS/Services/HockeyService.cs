using System;
using HockeyApp.Portable.Example.Services;
using HockeyApp.iOS;

namespace HockeyApp.Portable.Example.iOS.Services
{
    public class HockeyService : IHockeyService
    {
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