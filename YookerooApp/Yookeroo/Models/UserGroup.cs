using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yookeroo.Models
{
    public class UserGroup : ModelBase
    {
        private long _id;
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (this._id != value)
                {
                    this._id = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private string _groupName;
        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                if (this._groupName != value)
                {
                    this._groupName = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private List<User> _members;
        public List<User> Members
        {
            get
            {
                return _members;
            }
            set
            {
                if (this._members != value)
                {
                    this._members = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
    }
}
