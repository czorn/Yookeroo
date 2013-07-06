using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Yookeroo
{
    public partial class HomePage : PhoneApplicationPage
    {
        public HomePage()
        {
            InitializeComponent();

            ApplicationBar = new ApplicationBar();
            ApplicationBar.Buttons.Add(new ApplicationBarIconButton() { IconUri = new Uri("/Assets/Design/question.png", UriKind.Relative), Text = "ask" });
            ApplicationBar.MenuItems.Add(new ApplicationBarMenuItem() { Text = "settings" });
            (ApplicationBar.Buttons[0] as ApplicationBarIconButton).Click += NewQuestionButton_Click;
        }

        private void NewQuestionButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/NewQuestionPage.xaml", UriKind.Relative));
        }
    }
}