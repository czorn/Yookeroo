using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Yookeroo.Models;

namespace Yookeroo.ViewModels
{
    public class GroupViewModel : ViewModelBase
    {
        private ObservableCollection<Question> _groupFeed;
        public ObservableCollection<Question> GroupFeed
        {
            get
            {
                return _groupFeed;
            }
            set
            {
                if (this._groupFeed != value)
                {
                    this._groupFeed = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        public GroupViewModel()
        {
            User user = new User() { Alias = "montawk", ProfileImageLoc = "/Assets/Design/user.png", Name = "Chris Zorn" };
            GroupFeed = new ObservableCollection<Question>();
            for (int i = 0; i < 10; i++)
                GroupFeed.Add(new Question() { Author = user, Text = "What color keyboard case should I get with my Surface?", TimeStamp = DateTime.Now });

        }


    }
}