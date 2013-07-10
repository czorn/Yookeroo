using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yookeroo.Models
{
    public class Question : ModelBase
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


        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (this._text != value)
                {
                    this._text = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        private string _imageLoc;
        public string ImageLoc
        {
            get
            {
                return _imageLoc;
            }
            set
            {
                if (this._imageLoc != value)
                {
                    this._imageLoc = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        private User _author;
        public User Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (this._author != value)
                {
                    this._author = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get
            {
                return _timeStamp;
            }
            set
            {
                if (this._timeStamp != value)
                {
                    this._timeStamp = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private int _type;
        public int Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (this._type != value)
                {
                    this._type = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private int _numResponses;
        public int NumResponses
        {
            get
            {
                return _numResponses;
            }
            set
            {
                if (this._numResponses != value)
                {
                    this._numResponses = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
    }
}
