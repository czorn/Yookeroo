using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

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

        private BitmapImage _imageBitmap;
        public BitmapImage ImageBitmap
        {
            get
            {
                return _imageBitmap;
            }
            set
            {
                if (this._imageBitmap != value)
                {
                    this._imageBitmap = value;
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


        private DateTime _timestamp;
        public DateTime Timestamp
        {
            get
            {
                return _timestamp;
            }
            set
            {
                if (this._timestamp != value)
                {
                    this._timestamp = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private int _type = -1;
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
                    if (!ShowOptions())
                        Options = new ObservableCollection<string>();
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
				}
			}
		}

        private ObservableCollection<string> _options;
        public ObservableCollection<string> Options
        {
            get
            {
                return _options;
            }
            set
            {
                if (this._options != value)
                {
                    this._options = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private bool _isAnswered = false;
        public bool IsAnswered
        {
            get { return _isAnswered; }
            set { _isAnswered = value; NotifyPropertyChanged(); }
        }

        public enum Types
        {
            SelectOne,
            SelectMany,
            Open
        }

        public static List<Types> AllTypes = new List<Types>() { Types.SelectOne, Types.SelectMany, Types.Open };
        public static List<QuestionTypeDescription> TypeDescriptions = new List<QuestionTypeDescription>()
        {
            new QuestionTypeDescription() { Name = "Yes / No", Hint = "Select Yes or No", Type = Types.SelectOne },
            new QuestionTypeDescription() { Name = "Single Answer", Hint = "Select only one option", Type = Types.SelectOne },
            new QuestionTypeDescription() { Name = "Multiple Answers", Hint = "Select one or more options", Type = Types.SelectMany },
            new QuestionTypeDescription() { Name = "Open Answer", Hint = "Write a response", Type = Types.Open }
        };

        public Question()
        {
            Options = new ObservableCollection<string>();
            Type = 0;
            Text = "";
        }

        public bool ShowOptions()
        {
            return (Type == 1 || Type == 2);
        }
    }
}
