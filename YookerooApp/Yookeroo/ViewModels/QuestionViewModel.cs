using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Yookeroo.Models;

namespace Yookeroo.ViewModels
{
    public class QuestionViewModel : ViewModelBase
    {
        private User _user;
        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                if (this._user != value)
                {
                    this._user = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

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

        private ObservableCollection<User> _responders;
        public ObservableCollection<User> Responders
        {
            get
            {
                return _responders;
            }
            set
            {
                if (this._responders != value)
                {
                    this._responders = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        ObservableCollection<string> _x;
        public ObservableCollection<string> x
        {
            get
            {
                return _x;
            }
            set
            {
                if (this._x != value)
                {
                    this._x = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public QuestionViewModel()
        {
            User = new User() { Alias = "montawk", ProfileImageLoc = "/Assets/Design/user.png", Name = "Chris Zorn" };
            Question = new Question() { Author = User, ImageLoc = "/Assets/Design/squareImage.png", Text = "My name is... Shake-Zula. The mic-rula, The old schoolah, Ya wanna trip? I'll bring it to ya. Frylock and I'm on top, Rock you like a cop Meatwad you up next with your knock-knock. Meatwad make the money, see. Meatwad get the honeys, G. Drivin in my car, livin' like a star. Ice on my fingers and my toes and I'm a Taurus. What?\nShould I buy these shoes?", TimeStamp = DateTime.Now };
            x = new ObservableCollection<string>();
            Responders = new ObservableCollection<User>();
            for (int i = 0; i < 20; i++)
                Responders.Add(User);
        }
    }
}