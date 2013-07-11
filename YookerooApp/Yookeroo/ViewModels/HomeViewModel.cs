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

        private ObservableCollection<User> _suggestedPeople;
        public ObservableCollection<User> SuggestedPeople
        {
            get
            {
                return _suggestedPeople;
            }
            set
            {
                if (this._suggestedPeople != value)
                {
                    this._suggestedPeople = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<UserGroup> _myGroups;
        public ObservableCollection<UserGroup> MyGroups
        {
            get
            {
                return _myGroups;
            }
            set
            {
                if (this._myGroups != value)
                {
                    this._myGroups = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public HomeViewModel()
        {
            User user = new User() { Alias = "montawk", ProfileImageLoc = "/Assets/Design/user.png", Name = "Chris Zorn" };
            MyFeed = new ObservableCollection<Question>();
            for(int i = 0; i < 10; i++)
                MyFeed.Add(new Question() { Author = user, Text = "I'm thinking about buying a Surface Pro. Do you think I should get one? Let me know why! Here is some extra text to see what it looks like", TimeStamp = DateTime.Now , NumResponses = 10});
            SuggestedPeople = new ObservableCollection<User>();
            for (int i = 0; i < 10; i++)
                SuggestedPeople.Add(user);

            UserGroup group = new UserGroup() { GroupName = "Family", ImageLoc = "/Assets/Design/IMG_0051.JPG" };
            MyGroups = new ObservableCollection<UserGroup>();
            for(int i = 0; i < 4; i++)
                MyGroups.Add(group);
        }
    }
}