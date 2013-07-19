﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yookeroo.Models;
using System.Collections.ObjectModel;

namespace Yookeroo.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private ObservableCollection<Question> _questionsAsked;
        public ObservableCollection<Question> QuestionsAsked
        {
            get
            {
                return _questionsAsked;
            }
            set
            {
                if (this._questionsAsked != value)
                {
                    this._questionsAsked = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<User> _followers;
        public ObservableCollection<User> Followers
        {
            get
            {
                return _followers;
            }
            set
            {
                if (this._followers != value)
                {
                    this._followers = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

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

        public UserViewModel()
        {
            User = new User() { Alias = "LuisB", ProfileImageLoc = "https://profile-a.xx.fbcdn.net/hprofile-prn1/c40.40.502.502/s320x320/528328_10151694304239705_1563644218_n.jpg", Name = "Luis Bosquez", Bio = "Hi, my name is Luis and I'm currently a Program Manager intern at Microsoft. I like technology, music, sports and long walks on the beach AMA" };
            QuestionsAsked = new ObservableCollection<Question>();
            for (int i = 0; i < 10; i++)
                QuestionsAsked.Add(new Question() { Author = User, Text = "I'm thinking about buying a Surface Pro. Do you think I should get one? Let me know why!", Timestamp = DateTime.Now });
            Followers = new ObservableCollection<User>();
            for (int i = 0; i < 10; i++)
                Followers.Add(User);
        }
    }
}
