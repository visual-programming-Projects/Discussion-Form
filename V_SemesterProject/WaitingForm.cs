using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace V_SemesterProject
{
    public partial class WaitingForm : Form
    {
        public BackgroundWorker backgroundWorker;
        public WaitingForm()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0:

                    waitingLabel.Text = "Making Connection...!!";

                    break;

                case 1:

                    waitingLabel.Text = " Fetching data..!!";

                    break;
                case 2:

                    waitingLabel.Text = " Fetching and sorting data..!!";

                    break;
                case 3:

                    waitingLabel.Text = " Loading datasets..!!";

                    break;

                case 4:

                    waitingLabel.Text = " About to finish..!!";

                    break;
                case 5:

                    waitingLabel.Text = " Opening application";

                    break;

                case 6:

                    this.Hide();

                    break;

            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                Thread.Sleep(3000);
                backgroundWorker.ReportProgress(i);
            }
            
            backgroundWorker.CancelAsync();
            

        }

        private void LoadingProgressForm_Load(object sender, EventArgs e)
        {
            waitingLabel.Text = "Starting Loading";
            backgroundWorker.RunWorkerAsync();
        }
    }
}

