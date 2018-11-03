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
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.StaticCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
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
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCategoryLabel.Location = new System.Drawing.Point(5, 5);
            this.ShowCategoryLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(99, 16);
            this.ShowCategoryLabel.TabIndex = 0;
            this.ShowCategoryLabel.Text = "Show Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(114, 2);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(195, 24);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.ItemHeight = 16;
            this.NotesListBox.Location = new System.Drawing.Point(8, 39);
            this.NotesListBox.Margin = new System.Windows.Forms.Padding(5);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(301, 388);
            this.NotesListBox.TabIndex = 2;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            this.NotesListBox.Enter += new System.EventHandler(this.NotesListBox_Enter);
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewNoteButton.BackgroundImage = global::NoteAppUI.Properties.Resources.add_note;
            this.NewNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewNoteButton.ForeColor = System.Drawing.SystemColors.Window;
            this.NewNoteButton.Location = new System.Drawing.Point(14, 438);
            this.NewNoteButton.Margin = new System.Windows.Forms.Padding(5);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(25, 25);
            this.NewNoteButton.TabIndex = 0;
            this.NewNoteButton.UseVisualStyleBackColor = true;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackgroundImage = global::NoteAppUI.Properties.Resources.edit_note;
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.ForeColor = System.Drawing.SystemColors.Window;
            this.EditNoteButton.Location = new System.Drawing.Point(84, 437);
            this.EditNoteButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(25, 25);
            this.EditNoteButton.TabIndex = 1;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.BackgroundImage = global::NoteAppUI.Properties.Resources.delete_note;
            this.RemoveNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNoteButton.ForeColor = System.Drawing.SystemColors.Window;
            this.RemoveNoteButton.Location = new System.Drawing.Point(49, 438);
            this.RemoveNoteButton.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(25, 25);
            this.RemoveNoteButton.TabIndex = 2;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteNameLabel.Location = new System.Drawing.Point(5, 5);
            this.NoteNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(77, 16);
            this.NoteNameLabel.TabIndex = 0;
            this.NoteNameLabel.Text = "Note Name";
            // 
            // StaticCategoryLabel
            // 
            this.StaticCategoryLabel.AutoSize = true;
            this.StaticCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaticCategoryLabel.Location = new System.Drawing.Point(5, 31);
            this.StaticCategoryLabel.Margin = new System.Windows.Forms.Padding(5);
            this.StaticCategoryLabel.Name = "StaticCategoryLabel";
            this.StaticCategoryLabel.Size = new System.Drawing.Size(66, 16);
            this.StaticCategoryLabel.TabIndex = 1;
            this.StaticCategoryLabel.Text = "Category:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(81, 31);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(61, 16);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "category";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(5, 57);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(59, 16);
            this.CreatedLabel.TabIndex = 3;
            this.CreatedLabel.Text = "Created:";
            // 
            // DateOfCreationTextBox
            // 
            this.DateOfCreationTextBox.Location = new System.Drawing.Point(74, 54);
            this.DateOfCreationTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DateOfCreationTextBox.Name = "DateOfCreationTextBox";
            this.DateOfCreationTextBox.ReadOnly = true;
            this.DateOfCreationTextBox.Size = new System.Drawing.Size(120, 21);
            this.DateOfCreationTextBox.TabIndex = 4;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedLabel.Location = new System.Drawing.Point(204, 57);
            this.ModifiedLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(63, 16);
            this.ModifiedLabel.TabIndex = 5;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // DateOfLastEditTextBox
            // 
            this.DateOfLastEditTextBox.Location = new System.Drawing.Point(277, 54);
            this.DateOfLastEditTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DateOfLastEditTextBox.Name = "DateOfLastEditTextBox";
            this.DateOfLastEditTextBox.ReadOnly = true;
            this.DateOfLastEditTextBox.Size = new System.Drawing.Size(120, 21);
            this.DateOfLastEditTextBox.TabIndex = 6;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ContentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentTextBox.Location = new System.Drawing.Point(8, 85);
            this.ContentTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ReadOnly = true;
            this.ContentTextBox.Size = new System.Drawing.Size(613, 387);
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
            this.MyExitToolStripMenuItem.Click += new System.EventHandler(this.MyExitToolStripMenuItem_Click);
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
            this.MyAddNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.MyAddNoteToolStripMenuItem.Text = "Add Note";
            this.MyAddNoteToolStripMenuItem.Click += new System.EventHandler(this.MyAddNoteToolStripMenuItem_Click);
            // 
            // MyEditNoteToolStripMenuItem
            // 
            this.MyEditNoteToolStripMenuItem.Name = "MyEditNoteToolStripMenuItem";
            this.MyEditNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.MyEditNoteToolStripMenuItem.Text = "Edit Note";
            this.MyEditNoteToolStripMenuItem.Click += new System.EventHandler(this.MyEditNoteToolStripMenuItem_Click);
            // 
            // MyRemoveNoteToolStripMenuItem
            // 
            this.MyRemoveNoteToolStripMenuItem.Name = "MyRemoveNoteToolStripMenuItem";
            this.MyRemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.MyRemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.MyRemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.MyRemoveNoteToolStripMenuItem_Click);
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
            this.MyAboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.NewNoteButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.EditNoteButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.NotesListBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.RemoveNoteButton);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.CreatedLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.StaticCategoryLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.ContentTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.DateOfCreationTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.NoteNameLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.ModifiedLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.CategoryLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.DateOfLastEditTextBox);
            this.MainSplitContainer.Size = new System.Drawing.Size(944, 477);
            this.MainSplitContainer.SplitterDistance = 314;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.Label StaticCategoryLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ToolStripMenuItem MyFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyAddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyEditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyRemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyAboutToolStripMenuItem;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox DateOfCreationTextBox;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.TextBox DateOfLastEditTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
    }
}

