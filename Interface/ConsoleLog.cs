using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBot
{
    public partial class ConsoleLog : Form
    {
        private delegate void MainDelegate(string Message, Color Color);
        private Color Color;

        public ConsoleLog()
        {
            InitializeComponent();
            Color = Color.Green;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            rtLog.Clear();
        }

        private void ConsoleLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        public void WriteLog(string Text)
        {
            Text = "[" + DateTime.Now.ToString("hh:mm:ss") + "] : " + Text;
            Invoke(new MainDelegate(AddMessage), Text, Color.Green);
        }

        public void WriteLogServer(string Text)
        {
            Text = "[" + DateTime.Now.ToString("hh:mm:ss") + "] : FromServer = " + Text;
            Invoke(new MainDelegate(AddMessage), Text, Color.DarkBlue);
        }

        public void WriteLogClient(string Text)
        {
            Text = "[" + DateTime.Now.ToString("hh:mm:ss") + "] : FromClient = " + Text;
            Invoke(new MainDelegate(AddMessage), Text, Color.DarkOrange);
        }

        public void WriteError(string Text)
        {
            Text = "[" + DateTime.Now.ToString("hh:mm:ss") + "] : " + Text;
            Invoke(new MainDelegate(AddMessage), Text, Color.Red);
        }

        private void AddMessage(string Message, Color Color)
        {
            rtLog.SelectionFont = new Font("Verdana", 8, FontStyle.Regular);
            rtLog.SelectionColor = Color;
            rtLog.AppendText(Message + "\r\n");
            rtLog.SelectionStart = rtLog.Text.Length;
            rtLog.DeselectAll();
            rtLog.ScrollToCaret();
        }
    }
}
