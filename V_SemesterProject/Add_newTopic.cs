using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_SemesterProject
{
    public partial class Add_newTopic : Form
    {
        Project_Database pdb;
        loginData data;
        public Add_newTopic(loginData data)
        {   
            InitializeComponent();
            
            this.data = data;
            AuthorName_txt.Text = data.UserName;
            pdb = new Project_Database();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (!(string.IsNullOrWhiteSpace(TopicName_box.Text) && string.IsNullOrWhiteSpace(DiscussionBox.Text) && string.IsNullOrWhiteSpace(Comment_Box.Text)))
            {
                pdb.AddTopic(data.UserName, TopicName_box.Text, DiscussionBox.Text, Comment_Box.Text);
                TopicName_box.Clear();
                Comment_Box.Clear();
                DiscussionBox.Clear();
                this.Dispose();
            }
            else {

                MessageBox.Show("Please Fill all fields First!");
            }
            #endregion
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
