using GalaSoft.MvvmLight.Ioc;
using HockeyApp.Portable.Example.Services;
using Microsoft.Practices.ServiceLocation;

namespace HockeyApp.Portable.Example.iOS.Services
{
    public class iOSIoCService
    {
        public void RegisterServices()
        {
            SimpleIoc.Default.Register<IHockeyService, HockeyService>();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
        }
    }
}