using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Live;
using Microsoft.Live.Controls;

namespace Yookeroo
{
    public partial class LoginPage : PhoneApplicationPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private LiveConnectClient client;

        private async void OnSignIn(object sender, LiveConnectSessionChangedEventArgs e)
        {
            if (e.Status == LiveConnectSessionStatus.Connected)
            {
                client = new LiveConnectClient(e.Session);
                LiveOperationResult operationResult = await client.GetAsync("me");
                try
                {
                    dynamic meResult = operationResult.Result;
                    if (meResult.first_name != null &&
                        meResult.last_name != null)
                    {
                        System.Diagnostics.Debug.WriteLine("Hello" + meResult.first_name + " " + meResult.last_name);
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Hello" + meResult.first_name + " " + meResult.last_name);
                    }
                }
                catch (LiveConnectException exception)
                {
                }
            }
            else
            {
            }
        }

        private void OnLogin(object sender, System.Windows.Input.GestureEventArgs e)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
        }
    }
}