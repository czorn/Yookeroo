using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using Yookeroo.ViewModels;
using System.Windows.Input;
using System.Threading;
using Yookeroo.Models;
using Microsoft.Phone.Tasks;

namespace Yookeroo
{
    public partial class NewQuestionPage : PhoneApplicationPage
    {
        public NewQuestionPage()
        {
            InitializeComponent();

            ApplicationBar = new ApplicationBar();
            ApplicationBar.Buttons.Add(new ApplicationBarIconButton() { IconUri = new Uri("Assets/Design/send.png", UriKind.Relative), Text = "submit" });
            ApplicationBar.Buttons.Add(new ApplicationBarIconButton() { IconUri = new Uri("Assets/Design/camera.png", UriKind.Relative), Text = "camera" });
            ApplicationBar.Buttons.Add(new ApplicationBarIconButton() { IconUri = new Uri("Assets/Design/photos.png", UriKind.Relative), Text = "picture" });
            ApplicationBar.Buttons.Add(new ApplicationBarIconButton() { IconUri = new Uri("Assets/Design/barcode.png", UriKind.Relative), Text = "bar code" });

            (ApplicationBar.Buttons[0] as ApplicationBarIconButton).Click += SubmitQuestionButton_Click;
            (ApplicationBar.Buttons[1] as ApplicationBarIconButton).Click += TakePictureButton_Click;
            (ApplicationBar.Buttons[2] as ApplicationBarIconButton).Click += ChoosePictureButton_Click;

            //(DataContext as NewQuestionViewModel).Question.Options.Add("asd");
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if((e.Content as Page) is ImagePage)
                ((e.Content as ImagePage).DataContext as ImageViewModel).ImageSource = (DataContext as NewQuestionViewModel).Question.ImageBitmap;
        }

        private void TakePictureButton_Click(object sender, EventArgs e)
        {
            CameraCaptureTask cameraCaptureTaks = new CameraCaptureTask();
            cameraCaptureTaks.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
            cameraCaptureTaks.Show();
        }

        private void ChoosePictureButton_Click(object sender, EventArgs e)
        {
            PhotoChooserTask photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
            photoChooserTask.Show();
        }

        private void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);
                (DataContext as NewQuestionViewModel).Question.ImageBitmap = bmp;
                (DataContext as NewQuestionViewModel).Question.NotifyPropertyChanged();
            }
        }

        void SubmitQuestionButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddOption_Click(object sender, RoutedEventArgs e)
        {
            //TextBox textBox = new TextBox();
            //textBox.Margin = new Thickness(12, 0, 12, 0);

            //CustomMessageBox messageBox = new CustomMessageBox()
            //{
            //    LeftButtonContent = "add",
            //    RightButtonContent = "cancel",
            //    Content = textBox,
            //    Title = "add option"
            //};

            //messageBox.Dismissed += (s1, e1) =>
            //{
            //    switch (e1.Result)
            //    {
            //        case CustomMessageBoxResult.LeftButton:
            //            (DataContext as NewQuestionViewModel).Question.Options.Add(textBox.Text);
            //            break;
            //    }
            //};
            //textBox.KeyUp += (sender2, e2) =>
            //{
            //    if (e2.Key == Key.Enter)
            //        messageBox.Dismiss();
            //};
            //messageBox.Show();
            //messageBox.Loaded += (sender1, e1) => { textBox.Focus(); };
        }

        private void RemoveOption_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as NewQuestionViewModel).Question.Options.Remove((sender as Image).DataContext.ToString());
        }

        private void OnOptionTextboxKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string text = (sender as TextBox).Text.Trim();
                if (text != "")
                {
                    (DataContext as NewQuestionViewModel).Question.Options.Add(text);
                    (sender as TextBox).Text = "";
                    this.Focus();
                }
            }
        }

        private void QuestionTypeChanged(object sender, SelectionChangedEventArgs e)
        {
            //(DataContext as NewQuestionViewModel).Question.Type = (sender as ListPicker).SelectedIndex;

        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ImagePage.xaml", UriKind.Relative));
        }


    }
}