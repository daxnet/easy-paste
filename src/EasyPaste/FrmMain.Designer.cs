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
            mnuSave = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuAddGroup = new ToolStripMenuItem();
            mnuEditGroup = new ToolStripMenuItem();
            notifyIcon = new NotifyIcon(components);
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripContainer = new ToolStripContainer();
            splitContainer = new SplitContainer();
            lvGroups = new ListView();
            lvGroupsColumnGroup = new ColumnHeader("_book_");
            imgListColors = new ImageList(components);
            lvItems = new ListView();
            tsPasteList = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tbtnAddGroup = new ToolStripButton();
            tbtnEditGroup = new ToolStripButton();
            ctxMnuStripGroups = new ContextMenuStrip(components);
            ctxMnuAddGroup = new ToolStripMenuItem();
            ctxMnuStripSingleGroup = new ContextMenuStrip(components);
            ctxMnuEditGroup = new ToolStripMenuItem();
            mainMenu.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStripContainer.ContentPanel.SuspendLayout();
            toolStripContainer.TopToolStripPanel.SuspendLayout();
            toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tsPasteList.SuspendLayout();
            ctxMnuStripGroups.SuspendLayout();
            ctxMnuStripSingleGroup.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(852, 25);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "Standard";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuSave, toolStripMenuItem1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(39, 21);
            mnuFile.Text = "&File";
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuSave.Size = new Size(147, 22);
            mnuSave.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(144, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(147, 22);
            mnuExit.Text = "&Exit";
            // 
            // mnuEdit
            // 
            mnuEdit.DropDownItems.AddRange(new ToolStripItem[] { mnuAddGroup, mnuEditGroup });
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(42, 21);
            mnuEdit.Text = "&Edit";
            // 
            // mnuAddGroup
            // 
            mnuAddGroup.Image = Properties.Resources.book__plus;
            mnuAddGroup.Name = "mnuAddGroup";
            mnuAddGroup.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
            mnuAddGroup.Size = new Size(228, 22);
            mnuAddGroup.Text = "&Add group...";
            // 
            // mnuEditGroup
            // 
            mnuEditGroup.Image = Properties.Resources.book__pencil;
            mnuEditGroup.Name = "mnuEditGroup";
            mnuEditGroup.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
            mnuEditGroup.Size = new Size(228, 22);
            mnuEditGroup.Text = "&Edit group...";
            // 
            // notifyIcon
            // 
            notifyIcon.Text = "Easy Paste";
            notifyIcon.Visible = true;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 634);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(852, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "Application Status";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(131, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            toolStripContainer.ContentPanel.Controls.Add(splitContainer);
            toolStripContainer.ContentPanel.Size = new Size(852, 584);
            toolStripContainer.Dock = DockStyle.Fill;
            toolStripContainer.Location = new Point(0, 25);
            toolStripContainer.Name = "toolStripContainer";
            toolStripContainer.Size = new Size(852, 609);
            toolStripContainer.TabIndex = 2;
            toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            toolStripContainer.TopToolStripPanel.Controls.Add(tsPasteList);
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(lvGroups);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(lvItems);
            splitContainer.Size = new Size(852, 584);
            splitContainer.SplitterDistance = 309;
            splitContainer.TabIndex = 0;
            // 
            // lvGroups
            // 
            lvGroups.Columns.AddRange(new ColumnHeader[] { lvGroupsColumnGroup });
            lvGroups.Dock = DockStyle.Fill;
            lvGroups.FullRowSelect = true;
            lvGroups.LargeImageList = imgListColors;
            lvGroups.Location = new Point(0, 0);
            lvGroups.MultiSelect = false;
            lvGroups.Name = "lvGroups";
            lvGroups.Size = new Size(309, 584);
            lvGroups.SmallImageList = imgListColors;
            lvGroups.Sorting = SortOrder.Ascending;
            lvGroups.StateImageList = imgListColors;
            lvGroups.TabIndex = 0;
            lvGroups.UseCompatibleStateImageBehavior = false;
            lvGroups.View = View.Details;
            lvGroups.MouseDown += lvGroups_MouseDown;
            // 
            // lvGroupsColumnGroup
            // 
            lvGroupsColumnGroup.Text = "Groups";
            lvGroupsColumnGroup.Width = 380;
            // 
            // imgListColors
            // 
            imgListColors.ColorDepth = ColorDepth.Depth32Bit;
            imgListColors.ImageStream = (ImageListStreamer)resources.GetObject("imgListColors.ImageStream");
            imgListColors.TransparentColor = Color.Transparent;
            imgListColors.Images.SetKeyName(0, "_book_");
            // 
            // lvItems
            // 
            lvItems.Dock = DockStyle.Fill;
            lvItems.Location = new Point(0, 0);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(539, 584);
            lvItems.TabIndex = 0;
            lvItems.UseCompatibleStateImageBehavior = false;
            // 
            // tsPasteList
            // 
            tsPasteList.Dock = DockStyle.None;
            tsPasteList.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, tbtnAddGroup, tbtnEditGroup });
            tsPasteList.Location = new Point(3, 0);
            tsPasteList.Name = "tsPasteList";
            tsPasteList.Size = new Size(87, 25);
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
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tbtnAddGroup
            // 
            tbtnAddGroup.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbtnAddGroup.Image = Properties.Resources.book__plus;
            tbtnAddGroup.ImageTransparentColor = Color.Magenta;
            tbtnAddGroup.Name = "tbtnAddGroup";
            tbtnAddGroup.Size = new Size(23, 22);
            tbtnAddGroup.Text = "Add group...";
            // 
            // tbtnEditGroup
            // 
            tbtnEditGroup.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbtnEditGroup.Image = Properties.Resources.book__pencil;
            tbtnEditGroup.ImageTransparentColor = Color.Magenta;
            tbtnEditGroup.Name = "tbtnEditGroup";
            tbtnEditGroup.Size = new Size(23, 22);
            tbtnEditGroup.Text = "Edit group...";
            // 
            // ctxMnuStripGroups
            // 
            ctxMnuStripGroups.Items.AddRange(new ToolStripItem[] { ctxMnuAddGroup });
            ctxMnuStripGroups.Name = "ctxMnuStripGroups";
            ctxMnuStripGroups.Size = new Size(150, 26);
            // 
            // ctxMnuAddGroup
            // 
            ctxMnuAddGroup.Image = Properties.Resources.book__plus;
            ctxMnuAddGroup.Name = "ctxMnuAddGroup";
            ctxMnuAddGroup.Size = new Size(149, 22);
            ctxMnuAddGroup.Text = "Add group...";
            // 
            // ctxMnuStripSingleGroup
            // 
            ctxMnuStripSingleGroup.Items.AddRange(new ToolStripItem[] { ctxMnuEditGroup });
            ctxMnuStripSingleGroup.Name = "ctxMnuStripSingleGroup";
            ctxMnuStripSingleGroup.Size = new Size(148, 26);
            // 
            // ctxMnuEditGroup
            // 
            ctxMnuEditGroup.Image = Properties.Resources.book__pencil;
            ctxMnuEditGroup.Name = "ctxMnuEditGroup";
            ctxMnuEditGroup.Size = new Size(147, 22);
            ctxMnuEditGroup.Text = "&Edit group...";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 656);
            Controls.Add(toolStripContainer);
            Controls.Add(statusStrip);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Easy Paste";
            Load += FrmMain_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStripContainer.ContentPanel.ResumeLayout(false);
            toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer.TopToolStripPanel.PerformLayout();
            toolStripContainer.ResumeLayout(false);
            toolStripContainer.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tsPasteList.ResumeLayout(false);
            tsPasteList.PerformLayout();
            ctxMnuStripGroups.ResumeLayout(false);
            ctxMnuStripSingleGroup.ResumeLayout(false);
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
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuEdit;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem mnuAddGroup;
        private SplitContainer splitContainer;
        private ListView lvGroups;
        private ListView lvItems;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ImageList imgListColors;
        private ColumnHeader lvGroupsColumnGroup;
        private ContextMenuStrip ctxMnuStripGroups;
        private ToolStripMenuItem ctxMnuAddGroup;
        private ToolStripMenuItem mnuSave;
        private ToolStripSeparator toolStripMenuItem1;
        private ContextMenuStrip ctxMnuStripSingleGroup;
        private ToolStripMenuItem ctxMnuEditGroup;
        private ToolStripMenuItem mnuEditGroup;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tbtnAddGroup;
        private ToolStripButton tbtnEditGroup;
    }
}
