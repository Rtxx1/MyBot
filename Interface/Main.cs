using MyBot.Connexion;
using MyBot.Divers;
using MyBot.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBot
{
    public partial class Main : Form
    {
        private Thread NewClientPopOut;
        private ConsoleLog Log = new ConsoleLog();
        private Injection inject;
        private ConnexionManager MITM;
        private FormBot ClientForm = new FormBot();

        /// <summary>
        /// Constructeur principal
        /// </summary>
        public Main()
        {
            InitializeComponent();
            inject = new Injection(Log, this);
            Log.MdiParent = this;
            Log.Show();
            ClientForm.MdiParent = this;
            desactiverMitm.Enabled = false;
            MITM = new ConnexionManager(new IPEndPoint(IPAddress.Parse("213.248.126.39"), 5555), Log, this);
            MITM.start();
        }


        #region Interface
        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Visible = true;
        }

        private void activerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClientPopOut = new Thread(new ThreadStart(inject.ProcessDofus));
            NewClientPopOut.Start();
            activerMitm.Enabled = false;
            desactiverMitm.Enabled = true;
        }

        private void desactiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inject.StopThread();
            activerMitm.Enabled = true;
            desactiverMitm.Enabled = false;
        }

        private void dofusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files (x86)\Ankama\Dofus\app";
            try { Process.Start(@path + @"\Dofus.exe"); }
            catch (Exception a) { Log.WriteError(a.Message + " (Dossier app de Dofus : " + @path + ")"); }
        }
        #endregion

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.Close();
            ClientForm.Close();
            Environment.Exit(1);
        }
    }
}
