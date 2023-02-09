using System.ComponentModel;
using System.Diagnostics;

namespace BogoSort__WinForms_
{
    enum ProgramState {
        STOPPED,
        RUNNING,
        PAUSED,
        COMPLETED
    };

    public partial class mainWindow : Form
    {
        List<int> list = new List<int>() { 1,5,3,33,29, 23, 35,23,24,5,7,333,1223,1452,1234,222,3242,1123,12,4 };
        Stopwatch stopwatch = new Stopwatch();
        ProgramState state = ProgramState.STOPPED;
        List<BackgroundWorker> workerList = new List<BackgroundWorker>();

        public mainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            state = ProgramState.RUNNING;
            if (state == ProgramState.STOPPED)
            {
                stopwatch.Reset();
                stopwatch.Start();
                timerCount.Start();

                // Generate new BackgroundWorkers
            }


            if(!TmpBackgroundWorker.IsBusy)
            {
                TmpBackgroundWorker.RunWorkerAsync(list);
            }
        }

        private void TmpBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BogoSortInformation sortInformation = new BogoSortInformation(0, e.Argument as List<int>, false);

            while (!sortInformation.IsSorted())
            {
                TmpBackgroundWorker.ReportProgress(0, sortInformation);
                sortInformation.ShuffleList();
                Thread.Sleep(50);
            }

        }

        private void TmpBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            BogoSortInformation sortInformation = (BogoSortInformation)e.UserState;
            WriteToConsoleWindow(sortInformation.ToString());
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            lblTimeElapsed.Text = $"Time Elapsed: {stopwatch.Elapsed}";
        }

        private void TmpBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            stopwatch.Stop();
            timerCount.Stop();
            state = ProgramState.COMPLETED;
            WriteToConsoleWindow($"Completed! Sorted in {stopwatch.Elapsed}!");
        }

        private void WriteToConsoleWindow(string lineToAdd)
        {
            txtOutput.Text += lineToAdd + Environment.NewLine;
            txtOutput.SelectionStart = txtOutput.Lines.Length;
            txtOutput.ScrollToCaret();
        }

        private void inpThreadCount_TextChanged(object sender, EventArgs e)
        {
            if (inpThreadCount.Text.Length > 0)
            {
                try
                {
                    Int32.Parse(inpThreadCount.Text);
                } catch (FormatException ex)
                {
                    MessageBox.Show("Thread Count Must Only Contain A Numeric Value");
                    inpThreadCount.Text = inpThreadCount.Text.Remove(inpThreadCount.Text.Length - 1);
                }
            }
        }
    }
}