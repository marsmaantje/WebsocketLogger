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
        WebSocketServer wss;
        List<IWebSocketConnection> allSockets = new List<IWebSocketConnection>();


        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Console.WriteLine("hello world");

            Timer updateClock = new Timer();
            updateClock.Interval = 1000 / 10;
            updateClock.Tick += Update;
            updateClock.Start();

            wss = new WebSocketServer("ws://127.0.0.1:2071");
            wss.Start( socket =>
            {
                socket.OnOpen = () => { allSockets.Add(socket); };
                socket.OnClose = () => { allSockets.Remove(socket); };
                socket.OnMessage += OnMessage;
            });
            
        }

        void OnMessage(string message)
        {
            lastMessage = message;
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
            MessageText.Text = lastMessage;
        }
    }
}
