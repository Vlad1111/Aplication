using Aplication.Units.Controller;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

namespace Aplication
{
    public partial class Form1 : Form
    {
        private Controller controller;
        public Form1(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        
        /// <summary>
        /// Get the values and print the best resoult
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        /// <summary>
        /// The asyncrone function for showing the values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            try
            {
                backgroundWorker.ReportProgress(0);
                var exchange1 = controller.getVlaue1();
                backgroundWorker.ReportProgress(1);
                var exchange2 = controller.getVlaue2();
                backgroundWorker.ReportProgress(2);
                double value1 = exchange1.getExchange();
                backgroundWorker.ReportProgress(3);
                double value2 = exchange2.getExchange();
                backgroundWorker.ReportProgress(4);
                double value = value1 < value2 ? value1 : value2;

                if (ConfigurationManager.AppSettings["PrintMode"] == "Console")
                    Console.WriteLine("Value: " + value);
                else MessageBox.Show("Value: " + value);
                backgroundWorker.ReportProgress(0);
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["PrintMode"] == "Console")
                    Console.WriteLine("An error ocured while getting the values:\n" + ex.Message);
                else MessageBox.Show("An error ocured while getting the values:\n" + ex.Message);
                backgroundWorker.ReportProgress(0);
            }
        }

        /// <summary>
        /// the function for showing the progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
