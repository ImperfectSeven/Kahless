using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Button Clicks
        private void btn_simulate_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.RunWorkerAsync();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Cancel the BackgroundWorker.
            this.backgroundWorker.CancelAsync();
        }
        #endregion

        #region Background Workers
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            // Do busy stuff here.
            // ...

            // If the user cancels the operation.
            if(bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                // The user cancelled the operation.
                MessageBox.Show("Simulation was cancelled.");
            }
            else if(e.Error != null)
            {
                // There was an error during operation.
                string msg = String.Format("An Error Occured: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
        }
        #endregion

    }
}
