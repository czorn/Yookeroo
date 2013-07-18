using System;
using System.Net;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Yookeroo.Models;

namespace Yookeroo.ViewModels
{
    public class QuestionViewModel : ViewModelBase
    {
        //private User _user;
        //public User User
        //{
        //    get
        //    {
        //        return _user;
        //    }
        //    set
        //    {
        //        if (this._user != value)
        //        {
        //            this._user = value;
        //            this.NotifyPropertyChanged();
        //        }
        //    }
        //}

        private Question _question;
        public Question Question
        {
            get
            {
                return _question;
            }
            set
            {
                if (this._question != value)
                {
                    this._question = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<Answer> _answers;
        public ObservableCollection<Answer> Answers
        {
            get { return _answers;}
            set { _answers = value; this.NotifyPropertyChanged(); }
        }

        public QuestionViewModel()
        {
            User user = new User() { Alias = "montawk", ProfileImageLoc = "/Assets/Design/user.png", Name = "Chris Zorn" };
            Question = new Question() { Options = new ObservableCollection<string>()
                {
                    "Yes", "No"    
                },
                Author = user, ImageLoc = "http://a1.twimg.com/profile_images/85346276/Purple_Converse_Shoes_by_UndineCG_bigger.jpg", Text = "My name is... Shake-Zula. The mic-rula, The old schoolah, Ya wanna trip? I'll bring it to ya. Frylock and I'm on top, Rock you like a cop Meatwad you up next with your knock-knock. Meatwad make the money, see. Meatwad get the honeys, G. Drivin in my car, livin' like a star. Ice on my fingers and my toes and I'm a Taurus. What?\nShould I buy these shoes?", Timestamp = DateTime.Now };
            
            Answers = new ObservableCollection<Answer>();
            for (int i = 0; i < 20; i++)
                Answers.Add(new Answer() { Author = user, Timestamp = DateTime.Now, Response = "Yes, they are awesome" });
        }

        internal void QuestionOption_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Question.IsAnswered = true;
        }
    }
}