using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Yookeroo.Models;
using System.Windows.Media.Imaging;

namespace Yookeroo.ViewModels
{
    public class ImageViewModel : ViewModelBase
    {
        private BitmapImage _imageSource;
        public BitmapImage ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                if (this._imageSource != value)
                {
                    this._imageSource = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        
    }
}