using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Yookeroo.Models;

namespace Yookeroo.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ObservableCollection<Question> _myFeed;
        public ObservableCollection<Question> MyFeed
        {
            get
            {
                return _myFeed;
            }
            set
            {
                if (this._myFeed != value)
                {
                    this._myFeed = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public HomeViewModel()
        {
            User user = new User() { Alias = "montawk", ProfileImageLoc = "/Assets/Design/user.png", Name = "Chris Zorn" };
            MyFeed = new ObservableCollection<Question>();
            for(int i = 0; i < 10; i++)
                MyFeed.Add(new Question() { Author = user, Text = "I'm thinking about buying a Surface Pro. Do you think I should get one? Let me know why!", TimeStamp = DateTime.Now });                
            
        }
    }
}