using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yookeroo.Models
{
    public class Answer : ModelBase
    {
        private string _response;
        public string Response
        {
            get { return _response; }
            set { _response = value; NotifyPropertyChanged(); }
        }

        private User _author;
        public User Author
        {
            get { return _author; }
            set { _author = value; NotifyPropertyChanged(); }
        }

        private DateTime _timestamp;
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; NotifyPropertyChanged(); }
        }
    }
}
