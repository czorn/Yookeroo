using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yookeroo.Models
{
    public class Category : ModelBase
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

        private string _categoryName;
        public string CategoryName
        {
            get
            {
                return _categoryName;
            }
            set
            {
                if (this._categoryName != value)
                {
                    this._categoryName = value;
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

    }
}
