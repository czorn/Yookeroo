using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Yookeroo.Models
{
    public class __invalid_type__2
    {
        public string date { get; set; }
        public int timezone_type { get; set; }
        public string timezone { get; set; }
    }

    public class QuestionTimestamp
    {
        public string date { get; set; }
        public int timezone_type { get; set; }
        public string timezone { get; set; }
    }

    public class QuestionObject
    {
        public string __invalid_name__0 { get; set; }
        public string question_text { get; set; }
        public string __invalid_name__1 { get; set; }
        public string question_imagePath { get; set; }
        public __invalid_type__2 __invalid_name__2 { get; set; }
        public QuestionTimestamp question_timestamp { get; set; }
        public string __invalid_name__3 { get; set; }
        public string category_desc { get; set; }
        public string __invalid_name__4 { get; set; }
        public string questionType_desc { get; set; }
    }
}
