using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using Microsoft.Phone.Controls;
using System.Runtime.CompilerServices;

namespace Yookeroo.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String info = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private Boolean _progressBarIsIndeterminate = true;
        public Boolean ProgressBarIsIndeterminate
        {
            get { return _progressBarIsIndeterminate; }
            set
            {
                if (_progressBarIsIndeterminate != value)
                {
                    _progressBarIsIndeterminate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Visibility _progressBarVisibility = Visibility.Visible;
        public Visibility ProgressBarVisibility
        {
            get { return _progressBarVisibility; }
            set
            {
                if (_progressBarVisibility != value)
                {
                    _progressBarVisibility = value;
                    NotifyPropertyChanged();
                }
            }
        }

        protected void ShowProgressBar()
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                ProgressBarVisibility = Visibility.Visible;
                ProgressBarIsIndeterminate = true;
            });
        }

        protected void HideProgresBar()
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                ProgressBarVisibility = Visibility.Collapsed;
                ProgressBarIsIndeterminate = false;
            });
        }


        protected void Navigate(Uri uri)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(uri);
        }

        protected void GoBack()
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).GoBack();
        }
    }
}
