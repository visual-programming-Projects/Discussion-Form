
namespace V_SemesterProject
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorPass_lb = new System.Windows.Forms.Label();
            this.CreateAccount_btn = new System.Windows.Forms.Button();
            this.pass_lb = new System.Windows.Forms.Label();
            this.UserName_lb = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Login_lb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.errorPass_lb);
            this.panel1.Controls.Add(this.CreateAccount_btn);
            this.panel1.Controls.Add(this.pass_lb);
            this.panel1.Controls.Add(this.UserName_lb);
            this.panel1.Controls.Add(this.Login_btn);
            this.panel1.Controls.Add(this.Pass_txt);
            this.panel1.Controls.Add(this.UserName_txt);
            this.panel1.Controls.Add(this.Login_lb);
            this.panel1.Location = new System.Drawing.Point(-5, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 286);
            this.panel1.TabIndex = 0;
            // 
            // errorPass_lb
            // 
            this.errorPass_lb.AutoSize = true;
            this.errorPass_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPass_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorPass_lb.Location = new System.Drawing.Point(27, 171);
            this.errorPass_lb.Name = "errorPass_lb";
            this.errorPass_lb.Size = new System.Drawing.Size(270, 19);
            this.errorPass_lb.TabIndex = 7;
            this.errorPass_lb.Text = "password must be of 7 or more characters!";
            this.errorPass_lb.Visible = false;
            // 
            // CreateAccount_btn
            // 
            this.CreateAccount_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CreateAccount_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CreateAccount_btn.Location = new System.Drawing.Point(79, 245);
            this.CreateAccount_btn.Name = "CreateAccount_btn";
            this.CreateAccount_btn.Size = new System.Drawing.Size(160, 28);
            this.CreateAccount_btn.TabIndex = 6;
            this.CreateAccount_btn.Text = "Create Account";
            this.CreateAccount_btn.UseVisualStyleBackColor = false;
            this.CreateAccount_btn.Click += new System.EventHandler(this.CreateAccount_btn_Click);
            // 
            // pass_lb
            // 
            this.pass_lb.AutoSize = true;
            this.pass_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pass_lb.Location = new System.Drawing.Point(38, 117);
            this.pass_lb.Name = "pass_lb";
            this.pass_lb.Size = new System.Drawing.Size(77, 19);
            this.pass_lb.TabIndex = 5;
            this.pass_lb.Text = "Password:";
            // 
            // UserName_lb
            // 
            this.UserName_lb.AutoSize = true;
            this.UserName_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UserName_lb.Location = new System.Drawing.Point(38, 52);
            this.UserName_lb.Name = "UserName_lb";
            this.UserName_lb.Size = new System.Drawing.Size(86, 19);
            this.UserName_lb.TabIndex = 4;
            this.UserName_lb.Text = "UserName:";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Login_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Login_btn.Location = new System.Drawing.Point(116, 211);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(82, 28);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Pass_txt
            // 
            this.Pass_txt.Location = new System.Drawing.Point(42, 139);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Size = new System.Drawing.Size(231, 20);
            this.Pass_txt.TabIndex = 2;
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(42, 74);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(231, 20);
            this.UserName_txt.TabIndex = 1;
            // 
            // Login_lb
            // 
            this.Login_lb.AutoSize = true;
            this.Login_lb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Login_lb.Location = new System.Drawing.Point(112, 12);
            this.Login_lb.Name = "Login_lb";
            this.Login_lb.Size = new System.Drawing.Size(108, 24);
            this.Login_lb.TabIndex = 0;
            this.Login_lb.Text = "User Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(321, 406);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateAccount_btn;
        private System.Windows.Forms.Label pass_lb;
        private System.Windows.Forms.Label UserName_lb;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox Pass_txt;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.Label Login_lb;
        private System.Windows.Forms.Label errorPass_lb;
    }
}

