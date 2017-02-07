using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyApp.Portable.Example.Services
{
    public class LocatorService
    {
        public IHockeyService HockeyService
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IHockeyService>();
            }
        }
    }
}
