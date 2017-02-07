using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HockeyApp.Portable.Example.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HockeyApp.Portable.Example
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IHockeyService _hockeyService;

        private ICommand _feedbackCommand;

        public ICommand FeedbackCommand
        {
            get
            {
                return _feedbackCommand ??
                    (_feedbackCommand = new RelayCommand(() => _hockeyService.GetFeedback()));
            }
        }
        public MainPageViewModel(IHockeyService hockeyService)
        {
            _hockeyService = hockeyService;
        }
    }
}
