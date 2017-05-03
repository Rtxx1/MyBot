namespace MyBot.Interface
{
    partial class FormBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.rtClientForm = new System.Windows.Forms.RichTextBox();
            this.tpPackets = new System.Windows.Forms.TabPage();
            this.lvPackets = new System.Windows.Forms.ListView();
            this.chFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.tpPackets.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpLog);
            this.tabControl.Controls.Add(this.tpPackets);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(796, 419);
            this.tabControl.TabIndex = 1;
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.rtClientForm);
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(788, 393);
            this.tpLog.TabIndex = 0;
            this.tpLog.Text = "Logs";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // rtClientForm
            // 
            this.rtClientForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtClientForm.Location = new System.Drawing.Point(3, 3);
            this.rtClientForm.Name = "rtClientForm";
            this.rtClientForm.ReadOnly = true;
            this.rtClientForm.Size = new System.Drawing.Size(782, 387);
            this.rtClientForm.TabIndex = 1;
            this.rtClientForm.Text = "";
            // 
            // tpPackets
            // 
            this.tpPackets.Controls.Add(this.lvPackets);
            this.tpPackets.Location = new System.Drawing.Point(4, 22);
            this.tpPackets.Name = "tpPackets";
            this.tpPackets.Padding = new System.Windows.Forms.Padding(3);
            this.tpPackets.Size = new System.Drawing.Size(788, 393);
            this.tpPackets.TabIndex = 1;
            this.tpPackets.Text = "Packets";
            this.tpPackets.UseVisualStyleBackColor = true;
            // 
            // lvPackets
            // 
            this.lvPackets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFrom,
            this.chId,
            this.chIdName,
            this.chLength,
            this.chContent});
            this.lvPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPackets.FullRowSelect = true;
            this.lvPackets.GridLines = true;
            this.lvPackets.HideSelection = false;
            this.lvPackets.Location = new System.Drawing.Point(3, 3);
            this.lvPackets.Name = "lvPackets";
            this.lvPackets.Size = new System.Drawing.Size(782, 387);
            this.lvPackets.TabIndex = 0;
            this.lvPackets.UseCompatibleStateImageBehavior = false;
            this.lvPackets.View = System.Windows.Forms.View.Details;
            this.lvPackets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvPackets_KeyPress);
            // 
            // chFrom
            // 
            this.chFrom.Text = "From";
            this.chFrom.Width = 43;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 37;
            // 
            // chIdName
            // 
            this.chIdName.Text = "IdName";
            this.chIdName.Width = 150;
            // 
            // chLength
            // 
            this.chLength.Text = "Length";
            this.chLength.Width = 49;
            // 
            // chContent
            // 
            this.chContent.Text = "Content";
            this.chContent.Width = 499;
            // 
            // FormBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 419);
            this.Controls.Add(this.tabControl);
            this.Name = "FormBot";
            this.Text = "ClientForm";
            this.tabControl.ResumeLayout(false);
            this.tpLog.ResumeLayout(false);
            this.tpPackets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpLog;
        private System.Windows.Forms.TabPage tpPackets;
        private System.Windows.Forms.RichTextBox rtClientForm;
        private System.Windows.Forms.ListView lvPackets;
        private System.Windows.Forms.ColumnHeader chFrom;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chLength;
        private System.Windows.Forms.ColumnHeader chContent;
        private System.Windows.Forms.ColumnHeader chIdName;
    }
}