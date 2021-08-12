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
    public partial class Create_Account : Form
    {
        Project_Database pdb;
  
        public Create_Account()
        {
            InitializeComponent();
            pdb = new Project_Database();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            #region createAccountCondition
            if (!(string.IsNullOrWhiteSpace(FirstName_txt.Text) && string.IsNullOrWhiteSpace(LastName_txt.Text) && string.IsNullOrWhiteSpace(userName_txt.Text) && string.IsNullOrWhiteSpace(Pass_txt.Text)))
            {
                if (Pass_txt.Text.Length >= 7)
                {
                    pdb.CreateAccount_Func(FirstName_txt.Text, LastName_txt.Text, userName_txt.Text, Pass_txt.Text);
                    this.Hide();

                }
                else
                {
                    errorPass_lb.Visible = true;

                    Pass_txt.Clear();
                }
            }
            else {
                MessageBox.Show("please Fill All Fields First");
            }
            #endregion
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
