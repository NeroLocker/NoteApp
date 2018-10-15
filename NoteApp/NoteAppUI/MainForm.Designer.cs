namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OuterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftInnerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftInnerCategoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.WorkWithNotesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WorkWithNotesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.RightInnerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.RightInnerCategoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StaticCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DatesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.DateOfCreationTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.DateOfLastEditTextBox = new System.Windows.Forms.TextBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyAddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyEditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyRemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OuterTableLayoutPanel.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.LeftInnerTableLayoutPanel.SuspendLayout();
            this.LeftInnerCategoryFlowLayoutPanel.SuspendLayout();
            this.WorkWithNotesTableLayoutPanel.SuspendLayout();
            this.WorkWithNotesFlowLayoutPanel.SuspendLayout();
            this.RightInnerTableLayoutPanel.SuspendLayout();
            this.RightInnerCategoryFlowLayoutPanel.SuspendLayout();
            this.DatesFlowLayoutPanel.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OuterTableLayoutPanel
            // 
            this.OuterTableLayoutPanel.ColumnCount = 1;
            this.OuterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OuterTableLayoutPanel.Controls.Add(this.MainTableLayoutPanel, 0, 1);
            this.OuterTableLayoutPanel.Controls.Add(this.MainMenu, 0, 0);
            this.OuterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OuterTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.OuterTableLayoutPanel.Name = "OuterTableLayoutPanel";
            this.OuterTableLayoutPanel.RowCount = 2;
            this.OuterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.OuterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.OuterTableLayoutPanel.Size = new System.Drawing.Size(944, 501);
            this.OuterTableLayoutPanel.TabIndex = 0;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.LeftInnerTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.RightInnerTableLayoutPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(3, 28);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(938, 470);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // LeftInnerTableLayoutPanel
            // 
            this.LeftInnerTableLayoutPanel.ColumnCount = 1;
            this.LeftInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftInnerTableLayoutPanel.Controls.Add(this.LeftInnerCategoryFlowLayoutPanel, 0, 0);
            this.LeftInnerTableLayoutPanel.Controls.Add(this.NotesListBox, 0, 1);
            this.LeftInnerTableLayoutPanel.Controls.Add(this.WorkWithNotesTableLayoutPanel, 0, 2);
            this.LeftInnerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftInnerTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftInnerTableLayoutPanel.Name = "LeftInnerTableLayoutPanel";
            this.LeftInnerTableLayoutPanel.RowCount = 3;
            this.LeftInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.LeftInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LeftInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LeftInnerTableLayoutPanel.Size = new System.Drawing.Size(394, 464);
            this.LeftInnerTableLayoutPanel.TabIndex = 0;
            // 
            // LeftInnerCategoryFlowLayoutPanel
            // 
            this.LeftInnerCategoryFlowLayoutPanel.Controls.Add(this.ShowCategoryLabel);
            this.LeftInnerCategoryFlowLayoutPanel.Controls.Add(this.CategoryComboBox);
            this.LeftInnerCategoryFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftInnerCategoryFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftInnerCategoryFlowLayoutPanel.Name = "LeftInnerCategoryFlowLayoutPanel";
            this.LeftInnerCategoryFlowLayoutPanel.Size = new System.Drawing.Size(388, 29);
            this.LeftInnerCategoryFlowLayoutPanel.TabIndex = 1;
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCategoryLabel.Location = new System.Drawing.Point(3, 6);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(99, 16);
            this.ShowCategoryLabel.TabIndex = 0;
            this.ShowCategoryLabel.Text = "Show Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(108, 3);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(220, 23);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // NotesListBox
            // 
            this.NotesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.ItemHeight = 15;
            this.NotesListBox.Location = new System.Drawing.Point(3, 38);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(388, 337);
            this.NotesListBox.TabIndex = 2;
            // 
            // WorkWithNotesTableLayoutPanel
            // 
            this.WorkWithNotesTableLayoutPanel.ColumnCount = 1;
            this.WorkWithNotesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WorkWithNotesTableLayoutPanel.Controls.Add(this.WorkWithNotesFlowLayoutPanel, 0, 1);
            this.WorkWithNotesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkWithNotesTableLayoutPanel.Location = new System.Drawing.Point(3, 381);
            this.WorkWithNotesTableLayoutPanel.Name = "WorkWithNotesTableLayoutPanel";
            this.WorkWithNotesTableLayoutPanel.RowCount = 2;
            this.WorkWithNotesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WorkWithNotesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.WorkWithNotesTableLayoutPanel.Size = new System.Drawing.Size(388, 80);
            this.WorkWithNotesTableLayoutPanel.TabIndex = 3;
            // 
            // WorkWithNotesFlowLayoutPanel
            // 
            this.WorkWithNotesFlowLayoutPanel.Controls.Add(this.NewNoteButton);
            this.WorkWithNotesFlowLayoutPanel.Controls.Add(this.EditNoteButton);
            this.WorkWithNotesFlowLayoutPanel.Controls.Add(this.RemoveNoteButton);
            this.WorkWithNotesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkWithNotesFlowLayoutPanel.Location = new System.Drawing.Point(3, 48);
            this.WorkWithNotesFlowLayoutPanel.Name = "WorkWithNotesFlowLayoutPanel";
            this.WorkWithNotesFlowLayoutPanel.Size = new System.Drawing.Size(382, 29);
            this.WorkWithNotesFlowLayoutPanel.TabIndex = 0;
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewNoteButton.BackgroundImage = global::NoteAppUI.Properties.Resources.add_note;
            this.NewNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewNoteButton.Location = new System.Drawing.Point(3, 3);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(25, 25);
            this.NewNoteButton.TabIndex = 0;
            this.NewNoteButton.UseVisualStyleBackColor = true;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackgroundImage = global::NoteAppUI.Properties.Resources.edit_note;
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.Location = new System.Drawing.Point(34, 3);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(25, 25);
            this.EditNoteButton.TabIndex = 1;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.BackgroundImage = global::NoteAppUI.Properties.Resources.delete_note;
            this.RemoveNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveNoteButton.Location = new System.Drawing.Point(65, 3);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(25, 25);
            this.RemoveNoteButton.TabIndex = 2;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            // 
            // RightInnerTableLayoutPanel
            // 
            this.RightInnerTableLayoutPanel.ColumnCount = 1;
            this.RightInnerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightInnerTableLayoutPanel.Controls.Add(this.NoteNameLabel, 0, 0);
            this.RightInnerTableLayoutPanel.Controls.Add(this.RightInnerCategoryFlowLayoutPanel, 0, 1);
            this.RightInnerTableLayoutPanel.Controls.Add(this.DatesFlowLayoutPanel, 0, 2);
            this.RightInnerTableLayoutPanel.Controls.Add(this.ContentTextBox, 0, 3);
            this.RightInnerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightInnerTableLayoutPanel.Location = new System.Drawing.Point(403, 3);
            this.RightInnerTableLayoutPanel.Name = "RightInnerTableLayoutPanel";
            this.RightInnerTableLayoutPanel.RowCount = 4;
            this.RightInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.RightInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RightInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.RightInnerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightInnerTableLayoutPanel.Size = new System.Drawing.Size(532, 464);
            this.RightInnerTableLayoutPanel.TabIndex = 1;
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteNameLabel.Location = new System.Drawing.Point(3, 8);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(115, 24);
            this.NoteNameLabel.TabIndex = 0;
            this.NoteNameLabel.Text = "Note Name";
            // 
            // RightInnerCategoryFlowLayoutPanel
            // 
            this.RightInnerCategoryFlowLayoutPanel.Controls.Add(this.StaticCategoryLabel);
            this.RightInnerCategoryFlowLayoutPanel.Controls.Add(this.CategoryLabel);
            this.RightInnerCategoryFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightInnerCategoryFlowLayoutPanel.Location = new System.Drawing.Point(3, 43);
            this.RightInnerCategoryFlowLayoutPanel.Name = "RightInnerCategoryFlowLayoutPanel";
            this.RightInnerCategoryFlowLayoutPanel.Size = new System.Drawing.Size(526, 24);
            this.RightInnerCategoryFlowLayoutPanel.TabIndex = 2;
            // 
            // StaticCategoryLabel
            // 
            this.StaticCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StaticCategoryLabel.AutoSize = true;
            this.StaticCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaticCategoryLabel.Location = new System.Drawing.Point(3, 0);
            this.StaticCategoryLabel.Name = "StaticCategoryLabel";
            this.StaticCategoryLabel.Size = new System.Drawing.Size(72, 18);
            this.StaticCategoryLabel.TabIndex = 1;
            this.StaticCategoryLabel.Text = "Category:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(81, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 18);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "category";
            // 
            // DatesFlowLayoutPanel
            // 
            this.DatesFlowLayoutPanel.Controls.Add(this.CreatedLabel);
            this.DatesFlowLayoutPanel.Controls.Add(this.DateOfCreationTextBox);
            this.DatesFlowLayoutPanel.Controls.Add(this.ModifiedLabel);
            this.DatesFlowLayoutPanel.Controls.Add(this.DateOfLastEditTextBox);
            this.DatesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatesFlowLayoutPanel.Location = new System.Drawing.Point(3, 73);
            this.DatesFlowLayoutPanel.Name = "DatesFlowLayoutPanel";
            this.DatesFlowLayoutPanel.Size = new System.Drawing.Size(526, 29);
            this.DatesFlowLayoutPanel.TabIndex = 4;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(3, 4);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(64, 18);
            this.CreatedLabel.TabIndex = 3;
            this.CreatedLabel.Text = "Created:";
            // 
            // DateOfCreationTextBox
            // 
            this.DateOfCreationTextBox.Location = new System.Drawing.Point(73, 3);
            this.DateOfCreationTextBox.Name = "DateOfCreationTextBox";
            this.DateOfCreationTextBox.ReadOnly = true;
            this.DateOfCreationTextBox.Size = new System.Drawing.Size(100, 21);
            this.DateOfCreationTextBox.TabIndex = 4;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedLabel.Location = new System.Drawing.Point(179, 4);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(68, 18);
            this.ModifiedLabel.TabIndex = 5;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // DateOfLastEditTextBox
            // 
            this.DateOfLastEditTextBox.Location = new System.Drawing.Point(253, 3);
            this.DateOfLastEditTextBox.Name = "DateOfLastEditTextBox";
            this.DateOfLastEditTextBox.ReadOnly = true;
            this.DateOfLastEditTextBox.Size = new System.Drawing.Size(100, 21);
            this.DateOfLastEditTextBox.TabIndex = 6;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTextBox.Location = new System.Drawing.Point(3, 108);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ReadOnly = true;
            this.ContentTextBox.Size = new System.Drawing.Size(526, 353);
            this.ContentTextBox.TabIndex = 5;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyFileToolStripMenuItem,
            this.MyEditToolStripMenuItem,
            this.MyHelpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.Size = new System.Drawing.Size(944, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            // 
            // MyFileToolStripMenuItem
            // 
            this.MyFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyExitToolStripMenuItem});
            this.MyFileToolStripMenuItem.Name = "MyFileToolStripMenuItem";
            this.MyFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.MyFileToolStripMenuItem.Text = "File";
            // 
            // MyExitToolStripMenuItem
            // 
            this.MyExitToolStripMenuItem.Name = "MyExitToolStripMenuItem";
            this.MyExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.MyExitToolStripMenuItem.Text = "Exit";
            // 
            // MyEditToolStripMenuItem
            // 
            this.MyEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyAddNoteToolStripMenuItem,
            this.MyEditNoteToolStripMenuItem,
            this.MyRemoveNoteToolStripMenuItem});
            this.MyEditToolStripMenuItem.Name = "MyEditToolStripMenuItem";
            this.MyEditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.MyEditToolStripMenuItem.Text = "Edit";
            // 
            // MyAddNoteToolStripMenuItem
            // 
            this.MyAddNoteToolStripMenuItem.Name = "MyAddNoteToolStripMenuItem";
            this.MyAddNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MyAddNoteToolStripMenuItem.Text = "Add Note";
            this.MyAddNoteToolStripMenuItem.Click += new System.EventHandler(this.MyAddNoteToolStripMenuItem_Click);
            // 
            // MyEditNoteToolStripMenuItem
            // 
            this.MyEditNoteToolStripMenuItem.Name = "MyEditNoteToolStripMenuItem";
            this.MyEditNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MyEditNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // MyRemoveNoteToolStripMenuItem
            // 
            this.MyRemoveNoteToolStripMenuItem.Name = "MyRemoveNoteToolStripMenuItem";
            this.MyRemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MyRemoveNoteToolStripMenuItem.Text = "Remove Note";
            // 
            // MyHelpToolStripMenuItem
            // 
            this.MyHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyAboutToolStripMenuItem});
            this.MyHelpToolStripMenuItem.Name = "MyHelpToolStripMenuItem";
            this.MyHelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.MyHelpToolStripMenuItem.Text = "Help";
            // 
            // MyAboutToolStripMenuItem
            // 
            this.MyAboutToolStripMenuItem.Name = "MyAboutToolStripMenuItem";
            this.MyAboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MyAboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MyAboutToolStripMenuItem.Text = "About";
            this.MyAboutToolStripMenuItem.Click += new System.EventHandler(this.MyAboutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addNoteToolStripMenuItem.Text = "Add note";
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.OuterTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(848, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.OuterTableLayoutPanel.ResumeLayout(false);
            this.OuterTableLayoutPanel.PerformLayout();
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.LeftInnerTableLayoutPanel.ResumeLayout(false);
            this.LeftInnerCategoryFlowLayoutPanel.ResumeLayout(false);
            this.LeftInnerCategoryFlowLayoutPanel.PerformLayout();
            this.WorkWithNotesTableLayoutPanel.ResumeLayout(false);
            this.WorkWithNotesFlowLayoutPanel.ResumeLayout(false);
            this.RightInnerTableLayoutPanel.ResumeLayout(false);
            this.RightInnerTableLayoutPanel.PerformLayout();
            this.RightInnerCategoryFlowLayoutPanel.ResumeLayout(false);
            this.RightInnerCategoryFlowLayoutPanel.PerformLayout();
            this.DatesFlowLayoutPanel.ResumeLayout(false);
            this.DatesFlowLayoutPanel.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OuterTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel LeftInnerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel RightInnerTableLayoutPanel;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.FlowLayoutPanel LeftInnerCategoryFlowLayoutPanel;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.TableLayoutPanel WorkWithNotesTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel WorkWithNotesFlowLayoutPanel;
        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.Label StaticCategoryLabel;
        private System.Windows.Forms.FlowLayoutPanel RightInnerCategoryFlowLayoutPanel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ToolStripMenuItem MyFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyAddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyEditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyRemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyAboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel DatesFlowLayoutPanel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox DateOfCreationTextBox;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.TextBox DateOfLastEditTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
    }
}

