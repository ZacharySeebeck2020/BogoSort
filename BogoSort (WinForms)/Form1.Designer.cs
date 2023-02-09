namespace BogoSort__WinForms_
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inpDesiredSeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inpDatasetSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpThreadCount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSeed = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.TmpBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.groupSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSettings
            // 
            this.groupSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupSettings.Controls.Add(this.label3);
            this.groupSettings.Controls.Add(this.inpDesiredSeed);
            this.groupSettings.Controls.Add(this.label2);
            this.groupSettings.Controls.Add(this.inpDatasetSize);
            this.groupSettings.Controls.Add(this.label1);
            this.groupSettings.Controls.Add(this.inpThreadCount);
            this.groupSettings.ForeColor = System.Drawing.Color.White;
            this.groupSettings.Location = new System.Drawing.Point(12, 390);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(452, 189);
            this.groupSettings.TabIndex = 1;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desired Seed (Leave empty to randomize)";
            // 
            // inpDesiredSeed
            // 
            this.inpDesiredSeed.Enabled = false;
            this.inpDesiredSeed.Location = new System.Drawing.Point(6, 161);
            this.inpDesiredSeed.Name = "inpDesiredSeed";
            this.inpDesiredSeed.Size = new System.Drawing.Size(440, 22);
            this.inpDesiredSeed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dataset Size";
            // 
            // inpDatasetSize
            // 
            this.inpDatasetSize.Location = new System.Drawing.Point(112, 35);
            this.inpDatasetSize.Name = "inpDatasetSize";
            this.inpDatasetSize.Size = new System.Drawing.Size(100, 22);
            this.inpDatasetSize.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thread Count";
            // 
            // inpThreadCount
            // 
            this.inpThreadCount.Location = new System.Drawing.Point(6, 35);
            this.inpThreadCount.Name = "inpThreadCount";
            this.inpThreadCount.Size = new System.Drawing.Size(100, 22);
            this.inpThreadCount.TabIndex = 0;
            this.inpThreadCount.Text = "1";
            this.inpThreadCount.TextChanged += new System.EventHandler(this.inpThreadCount_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBreak);
            this.groupBox1.Controls.Add(this.btnEnd);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1210, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnBreak
            // 
            this.btnBreak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.btnBreak.FlatAppearance.BorderSize = 0;
            this.btnBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreak.ForeColor = System.Drawing.Color.White;
            this.btnBreak.Location = new System.Drawing.Point(14, 47);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(125, 23);
            this.btnBreak.TabIndex = 2;
            this.btnBreak.Text = "Take A Lil Break";
            this.btnBreak.UseVisualStyleBackColor = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(14, 160);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(125, 23);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Stop For Good";
            this.btnEnd.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(110)))), ((int)(((byte)(83)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(14, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Your Journey";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(6, 22);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(67, 14);
            this.lblSeed.TabIndex = 3;
            this.lblSeed.Text = "Used Seed: ";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(6, 43);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(75, 14);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Time Started:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblTimeElapsed);
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Controls.Add(this.lblSeed);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(470, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Output";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(6, 66);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(78, 14);
            this.lblTimeElapsed.TabIndex = 5;
            this.lblTimeElapsed.Text = "Time Elapsed:";
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // TmpBackgroundWorker
            // 
            this.TmpBackgroundWorker.WorkerReportsProgress = true;
            this.TmpBackgroundWorker.WorkerSupportsCancellation = true;
            this.TmpBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TmpBackgroundWorker_DoWork);
            this.TmpBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.TmpBackgroundWorker_ProgressChanged);
            this.TmpBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TmpBackgroundWorker_RunWorkerCompleted);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtOutput.Location = new System.Drawing.Point(12, 12);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtOutput.Size = new System.Drawing.Size(1349, 372);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "Adjust settings, then select \"Start Your Journey\" to begin.";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1373, 591);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupSettings);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1000, 630);
            this.Name = "mainWindow";
            this.Text = "BogoSort (Not Running)";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupSettings;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox inpDatasetSize;
        private Label label1;
        private TextBox inpThreadCount;
        private Label label3;
        private TextBox inpDesiredSeed;
        private Button btnBreak;
        private Button btnEnd;
        private Button btnStart;
        private Label lblSeed;
        private Label lblStartTime;
        private GroupBox groupBox2;
        private Label lblTimeElapsed;
        private System.Windows.Forms.Timer timerCount;
        private System.ComponentModel.BackgroundWorker TmpBackgroundWorker;
        private RichTextBox txtOutput;
    }
}