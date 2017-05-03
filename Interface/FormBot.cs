using MyBot.Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBot.Interface
{
    public partial class FormBot : Form
    {
        private delegate void LogDelegate(string Message, Color Color);
        private delegate void PacketDelegate(string from, string id, string idName, string length, string content_hex, Color color);

        public FormBot()
        {
            InitializeComponent();
            ListViewItem lvp = new ListViewItem("aaaaaaaaa");
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            rtClientForm.Clear();
        }

        private void ConsoleLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        public void WriteLog(string Text)
        {
            Text = "[" + DateTime.Now.ToString("hh:mm:ss") + "] : " + Text;
            Invoke(new LogDelegate(AddMessage), Text, Color.Green);
        }

        public void WriteLogServer(string Text)
        {
            Text = "[" + DateTime.Now.ToString("hh:mm:ss") + "] : FromServer < " + Text;
            Invoke(new LogDelegate(AddMessage), Text, Color.DarkBlue);
        }

        public void WriteLogClient(string Text)
        {
            Text = "[" + DateTime.Now.ToString("hh:mm:ss") + "] : FromClient > " + Text;
            Invoke(new LogDelegate(AddMessage), Text, Color.DarkOrange);
        }

        public void WriteError(string Text)
        {
            Text = "[" + DateTime.Now.ToString("h:mm:ss tt") + "] : " + Text;
            Invoke(new LogDelegate(AddMessage), Text, Color.Red);
        }

        private void AddMessage(string Message, Color Color)
        {
            rtClientForm.SelectionFont = new Font("Verdana", 8, FontStyle.Regular);
            rtClientForm.SelectionColor = Color;
            rtClientForm.AppendText(Message + "\r\n");
            rtClientForm.SelectionStart = rtClientForm.Text.Length;
            rtClientForm.DeselectAll();
            rtClientForm.ScrollToCaret();
        }

        public void AddItem(bool from, short id, string idName, int length, byte[] content)
        {
            Color color;
            string fromString;
            // byte[] to hex_string
            string content_hex = string.Empty;
            int huit_bytes = 0;
            foreach (byte b in content)
            {
                content_hex += b.ToString("X2") + " ";
                huit_bytes++;
            }
            // Client or server ?
            if (!from)
            {
                fromString = "Server";
                color = Color.LightBlue;
            }
            else
            {
                fromString = "Client";
                color = Color.LightGreen;
            }
            Invoke(new PacketDelegate(AddListItem), fromString, id.ToString(), idName, length.ToString(), content_hex, color);
        }
        public void AddListItem(string from, string id, string idName, string length, string content_hex, Color color)
        {
            string[] item = { from, id.ToString(), idName, length.ToString(), content_hex };
            var listViewItem = new ListViewItem(item);
            listViewItem.BackColor = color;
            lvPackets.Items.Add(listViewItem);
            if(lvPackets.Columns[4].Width < content_hex.Length)
                lvPackets.Columns[4].Width = content_hex.Length;
        }
        
        private void lvPackets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\u0003")
            {
                ListView.SelectedListViewItemCollection selectedItems = lvPackets.SelectedItems;
                String text = String.Empty;
                foreach (ListViewItem item in selectedItems)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 4)
                        {
                            text += item.SubItems[i].Text + "\n";
                        }
                        else
                            text += item.SubItems[i].Text + ";";
                    }
                }
                Clipboard.SetText(text);
            }
            else if(e.KeyChar.ToString() == "\u0001")
            {
                foreach(ListViewItem lvi in lvPackets.Items)
                {
                    lvi.Selected = true;
                }
            }
        }
    }
}
