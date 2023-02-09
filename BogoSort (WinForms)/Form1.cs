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
        //List<int> list = new List<int>() { 1,5,3,33 };
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
            stopwatch.Reset();
            stopwatch.Start();
            timerCount.Start();

            // Generate new BackgroundWorkers
            for (int i = 0; i < Int32.Parse(inpThreadCount.Text); i++)
            {
                BackgroundWorker backgroundWorker = new BackgroundWorker();
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.WorkerSupportsCancellation = true;

                backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
                backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker_ProgressChanged);
                backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);

                workerList.Add(backgroundWorker);
            }

            for (int i = 0; i < workerList.Count; i++) {
                BackgroundWorker activeWorker = workerList[i];

                if (!activeWorker.IsBusy) {
                    activeWorker.RunWorkerAsync(new BogoSortInformation(
                        0,
                        list,
                        false,
                        i
                    ));
                }

            }
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            lblTimeElapsed.Text = $"Time Elapsed: {stopwatch.Elapsed}";
        }

        #region Utility Functions
        private void WriteToConsoleWindow(string lineToAdd)
        {
            listOutput.Items.Add(lineToAdd);
            listOutput.TopIndex = listOutput.Items.Count - 1;
        }
        #endregion

        #region Validation Functions
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
                    return;
                }

                if (Int32.Parse(inpThreadCount.Text) < 1)
                {
                    MessageBox.Show("Thread Count Must Be Above 0!");
                    inpThreadCount.Text = "1";
                    return;
                }

            }
        }
        #endregion

        #region Background Worker Fucntions
        private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            BogoSortInformation sortInformation = (BogoSortInformation)e.UserState;
            WriteToConsoleWindow(sortInformation.ToString());
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < workerList.Count; i++ )
            {
                workerList[i].CancelAsync();
            }

            if (!e.Cancelled) {
                stopwatch.Stop();
                timerCount.Stop();
                state = ProgramState.COMPLETED;
                WriteToConsoleWindow($"Completed! Sorted in {stopwatch.Elapsed}! Thread {e.Result} got it first!");
            }
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BogoSortInformation sortInformation = (BogoSortInformation)e.Argument;
            bool shouldStop = false;
            // BogoSortInformation sortInformation = new BogoSortInformation(0, e.Argument as List<int>, false);

            while (!sortInformation.IsSorted() && !shouldStop)
            {
                if (workerList[sortInformation.GetThreadId()].CancellationPending)
                {
                    e.Cancel = true;
                    shouldStop = true;
                } else
                {
                    workerList[sortInformation.GetThreadId()].ReportProgress(0, sortInformation);
                    sortInformation.ShuffleList();
                    Thread.Sleep(50);
                }
            }
            
            e.Result = sortInformation.GetThreadId();
        }
        #endregion
    }
}