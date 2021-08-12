using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace V_SemesterProject
{
    public partial class DiscussionPanel : Form
    {
        Project_Database pdb;
        loginData data;
        public static Panel loadingSplash;
        public static Panel panelDiscuss;

        public static int currentCommentIndex { get; set; }
        static int currentTopicIndex;
        
        List<MegaDataStore> storeAllData;
        List<CommentStorage> storeAllCommentData;
        public static Boolean setStatus { get; set; }
       

        public DiscussionPanel(loginData data)
        {
            InitializeComponent();

            loadingSplash = panelLoading;

            panelDiscuss = panel1;
        
            this.data = data;
            ProfileName_lb.Text = data.FirstName+" "+data.LastName;

            storeAllData = new List<MegaDataStore>();
            storeAllCommentData = new List<CommentStorage>();
            pdb = new Project_Database();
            pdb.ShowData(TopicsList_box);
            panel1.Visible = false;
            panelLoading.BringToFront();

          
            
        }
        // load event
        private void DiscussionPanel_Load(object sender, EventArgs e)
        {
            
            timerForCommentChecker.Start();
            TimeForTopicLists.Start();
        }

        // add topic
        private void AddTopic_btn_Click(object sender, EventArgs e)
        {
            Add_newTopic addTopic = new Add_newTopic(data);
            addTopic.ShowDialog();
           
        }

        // select topics
        private void TopicsList_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TopicsList_box.SelectedItem != null)
            {
                AllComment_box.Clear();

                DisplayData();
            }
            else {
                TopicsList_box.SetSelected(0, true);
            }
            
        }

        // send message
        private void send_btn_Click(object sender, EventArgs e)
        {
            #region  send message
            if (!(string.IsNullOrWhiteSpace(Comment_Box.Text)))
            {
                
               
                pdb.AddComments(ProfileName_lb.Text, Comment_Box.Text, currentTopicIndex);
                Comment_Box.Clear();
            }
            #endregion
        }


        // thread to check for where new item added on list or list or not
        private void TimeForTopicLists_Tick(object sender, EventArgs e)
        {  

            pdb.CheckTopic(TopicsList_box);
        }

        // timer to check for comments
        private void timerForCommentChecker_Tick(object sender, EventArgs e)
        {
            #region  CommentChecker
            currentTopicIndex = TopicsList_box.SelectedIndex;
            if (currentTopicIndex >= 0)
            {
               
                pdb.CheckCommentsComming(currentTopicIndex, AllComment_box, TopicsList_box);

            }
            #endregion
        }



        // method to display all the Data
        void DisplayData()
        {
            #region displayData
            
            

                MegaDataStore megaDataStore = TopicsList_box.SelectedItem as MegaDataStore;
                setStatus = true;


                CreatedBy_txt.Text = megaDataStore.Topic_author;
                TopicHeading_txt.Text = megaDataStore.Topic_name;
                discriptionBox_txt.Text = megaDataStore.Description;
                storeAllCommentData = megaDataStore.comment;
                for (int j = 0; j < storeAllCommentData.Count; j++)
                {
                    AllComment_box.Text +=megaDataStore.comment[j].userName + ":\n";
                    AllComment_box.Text += "          " + megaDataStore.comment[j].comment_Data + "\n";
                }
            currentTopicIndex = TopicsList_box.SelectedIndex;
            currentCommentIndex = Convert.ToInt32(megaDataStore.comment[storeAllCommentData.Count-1].Comments_no);
           
            #endregion
        }

        
        
    }
}
