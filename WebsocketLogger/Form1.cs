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
        public static bool formOpen = true;
        string lastMessage = "";

        StringBuilder log = new StringBuilder();
        
        WebSocketServer wss;
        List<IWebSocketConnection> allSockets = new List<IWebSocketConnection>();

        bool isRunning = false;


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
            wss = new WebSocketServer("ws://127.0.0.1:2071"); 
            wss.Start( socket =>
            {
                socket.OnOpen = () => { allSockets.Add(socket); };
                socket.OnClose = () => { allSockets.Remove(socket); };
                socket.OnMessage += OnMessage;
            });
            AppendCheckBox.Enabled = false;

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
        }
        
        void OnMessage(string message)
        {
            lastMessage = message;
            log.Append(message);
            if (NewlineCheckbox.Checked)
                log.Append(Environment.NewLine);

            CacheSizeText.Text = log.Length.ToString();
        }

        void formClosing(object sender, EventArgs e)
        {
            wss.Dispose();
            formOpen = false;
        }

        /// <summary>
        /// Update method, gets run on a loop while the window is open.
        /// </summary>
        private void Update(object sender, EventArgs e)
        {
            
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
            System.IO.StreamWriter file = new System.IO.StreamWriter(LogFileDialog.FileName);
            file.WriteLine(log.ToString());
            file.Close();
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
    }
}
