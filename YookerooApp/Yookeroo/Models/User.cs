using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yookeroo.Models
{
    public class User : ModelBase
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


        private string _alias;
        public string Alias
        {
            get
            {
                return _alias;
            }
            set
            {
                if (this._alias != value)
                {
                    this._alias = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (this._name != value)
                {
                    this._name = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (this._email != value)
                {
                    this._email = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        private string _profileImageLoc;
        public string ProfileImageLoc
        {
            get
            {
                return _profileImageLoc;
            }
            set
            {
                if (this._profileImageLoc != value)
                {
                    this._profileImageLoc = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
    }
}
