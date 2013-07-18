using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Yookeroo.Models;

namespace Yookeroo.ViewModels
{
    public class NewQuestionViewModel : ViewModelBase
    {
        private Question _question;
        public Question Question
        {
            get
            {
                return _question;
            }
            set
            {
                if (this._question != value)
                {
                    this._question = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<QuestionTypeDescription> _types;
        public ObservableCollection<QuestionTypeDescription> Types
        {
            get
            {
                return _types;
            }
            set
            {
                if (this._types != value)
                {
                    this._types = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<Category> _categories;
        public ObservableCollection<Category> Categories 
        {
            get
            {
                return _categories;
            }
            set
            {
                if (this._categories != value)
                {
                    this._categories = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
       

        public NewQuestionViewModel()
        {
            User user = new User() { Alias = "montawk", ProfileImageLoc = "/Assets/Design/user.png", Name = "Chris Zorn", Bio = "I’m your dope-ass divinity, trollin’ with My trinity, tossin’ top tweets in your immediate vicinity, flingin’ fly phrases from the fringes of infinity." };
            Question = new Question() { Author = user };
            Types = new ObservableCollection<QuestionTypeDescription>(Yookeroo.Models.Question.TypeDescriptions);
            Categories = new ObservableCollection<Category>();
            Categories.Add(new Category() { CategoryName = "Shopping" });
            Categories.Add(new Category() { CategoryName = "Computer Science" });
            Categories.Add(new Category() { CategoryName = "Food and Dining" });
            Categories.Add(new Category() { CategoryName = "Events" });
            Categories.Add(new Category() { CategoryName = "Sports" });
            Categories.Add(new Category() { CategoryName = "Music" });
        }
    }
}