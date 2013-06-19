
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Animation;
namespace Yookeroo
{
    public partial class GroupLiveTile : UserControl
    {
        public GroupLiveTile()
        {
            InitializeComponent();
            Storyboard anim = (Storyboard)FindName("liveTileAnimTop");
            anim.Begin();

        }

        private void liveTileAnimTop_Completed_1(object sender, EventArgs e)
        {
            Storyboard anim = (Storyboard)FindName("liveTileAnimBottom");
            anim.Begin();
        }

        private void liveTileAnimBottom_Completed_1(object sender, EventArgs e)
        {
            Storyboard anim = (Storyboard)FindName("liveTileAnimTop");
            anim.Begin();
        }

        private void OnGroupTapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/GroupPage.xaml", UriKind.Relative));
        }
    }
}
