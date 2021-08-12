using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Collections;

namespace V_SemesterProject
{
    public class Project_Database
    {
        DiscussionPanel ds;

        //for creating connection
        #region connection_withDatabase
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "X1u1voEQzJ3tdCP9hy7dzRe4k4KehHFixZGJovIi",
            BasePath = "https://semester-project-v-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient firebaseClient;
        #endregion
        public Project_Database()
        {
            firebaseClient = new FireSharp.FirebaseClient(config);
           
        }

        // Method to login Account
        public async void LoginAccount(string userName,string password) {

            #region LoginAccount_byDatabase
            try
            {
                FirebaseResponse response = await firebaseClient.GetTaskAsync(@"LoginData/" + userName);

                loginData resultantData = response.ResultAs<loginData>();
                loginData Currentdata = new loginData
                {

                    UserName = userName,
                    pass = password

                };

                if (loginData.IsEqual(resultantData, Currentdata))
                {

                    ds = new DiscussionPanel(resultantData);
                    ds.Show();
                }
                else
                {
                    MessageBox.Show(loginData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check whether you connected to Internet or not!");
            }
            #endregion
        }


        // method to Create Account
        public async void CreateAccount_Func(string firstName, string lastName, string userName, string password)
        {

            #region CreateAcount_byDatabase
            loginData data = new loginData
            {
                FirstName = firstName,
                LastName = lastName,
                UserName = userName,
                pass = password

            };
            try
            {
                SetResponse response = await firebaseClient.SetTaskAsync(@"LoginData/" + data.UserName, data);
                loginData result = response.ResultAs<loginData>();

                MessageBox.Show("Account Created Successfully");
                
                ds = new DiscussionPanel(data);
                ds.Show();
            }
            catch (Exception ex) {
                MessageBox.Show("Please Check whether you connected to Internet or not!");
            }
            #endregion
        }

       
        // Add New Topic
        public async void AddTopic(string user_Name,string topicName,string discussion_details,string Comment) {

            #region Add Topic
            // topic number retrieval
            try
            {

            FirebaseResponse response = await firebaseClient.GetTaskAsync(@"TopicCounter/Node");
            TopicCounter getTopicCounter = response.ResultAs<TopicCounter>();
            int Topiccounter = Convert.ToInt32(getTopicCounter.counter);
                Topiccounter += 1;

               

            Comments cm = new Comments
            {
                 Comments_no = "0",
                 comment_Data =Comment,
                 userName =user_Name
            };



            DiscussionTopics Dt = new DiscussionTopics
            {
                 Topic_ID = Topiccounter.ToString(),
                 Topic_name = topicName,
                 Topic_author = user_Name,
                 Description = discussion_details,
              
            };

          
                SetResponse Addresponse = await firebaseClient.SetTaskAsync(@"DiscussionTopics/" + Dt.Topic_ID, Dt);
                SetResponse Addcommentresponse = await firebaseClient.SetTaskAsync(@"DiscussionTopics/" + Dt.Topic_ID+"/"+"CommentSection/"+ 0, cm);
                

                MessageBox.Show("Topic Add Successfully");

                NumberOfComments No = new NumberOfComments
                {
                    counter = "0"
                };
                TopicCounter Tc = new TopicCounter
                {
                    counter = Topiccounter.ToString()
                };
                SetResponse TopicResponse = await firebaseClient.SetTaskAsync(@"TopicCounter/Node", Tc);
                SetResponse CommentResponse = await firebaseClient.SetTaskAsync(@"CommentsCounter/T"+ Topiccounter, No);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check whether you connected to Internet or not!");
            }

            #endregion
        }




        // Discussion Panel show data method
        public async void ShowData(ListBox listBox) {
           #region getAllDataOfTopic_inListBox 
            int i = -1;
            
            List<CommentStorage> commentsStore;

            FirebaseResponse response = await firebaseClient.GetTaskAsync(@"TopicCounter/Node");
            TopicCounter getCounter = response.ResultAs<TopicCounter>();
            int Counter = Convert.ToInt32(getCounter.counter);
            
            while (true) 
            {
                if (i == Counter)
                {
                    break;
                }
               
                    i++;
                    try
                    {

                    FirebaseResponse response1 = await firebaseClient.GetTaskAsync(@"DiscussionTopics/"+i);
                    DiscussionTopics getData = response1.ResultAs<DiscussionTopics>();
                    
                   
                    FirebaseResponse CommentCounterresponse = await firebaseClient.GetTaskAsync(@"CommentsCounter/T"+i);
                    NumberOfComments getCommentCounter = CommentCounterresponse.ResultAs<NumberOfComments>();
                    int val = Convert.ToInt32(getCommentCounter.counter);

                    //we need to initialize it again and again for each topic .. to comments ....
                    commentsStore = new List<CommentStorage>();

                    for (int j = 0; j <=val; j++)
                    {
                        
                        FirebaseResponse response2 = await firebaseClient.GetTaskAsync(@"DiscussionTopics/" + i + "/CommentSection/" + j);
                        Comments getData2 = response2.ResultAs<Comments>();
                        commentsStore.Add(new CommentStorage(getData2.Comments_no,getData2.comment_Data, getData2.userName));

                    }

                    MegaDataStore megaDataStore = new MegaDataStore(getData.Topic_ID, getData.Topic_name, getData.Topic_author, getData.Description, commentsStore);

                   
                    listBox.Items.Add(megaDataStore);
                }
                    catch (Exception ex)
                    {
                    }
                
            }

            DiscussionPanel.loadingSplash.Visible = false;
            DiscussionPanel.panelDiscuss.Visible = true;
            DiscussionPanel.panelDiscuss.BringToFront();
            

            #endregion
        }


        // Method to add Comments
        public async void AddComments(string user_Name,string add_comment,int Topicindex)
        {
            #region AddComments
            int commentIndex = DiscussionPanel.currentCommentIndex+1;
            
           
            if (Topicindex >= 0)
            {
                Comments cm = new Comments
                {
                    Comments_no = commentIndex.ToString(),
                    comment_Data = add_comment,
                    userName = user_Name
                };
                NumberOfComments No = new NumberOfComments
                {
                    counter = commentIndex.ToString()
                };

                SetResponse Addcommentresponse = await firebaseClient.SetTaskAsync(@"DiscussionTopics/" + Topicindex + "/" + "CommentSection/" + commentIndex, cm);
               
                SetResponse CommentResponse = await firebaseClient.SetTaskAsync(@"CommentsCounter/T" + Topicindex, No);

                Console.WriteLine("Added comment" + add_comment);
            }
            else {

                MessageBox.Show("please select a topic first");

            }
#endregion
        }



        // method to check for Comments Continously
        public async void CheckCommentsComming(int currentTopicIndex, RichTextBox AllComment_box, ListBox topicsList) {

            #region  CheckCommentsComming
            int currentCommentIndex;
           
            currentCommentIndex = DiscussionPanel.currentCommentIndex;

            List<CommentStorage> commentsStore = new List<CommentStorage>();

            FirebaseResponse CommentCounterresponse = await firebaseClient.GetTaskAsync(@"CommentsCounter/T" + currentTopicIndex);
            NumberOfComments getCommentCounter = CommentCounterresponse.ResultAs<NumberOfComments>();
            int newIndex = Convert.ToInt32(getCommentCounter.counter);
           
            if (newIndex > currentCommentIndex) {
               
                FirebaseResponse response2 = await firebaseClient.GetTaskAsync(@"DiscussionTopics/" + currentTopicIndex + "/CommentSection/" + newIndex);
                Comments getData2 = response2.ResultAs<Comments>();
               

                MegaDataStore megaDataStore=topicsList.Items[currentTopicIndex] as MegaDataStore;
                MegaDataStore NewmegaDataStore;
                for (int i = 0; i < megaDataStore.comment.Count; i++)
                { 
                    commentsStore.Add(new CommentStorage(megaDataStore.comment[i].Comments_no, megaDataStore.comment[i].comment_Data, megaDataStore.comment[i].userName));
                }
                commentsStore.Add(new CommentStorage(getData2.Comments_no, getData2.comment_Data, getData2.userName));
                NewmegaDataStore = new MegaDataStore(megaDataStore.Topic_ID, megaDataStore.Topic_name, megaDataStore.Topic_author, megaDataStore.Description, commentsStore);
                
                topicsList.Items[currentTopicIndex] = NewmegaDataStore;
                DiscussionPanel.currentCommentIndex =Convert.ToInt32(NewmegaDataStore.comment[NewmegaDataStore.comment.Count - 1].Comments_no);
              
            }
            #endregion
        }




        // method to check for Topic Continously
        public async void CheckTopic(ListBox topicsList) {
            #region topics Checker
            List<CommentStorage> commentsStore;
            int numberOfTopics = topicsList.Items.Count - 1;
           
            FirebaseResponse response = await firebaseClient.GetTaskAsync(@"TopicCounter/Node");
            TopicCounter getCounter = response.ResultAs<TopicCounter>();
            int TopicNewCounter = Convert.ToInt32(getCounter.counter);
           

            if (numberOfTopics < TopicNewCounter) {
                
                FirebaseResponse response1 = await firebaseClient.GetTaskAsync(@"DiscussionTopics/" + TopicNewCounter);
                DiscussionTopics getData = response1.ResultAs<DiscussionTopics>();


                FirebaseResponse CommentCounterresponse = await firebaseClient.GetTaskAsync(@"CommentsCounter/T" + TopicNewCounter);
                NumberOfComments getCommentCounter = CommentCounterresponse.ResultAs<NumberOfComments>();
                int val = Convert.ToInt32(getCommentCounter.counter);

                
                commentsStore = new List<CommentStorage>();

                for (int j = 0; j <= val; j++)
                {

                    FirebaseResponse response2 = await firebaseClient.GetTaskAsync(@"DiscussionTopics/" + TopicNewCounter + "/CommentSection/" + j);
                    Comments getData2 = response2.ResultAs<Comments>();
                    commentsStore.Add(new CommentStorage(getData2.Comments_no, getData2.comment_Data, getData2.userName));

                }

                MegaDataStore megaDataStore = new MegaDataStore(getData.Topic_ID, getData.Topic_name, getData.Topic_author, getData.Description, commentsStore);


                topicsList.Items.Add(megaDataStore);
               

            }
            #endregion

        }
    }




    // login data info class
    public class loginData
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string pass { get; set; }

        public static string ErrorMessage;
        public static bool IsEqual(loginData dbData, loginData EnteredData) {

            #region conditionTo_check_ifDataCorectOrNot
            if (dbData == null || EnteredData == null) {
                ErrorMessage = "Please Enter Values First";
                return false;
            }
            else
            if (dbData.UserName != EnteredData.UserName || dbData.pass != EnteredData.pass)
            {
                ErrorMessage = "Please Enter Correct Email And Pass";
                return false;
            }

            return true;
            #endregion
        }
       
        }

    
    // class for having data related to Topics in discussion Panel

    public class DiscussionTopics { 
    

        public string Topic_ID { get; set; }
        public string Topic_name { get; set; }
        public string Topic_author { get; set; }
        public string Description { get; set; }
        public Comments Comment { get; set; }

       

    }


    // class for creating  topic id
    public class TopicCounter {

        public string counter { get; set; }

    }

    // class for comments nodes
    public class Comments { 
         public string Comments_no { get; set; }
         public string comment_Data { get; set; }
         public string userName { get; set; } 

    }

    // clas to count for number of comments
    public class NumberOfComments {
        public string counter { get; set; }
    }


    
    public class CommentStorage {

        public string Comments_no { get; set; }
        public string comment_Data { get; set; }
        public string userName { get; set; }
        public CommentStorage(string Comments_no, string comment_Data, string userName) {
            this.Comments_no = Comments_no;
            this.comment_Data = comment_Data;
            this.userName = userName;
        }

    }

}
    
    
    
    


