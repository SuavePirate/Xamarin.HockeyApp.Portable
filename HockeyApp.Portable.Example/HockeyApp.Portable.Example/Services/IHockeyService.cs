using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyApp.Portable.Example.Services
{
    public interface IHockeyService
    {
        void Init();
        void GetFeedback();
    }
}
