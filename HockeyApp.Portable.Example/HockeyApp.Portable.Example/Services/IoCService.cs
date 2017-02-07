using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyApp.Portable.Example.Services
{
    public class IoCService
    {
        public void RegisterViewModels()
        {
            SimpleIoc.Default.Register<MainPageViewModel>();
        }
    }
}
