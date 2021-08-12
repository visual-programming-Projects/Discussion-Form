using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace V_SemesterProject
{
   
    public partial class Form1 : Form
    {
        Project_Database pdb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Event to create Account of Members 
        // this will call another form of create Account
        private void CreateAccount_btn_Click(object sender, EventArgs e)
        {
            
            Create_Account createAc= new Create_Account();
            createAc.Show();

            
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            #region loginCondition
            pdb = new Project_Database();
            if (!(string.IsNullOrWhiteSpace(UserName_txt.Text) && string.IsNullOrWhiteSpace(Pass_txt.Text)))
            {
                pdb.LoginAccount(UserName_txt.Text, Pass_txt.Text);
                UserName_txt.Clear();
                Pass_txt.Clear();
            }
            else
            {
                MessageBox.Show("please Fill All Fields First");
            }

            #endregion
        }
    }
}
