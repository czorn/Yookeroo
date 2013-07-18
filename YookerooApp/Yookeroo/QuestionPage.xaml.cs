using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Yookeroo.ViewModels;

namespace Yookeroo
{
    public partial class QuestionPage : PhoneApplicationPage
    {
        public QuestionPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if ((e.Content as Page) is ImagePage)
                ((e.Content as ImagePage).DataContext as ImageViewModel).ImageSource = new BitmapImage(new Uri((DataContext as QuestionViewModel).Question.ImageLoc, UriKind.Absolute));
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ImagePage.xaml", UriKind.Relative));
        }

        private void QuestionOption_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as QuestionViewModel).QuestionOption_Click(sender, e);
        }
    }
}