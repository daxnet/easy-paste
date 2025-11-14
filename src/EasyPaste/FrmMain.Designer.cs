namespace EasyPaste
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            mainMenu = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon = new NotifyIcon(components);
            statusStrip = new StatusStrip();
            toolStripContainer = new ToolStripContainer();
            lvPasteList = new ListView();
            tsPasteList = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            mnuAdd = new ToolStripMenuItem();
            mainMenu.SuspendLayout();
            toolStripContainer.ContentPanel.SuspendLayout();
            toolStripContainer.TopToolStripPanel.SuspendLayout();
            toolStripContainer.SuspendLayout();
            tsPasteList.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { mnuFile, listToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(739, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "Standard";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(93, 22);
            mnuExit.Text = "&Exit";
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd });
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(37, 20);
            listToolStripMenuItem.Text = "&List";
            // 
            // notifyIcon
            // 
            notifyIcon.Text = "Easy Paste";
            notifyIcon.Visible = true;
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(0, 557);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(739, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "Application Status";
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            toolStripContainer.ContentPanel.Controls.Add(lvPasteList);
            toolStripContainer.ContentPanel.Size = new Size(739, 508);
            toolStripContainer.Dock = DockStyle.Fill;
            toolStripContainer.Location = new Point(0, 24);
            toolStripContainer.Name = "toolStripContainer";
            toolStripContainer.Size = new Size(739, 533);
            toolStripContainer.TabIndex = 2;
            toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            toolStripContainer.TopToolStripPanel.Controls.Add(tsPasteList);
            // 
            // lvPasteList
            // 
            lvPasteList.Dock = DockStyle.Fill;
            lvPasteList.Location = new Point(0, 0);
            lvPasteList.Name = "lvPasteList";
            lvPasteList.Size = new Size(739, 508);
            lvPasteList.TabIndex = 0;
            lvPasteList.UseCompatibleStateImageBehavior = false;
            // 
            // tsPasteList
            // 
            tsPasteList.Dock = DockStyle.None;
            tsPasteList.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            tsPasteList.Location = new Point(3, 0);
            tsPasteList.Name = "tsPasteList";
            tsPasteList.Size = new Size(35, 25);
            tsPasteList.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
            mnuAdd.Size = new Size(180, 22);
            mnuAdd.Text = "&Add...";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 579);
            Controls.Add(toolStripContainer);
            Controls.Add(statusStrip);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "FrmMain";
            Text = "Easy Paste";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            toolStripContainer.ContentPanel.ResumeLayout(false);
            toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer.TopToolStripPanel.PerformLayout();
            toolStripContainer.ResumeLayout(false);
            toolStripContainer.PerformLayout();
            tsPasteList.ResumeLayout(false);
            tsPasteList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private NotifyIcon notifyIcon;
        private ToolStripMenuItem mnuFile;
        private StatusStrip statusStrip;
        private ToolStripContainer toolStripContainer;
        private ToolStrip tsPasteList;
        private ListView lvPasteList;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem mnuAdd;
    }
}
