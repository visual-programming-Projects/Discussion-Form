
namespace V_SemesterProject
{
    partial class DiscussionPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DicussionTopics_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AlComentsLb = new System.Windows.Forms.Label();
            this.TopicHeading_txt = new System.Windows.Forms.TextBox();
            this.TopicHeading_lb = new System.Windows.Forms.Label();
            this.TopicsList_box = new System.Windows.Forms.ListBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.AllComment_box = new System.Windows.Forms.RichTextBox();
            this.Comment_Box = new System.Windows.Forms.RichTextBox();
            this.Comment_lb = new System.Windows.Forms.Label();
            this.discription_lb = new System.Windows.Forms.Label();
            this.discriptionBox_txt = new System.Windows.Forms.RichTextBox();
            this.CreatedBy_txt = new System.Windows.Forms.TextBox();
            this.AuthorName_lb = new System.Windows.Forms.Label();
            this.ProfileName_lb = new System.Windows.Forms.Label();
            this.AddTopic_btn = new System.Windows.Forms.Button();
            this.TimeForTopicLists = new System.Windows.Forms.Timer(this.components);
            this.timerForCommentChecker = new System.Windows.Forms.Timer(this.components);
            this.panelLoading = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.DicussionTopics_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.DicussionTopics_tab);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 404);
            this.panel1.TabIndex = 0;
            // 
            // DicussionTopics_tab
            // 
            this.DicussionTopics_tab.Controls.Add(this.tabPage1);
            this.DicussionTopics_tab.Location = new System.Drawing.Point(0, 0);
            this.DicussionTopics_tab.Name = "DicussionTopics_tab";
            this.DicussionTopics_tab.SelectedIndex = 0;
            this.DicussionTopics_tab.Size = new System.Drawing.Size(783, 404);
            this.DicussionTopics_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AlComentsLb);
            this.tabPage1.Controls.Add(this.TopicHeading_txt);
            this.tabPage1.Controls.Add(this.TopicHeading_lb);
            this.tabPage1.Controls.Add(this.TopicsList_box);
            this.tabPage1.Controls.Add(this.send_btn);
            this.tabPage1.Controls.Add(this.AllComment_box);
            this.tabPage1.Controls.Add(this.Comment_Box);
            this.tabPage1.Controls.Add(this.Comment_lb);
            this.tabPage1.Controls.Add(this.discription_lb);
            this.tabPage1.Controls.Add(this.discriptionBox_txt);
            this.tabPage1.Controls.Add(this.CreatedBy_txt);
            this.tabPage1.Controls.Add(this.AuthorName_lb);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Discussion Topic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AlComentsLb
            // 
            this.AlComentsLb.AutoSize = true;
            this.AlComentsLb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlComentsLb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AlComentsLb.Location = new System.Drawing.Point(10, 135);
            this.AlComentsLb.Name = "AlComentsLb";
            this.AlComentsLb.Size = new System.Drawing.Size(108, 19);
            this.AlComentsLb.TabIndex = 12;
            this.AlComentsLb.Text = "All Comments:";
            // 
            // TopicHeading_txt
            // 
            this.TopicHeading_txt.Enabled = false;
            this.TopicHeading_txt.Location = new System.Drawing.Point(433, 54);
            this.TopicHeading_txt.Name = "TopicHeading_txt";
            this.TopicHeading_txt.Size = new System.Drawing.Size(283, 26);
            this.TopicHeading_txt.TabIndex = 11;
            // 
            // TopicHeading_lb
            // 
            this.TopicHeading_lb.AutoSize = true;
            this.TopicHeading_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicHeading_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TopicHeading_lb.Location = new System.Drawing.Point(317, 57);
            this.TopicHeading_lb.Name = "TopicHeading_lb";
            this.TopicHeading_lb.Size = new System.Drawing.Size(110, 19);
            this.TopicHeading_lb.TabIndex = 10;
            this.TopicHeading_lb.Text = "Topic Heading:";
            // 
            // TopicsList_box
            // 
            this.TopicsList_box.FormattingEnabled = true;
            this.TopicsList_box.ItemHeight = 19;
            this.TopicsList_box.Location = new System.Drawing.Point(7, 10);
            this.TopicsList_box.Name = "TopicsList_box";
            this.TopicsList_box.ScrollAlwaysVisible = true;
            this.TopicsList_box.Size = new System.Drawing.Size(304, 118);
            this.TopicsList_box.TabIndex = 4;
            this.TopicsList_box.SelectedIndexChanged += new System.EventHandler(this.TopicsList_box_SelectedIndexChanged);
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.send_btn.Location = new System.Drawing.Point(659, 332);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(89, 25);
            this.send_btn.TabIndex = 3;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // AllComment_box
            // 
            this.AllComment_box.Location = new System.Drawing.Point(9, 157);
            this.AllComment_box.Name = "AllComment_box";
            this.AllComment_box.ReadOnly = true;
            this.AllComment_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.AllComment_box.Size = new System.Drawing.Size(332, 200);
            this.AllComment_box.TabIndex = 5;
            this.AllComment_box.Text = "";
            // 
            // Comment_Box
            // 
            this.Comment_Box.Location = new System.Drawing.Point(347, 289);
            this.Comment_Box.Name = "Comment_Box";
            this.Comment_Box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.Comment_Box.Size = new System.Drawing.Size(412, 37);
            this.Comment_Box.TabIndex = 0;
            this.Comment_Box.Text = "";
            // 
            // Comment_lb
            // 
            this.Comment_lb.AutoSize = true;
            this.Comment_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Comment_lb.Location = new System.Drawing.Point(371, 267);
            this.Comment_lb.Name = "Comment_lb";
            this.Comment_lb.Size = new System.Drawing.Size(109, 19);
            this.Comment_lb.TabIndex = 3;
            this.Comment_lb.Text = "Add Comment:";
            // 
            // discription_lb
            // 
            this.discription_lb.AutoSize = true;
            this.discription_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discription_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.discription_lb.Location = new System.Drawing.Point(517, 90);
            this.discription_lb.Name = "discription_lb";
            this.discription_lb.Size = new System.Drawing.Size(87, 19);
            this.discription_lb.TabIndex = 8;
            this.discription_lb.Text = "Discription:";
            // 
            // discriptionBox_txt
            // 
            this.discriptionBox_txt.Location = new System.Drawing.Point(410, 112);
            this.discriptionBox_txt.Name = "discriptionBox_txt";
            this.discriptionBox_txt.ReadOnly = true;
            this.discriptionBox_txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.discriptionBox_txt.Size = new System.Drawing.Size(316, 135);
            this.discriptionBox_txt.TabIndex = 6;
            this.discriptionBox_txt.Text = "";
            // 
            // CreatedBy_txt
            // 
            this.CreatedBy_txt.Enabled = false;
            this.CreatedBy_txt.Location = new System.Drawing.Point(452, 10);
            this.CreatedBy_txt.Name = "CreatedBy_txt";
            this.CreatedBy_txt.Size = new System.Drawing.Size(222, 26);
            this.CreatedBy_txt.TabIndex = 7;
            // 
            // AuthorName_lb
            // 
            this.AuthorName_lb.AutoSize = true;
            this.AuthorName_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AuthorName_lb.Location = new System.Drawing.Point(343, 17);
            this.AuthorName_lb.Name = "AuthorName_lb";
            this.AuthorName_lb.Size = new System.Drawing.Size(91, 19);
            this.AuthorName_lb.TabIndex = 6;
            this.AuthorName_lb.Text = "Created By:";
            // 
            // ProfileName_lb
            // 
            this.ProfileName_lb.AutoSize = true;
            this.ProfileName_lb.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileName_lb.ForeColor = System.Drawing.Color.Lavender;
            this.ProfileName_lb.Location = new System.Drawing.Point(12, 9);
            this.ProfileName_lb.Name = "ProfileName_lb";
            this.ProfileName_lb.Size = new System.Drawing.Size(28, 39);
            this.ProfileName_lb.TabIndex = 1;
            this.ProfileName_lb.Text = "-";
            // 
            // AddTopic_btn
            // 
            this.AddTopic_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTopic_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddTopic_btn.Location = new System.Drawing.Point(648, 18);
            this.AddTopic_btn.Name = "AddTopic_btn";
            this.AddTopic_btn.Size = new System.Drawing.Size(116, 28);
            this.AddTopic_btn.TabIndex = 2;
            this.AddTopic_btn.Text = "Add Topic";
            this.AddTopic_btn.UseVisualStyleBackColor = true;
            this.AddTopic_btn.Click += new System.EventHandler(this.AddTopic_btn_Click);
            // 
            // TimeForTopicLists
            // 
            this.TimeForTopicLists.Interval = 10000;
            this.TimeForTopicLists.Tick += new System.EventHandler(this.TimeForTopicLists_Tick);
            // 
            // timerForCommentChecker
            // 
            this.timerForCommentChecker.Interval = 1000;
            this.timerForCommentChecker.Tick += new System.EventHandler(this.timerForCommentChecker_Tick);
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelLoading.Controls.Add(this.loadingLabel);
            this.panelLoading.Controls.Add(this.label1);
            this.panelLoading.Location = new System.Drawing.Point(1, 2);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(779, 450);
            this.panelLoading.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Image = global::V_SemesterProject.Properties.Resources.Pulse_1s_200px;
            this.label1.Location = new System.Drawing.Point(183, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 273);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadingLabel.Location = new System.Drawing.Point(278, 358);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(221, 44);
            this.loadingLabel.TabIndex = 1;
            this.loadingLabel.Text = "Loading.........!";
            // 
            // DiscussionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.AddTopic_btn);
            this.Controls.Add(this.ProfileName_lb);
            this.Controls.Add(this.panel1);
            this.Name = "DiscussionPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscussionPanel";
            this.Load += new System.EventHandler(this.DiscussionPanel_Load);
            this.panel1.ResumeLayout(false);
            this.DicussionTopics_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl DicussionTopics_tab;
        private System.Windows.Forms.Label ProfileName_lb;
        private System.Windows.Forms.Button AddTopic_btn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label AlComentsLb;
        private System.Windows.Forms.TextBox TopicHeading_txt;
        private System.Windows.Forms.Label TopicHeading_lb;
        private System.Windows.Forms.ListBox TopicsList_box;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.RichTextBox AllComment_box;
        private System.Windows.Forms.RichTextBox Comment_Box;
        private System.Windows.Forms.Label Comment_lb;
        private System.Windows.Forms.Label discription_lb;
        private System.Windows.Forms.RichTextBox discriptionBox_txt;
        private System.Windows.Forms.TextBox CreatedBy_txt;
        private System.Windows.Forms.Label AuthorName_lb;
        private System.Windows.Forms.Timer TimeForTopicLists;
        private System.Windows.Forms.Timer timerForCommentChecker;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loadingLabel;
    }
}