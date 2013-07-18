using System;
using System.Windows;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Yookeroo;
using Yookeroo.Models;

namespace Yookeroo.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private User _currentUser;
        public User CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                if (this._currentUser != value)
                {
                    this._currentUser = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

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

        private ObservableCollection<Category> _myCategories;
        public ObservableCollection<Category> MyCategories
        {
            get
            {
                return _myCategories;
            }
            set
            {
                if (this._myCategories != value)
                {
                    this._myCategories = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
        public void GetFeed(string alias)
        {
            // form the URI 
            UriBuilder fullUri = new UriBuilder("http://peleadecangrejos.cloudapp.net/AppHack/SocialGDSS/getfeed.php");
            fullUri.Query = "user=" + alias;

            // initialize a new WebRequest 
            HttpWebRequest feedRequest = (HttpWebRequest)WebRequest.Create(fullUri.Uri);

            // set up the state object for the async request 
            FeedUpdateState feedState = new FeedUpdateState();
            feedState.AsyncRequest = feedRequest;

            // start the asynchronous request 
            feedRequest.BeginGetResponse(new AsyncCallback(HandleFeedResponse),
                feedState);
        }

        public void HandleFeedResponse(IAsyncResult asyncResult)
        {
            // get the state information 
            FeedUpdateState feedState = (FeedUpdateState)asyncResult.AsyncState;
            HttpWebRequest feedRequest = (HttpWebRequest)feedState.AsyncRequest;

            // end the async request 
            feedState.AsyncResponse = (HttpWebResponse)feedRequest.EndGetResponse(asyncResult);

            // get the stream containing the response from the async call 
            Stream streamResult;
            streamResult = feedState.AsyncResponse.GetResponseStream();
            //System.Diagnostics.Debug.WriteLine(streamResult.Read.ToString());
            List<QuestionObject> feed = new List<QuestionObject>();
            ObservableCollection<Question> tempFeed = new ObservableCollection<Question>();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<QuestionObject>));
            feed = (List<QuestionObject>)serializer.ReadObject(streamResult);
            System.Diagnostics.Debug.WriteLine("feed has " + feed.ToString() + "items");
            foreach (QuestionObject q in feed)
            {
               tempFeed.Add(new Question() { Author = CurrentUser, Text = q.question_text, TimeStamp = DateTime.Parse(q.question_timestamp.date) });
            }

            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                MyFeed = tempFeed;
            });
        }


        public HomeViewModel()
        {
            Category sample = new Category() { CategoryName = "coffee", ImageLoc = "/Assets/Design/coffee-beans.jpg"};
            MyCategories = new ObservableCollection<Category>();
            for ( int i = 0; i < 5; i ++) 
                MyCategories.Add(sample);

            CurrentUser = new User() { Alias = "LuisB", ProfileImageLoc = "/Assets/Design/user.png", Name = "Luis B" };
            SuggestedPeople = new ObservableCollection<User>();
            for (int i = 0; i < 10; i++)
                SuggestedPeople.Add(CurrentUser);
            GetFeed(CurrentUser.Alias);

            /****** DEAD CODE *******/
            /*for(int i = 0; i < 10; i++)
                MyFeed.Add(new Question() { Author = user, Text = "I'm thinking about buying a Surface Pro. Do you think I should get one? Let me know why! Here is some extra text to see what it looks like", TimeStamp = DateTime.Now , NumResponses = 10});*/

            /*UserGroup group = new UserGroup() { GroupName = "Family", ImageLoc = "/Assets/Design/IMG_0051.JPG" };
            MyGroups = new ObservableCollection<UserGroup>();
            for (int i = 0; i < 4; i++)
                MyGroups.Add(group);*/
        }
    }

    /// <summary> 
    /// State information for async call 
    /// </summary> 
    public class FeedUpdateState
    {
        public HttpWebRequest AsyncRequest { get; set; }
        public HttpWebResponse AsyncResponse { get; set; }
    } 

}