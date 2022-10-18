using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Fleck;


namespace RP3_Interface
{
    public partial class Form1 : Form
    {
        #region variables
        public static bool formOpen = true;
        string lastMessage = "";

        StringBuilder log = new StringBuilder();
        
        WebSocketServer wss;
        List<IWebSocketConnection> allSockets = new List<IWebSocketConnection>();

        bool isRunning = false;
        #endregion

        #region begin/end
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            Timer updateClock = new Timer();
            updateClock.Interval = 1000 / 10;
            updateClock.Tick += Update;
            updateClock.Start();

        }
        
        private void Start()
        {
            //check file selected
            if (FilePathDialog.Text == "")
            {
                MessageBox.Show("Please select a file to log to.");
                return;
            }

            //check file empty
            if (System.IO.File.Exists(FilePathDialog.Text))
            {
                if (System.IO.File.ReadAllText(FilePathDialog.Text) != "")
                { //ask if user wants to overwrite file
                    DialogResult result = MessageBox.Show("The file you have selected is not empty. Do you want to overwrite it?", "File not empty", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            //start server
            wss = new WebSocketServer("ws://127.0.0.1:2071"); 
            wss.Start( socket =>
            {
                socket.OnOpen = () => { allSockets.Add(socket); };
                socket.OnClose = () => { allSockets.Remove(socket); };
                socket.OnMessage += OnMessage;
            });
            AppendCheckBox.Enabled = false;

            //start logging
            log.Clear();
            //empty file if needed
            if (AppendCheckBox.Checked == false)
            {
                System.IO.File.WriteAllText(FilePathDialog.Text, "");
            }

            StartStopButton.Text = "Stop";
            StartStopButton.ForeColor = Color.Red;
            ApplicationStateText.Text = "Running";
            ApplicationStateText.ForeColor = Color.Green;
            isRunning = true;
        }

        private void Stop()
        {
            wss.Dispose();
            AppendCheckBox.Enabled = true;

            StartStopButton.Text = "Start";
            StartStopButton.ForeColor = Color.Green;
            ApplicationStateText.Text = "Stopped";
            ApplicationStateText.ForeColor = Color.Red;
            isRunning = false;

            saveFile();
        }
        

        void formClosing(object sender, EventArgs e)
        {
            wss.Dispose();
            saveFile();
            formOpen = false;
        }
        #endregion

        /// <summary>
        /// Update method, gets run on a loop while the window is open.
        /// </summary>
        private void Update(object sender, EventArgs e)
        {
            
        }

        private void saveFile()
        {//open the file from the dialog and append the current log to it, then empty the log

            System.IO.File.AppendAllText(FilePathDialog.Text, log.ToString());

            log.Clear();

            CacheSizeText.Text = "0";
        }

        #region events
        void OnMessage(string message)
        {
            lastMessage = message;
            log.Append(message);
            if (NewlineCheckbox.Checked)
                log.Append(Environment.NewLine);

            CacheSizeText.Text = log.Length.ToString();
            //if log big enough, sive file
            if (AutoSaveSizeField.Value >= 0 && log.Length > AutoSaveSizeField.Value)
            {
                saveFile();
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            LogFileDialog.ShowDialog();
        }

        private void LogFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            FilePathDialog.Text = LogFileDialog.FileName;

            //write "file opened" to the file selected
            System.IO.StreamWriter file = new System.IO.StreamWriter(LogFileDialog.FileName);
            file.WriteLine("File opened");
            
            file.Close();
            
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if(isRunning)
            {
                Stop();
            }
            else
            {
                Start();
            }
        }
        #endregion
    }
}
