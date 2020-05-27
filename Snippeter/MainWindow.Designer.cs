namespace Snippeter
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOptionAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSelectDestProc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblDestProc = new System.Windows.Forms.ToolStripStatusLabel();
            this.TreeViewIcons = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtContents = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnTrimLines = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnPasteIntoEclipse = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.SnippetTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnOpenSnippetsFolder = new System.Windows.Forms.ToolStripButton();
            this.BtnToggleExpansion = new System.Windows.Forms.ToolStripButton();
            this.BtnRefreshTree = new System.Windows.Forms.ToolStripButton();
            this.BtnCopyPasteOnClick = new System.Windows.Forms.ToolStripButton();
            this.BtnToggleContentPanel = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Splitter = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
            this.Splitter.Panel1.SuspendLayout();
            this.Splitter.Panel2.SuspendLayout();
            this.Splitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // BtnExit
            // 
            this.BtnExit.Image = global::Snippeter.Properties.Resources.cross;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.BtnExit.Size = new System.Drawing.Size(156, 22);
            this.BtnExit.Text = "Exit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOptionAlwaysOnTop,
            this.BtnSelectDestProc});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // BtnOptionAlwaysOnTop
            // 
            this.BtnOptionAlwaysOnTop.Image = global::Snippeter.Properties.Resources.new_window;
            this.BtnOptionAlwaysOnTop.Name = "BtnOptionAlwaysOnTop";
            this.BtnOptionAlwaysOnTop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.BtnOptionAlwaysOnTop.Size = new System.Drawing.Size(251, 22);
            this.BtnOptionAlwaysOnTop.Text = "Always on top";
            this.BtnOptionAlwaysOnTop.Click += new System.EventHandler(this.BtnOptionAlwaysOnTop_Click);
            // 
            // BtnSelectDestProc
            // 
            this.BtnSelectDestProc.Image = global::Snippeter.Properties.Resources.application_cascade;
            this.BtnSelectDestProc.Name = "BtnSelectDestProc";
            this.BtnSelectDestProc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.BtnSelectDestProc.Size = new System.Drawing.Size(251, 22);
            this.BtnSelectDestProc.Text = "Select destination process";
            this.BtnSelectDestProc.Click += new System.EventHandler(this.BtnSelectDestProc_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblDestProc});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblDestProc
            // 
            this.LblDestProc.Name = "LblDestProc";
            this.LblDestProc.Size = new System.Drawing.Size(116, 17);
            this.LblDestProc.Text = "Destination process: ";
            // 
            // TreeViewIcons
            // 
            this.TreeViewIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeViewIcons.ImageStream")));
            this.TreeViewIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeViewIcons.Images.SetKeyName(0, "folder.png");
            this.TreeViewIcons.Images.SetKeyName(1, "tag.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 275);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.TxtContents, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(305, 275);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TxtContents
            // 
            this.TxtContents.AcceptsReturn = true;
            this.TxtContents.AcceptsTab = true;
            this.TxtContents.AllowDrop = true;
            this.TxtContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtContents.Font = new System.Drawing.Font("Input", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContents.Location = new System.Drawing.Point(3, 36);
            this.TxtContents.Multiline = true;
            this.TxtContents.Name = "TxtContents";
            this.TxtContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtContents.Size = new System.Drawing.Size(299, 201);
            this.TxtContents.TabIndex = 2;
            this.TxtContents.WordWrap = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.BtnTrimLines, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnSave, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnPasteIntoEclipse, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 240);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(305, 35);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // BtnTrimLines
            // 
            this.BtnTrimLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTrimLines.Location = new System.Drawing.Point(104, 3);
            this.BtnTrimLines.Name = "BtnTrimLines";
            this.BtnTrimLines.Size = new System.Drawing.Size(95, 29);
            this.BtnTrimLines.TabIndex = 5;
            this.BtnTrimLines.Text = "Trim lines";
            this.BtnTrimLines.UseVisualStyleBackColor = true;
            this.BtnTrimLines.Click += new System.EventHandler(this.BtnTrimLines_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Location = new System.Drawing.Point(205, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(97, 29);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnPasteIntoEclipse
            // 
            this.BtnPasteIntoEclipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPasteIntoEclipse.Location = new System.Drawing.Point(3, 3);
            this.BtnPasteIntoEclipse.Name = "BtnPasteIntoEclipse";
            this.BtnPasteIntoEclipse.Size = new System.Drawing.Size(95, 29);
            this.BtnPasteIntoEclipse.TabIndex = 3;
            this.BtnPasteIntoEclipse.Text = "Copy & Paste";
            this.BtnPasteIntoEclipse.UseMnemonic = false;
            this.BtnPasteIntoEclipse.UseVisualStyleBackColor = true;
            this.BtnPasteIntoEclipse.Click += new System.EventHandler(this.BtnPasteIntoEclipse_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxtName, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(299, 27);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snippet:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtName
            // 
            this.TxtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtName.Font = new System.Drawing.Font("Input", 8.249999F);
            this.TxtName.Location = new System.Drawing.Point(59, 5);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(237, 20);
            this.TxtName.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(154, 275);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.SnippetTreeView, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5, 10, 0, 7);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(148, 269);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // SnippetTreeView
            // 
            this.SnippetTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnippetTreeView.ImageIndex = 0;
            this.SnippetTreeView.ImageList = this.TreeViewIcons;
            this.SnippetTreeView.Location = new System.Drawing.Point(0, 25);
            this.SnippetTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.SnippetTreeView.Name = "SnippetTreeView";
            this.SnippetTreeView.SelectedImageIndex = 0;
            this.SnippetTreeView.Size = new System.Drawing.Size(148, 244);
            this.SnippetTreeView.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOpenSnippetsFolder,
            this.BtnToggleExpansion,
            this.BtnRefreshTree,
            this.BtnCopyPasteOnClick,
            this.BtnToggleContentPanel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(148, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnOpenSnippetsFolder
            // 
            this.BtnOpenSnippetsFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOpenSnippetsFolder.Image = global::Snippeter.Properties.Resources.folder_vertical_open;
            this.BtnOpenSnippetsFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpenSnippetsFolder.Name = "BtnOpenSnippetsFolder";
            this.BtnOpenSnippetsFolder.Size = new System.Drawing.Size(23, 22);
            this.BtnOpenSnippetsFolder.Text = "Open snippets folder";
            this.BtnOpenSnippetsFolder.Click += new System.EventHandler(this.BtnOpenSnippetsFolder_Click);
            // 
            // BtnToggleExpansion
            // 
            this.BtnToggleExpansion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnToggleExpansion.Image = global::Snippeter.Properties.Resources.document_tree;
            this.BtnToggleExpansion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnToggleExpansion.Name = "BtnToggleExpansion";
            this.BtnToggleExpansion.Size = new System.Drawing.Size(23, 22);
            this.BtnToggleExpansion.Text = "Expand/collapse";
            this.BtnToggleExpansion.Click += new System.EventHandler(this.BtnToggleExpansion_Click);
            // 
            // BtnRefreshTree
            // 
            this.BtnRefreshTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRefreshTree.Image = global::Snippeter.Properties.Resources.arrow_refresh;
            this.BtnRefreshTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefreshTree.Name = "BtnRefreshTree";
            this.BtnRefreshTree.Size = new System.Drawing.Size(23, 22);
            this.BtnRefreshTree.Text = "Reload tree";
            this.BtnRefreshTree.Click += new System.EventHandler(this.BtnRefreshTree_Click);
            // 
            // BtnCopyPasteOnClick
            // 
            this.BtnCopyPasteOnClick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCopyPasteOnClick.Image = global::Snippeter.Properties.Resources.lightning;
            this.BtnCopyPasteOnClick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCopyPasteOnClick.Name = "BtnCopyPasteOnClick";
            this.BtnCopyPasteOnClick.Size = new System.Drawing.Size(23, 22);
            this.BtnCopyPasteOnClick.Text = "Copy/paste on click";
            this.BtnCopyPasteOnClick.Click += new System.EventHandler(this.BtnCopyPasteOnClick_Click);
            // 
            // BtnToggleContentPanel
            // 
            this.BtnToggleContentPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnToggleContentPanel.Image = global::Snippeter.Properties.Resources.application_side_contract;
            this.BtnToggleContentPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnToggleContentPanel.Name = "BtnToggleContentPanel";
            this.BtnToggleContentPanel.Size = new System.Drawing.Size(23, 22);
            this.BtnToggleContentPanel.Text = "Hide/show content panel";
            this.BtnToggleContentPanel.Click += new System.EventHandler(this.BtnToggleContentPanel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Splitter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 275);
            this.panel1.TabIndex = 4;
            // 
            // Splitter
            // 
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splitter.Location = new System.Drawing.Point(0, 0);
            this.Splitter.Name = "Splitter";
            // 
            // Splitter.Panel1
            // 
            this.Splitter.Panel1.Controls.Add(this.panel3);
            // 
            // Splitter.Panel2
            // 
            this.Splitter.Panel2.Controls.Add(this.panel2);
            this.Splitter.Size = new System.Drawing.Size(463, 275);
            this.Splitter.SplitterDistance = 154;
            this.Splitter.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snippeter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Splitter.Panel1.ResumeLayout(false);
            this.Splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).EndInit();
            this.Splitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList TreeViewIcons;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnOptionAlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem BtnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtContents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnTrimLines;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnPasteIntoEclipse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TreeView SnippetTreeView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnOpenSnippetsFolder;
        private System.Windows.Forms.ToolStripButton BtnToggleExpansion;
        private System.Windows.Forms.ToolStripButton BtnRefreshTree;
        private System.Windows.Forms.ToolStripButton BtnCopyPasteOnClick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer Splitter;
        private System.Windows.Forms.ToolStripButton BtnToggleContentPanel;
        private System.Windows.Forms.ToolStripMenuItem BtnSelectDestProc;
        private System.Windows.Forms.ToolStripStatusLabel LblDestProc;
    }
}

