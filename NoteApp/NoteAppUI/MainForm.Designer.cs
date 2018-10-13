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
            this.nameOfNoteTextBox = new System.Windows.Forms.TextBox();
            this.noteContentTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.panelBlock = new System.Windows.Forms.Panel();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.createdTextLabel = new System.Windows.Forms.Label();
            this.lastEditTextLabel = new System.Windows.Forms.Label();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.contentInputLabel = new System.Windows.Forms.Label();
            this.categorySelectLabel = new System.Windows.Forms.Label();
            this.dateOfCreationTextBox = new System.Windows.Forms.TextBox();
            this.dateOfLastEditTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.listOfNotesTextBox = new System.Windows.Forms.TextBox();
            this.currentProjectLabel = new System.Windows.Forms.Label();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.noteTitleLabel = new System.Windows.Forms.Label();
            this.listOfNotesComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listBoxOfNoteCategory = new System.Windows.Forms.ListBox();
            this.listOfNotesLabel = new System.Windows.Forms.Label();
            this.panelBlock.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameOfNoteTextBox
            // 
            this.nameOfNoteTextBox.Location = new System.Drawing.Point(105, 60);
            this.nameOfNoteTextBox.Name = "nameOfNoteTextBox";
            this.nameOfNoteTextBox.Size = new System.Drawing.Size(208, 20);
            this.nameOfNoteTextBox.TabIndex = 1;
            // 
            // noteContentTextBox
            // 
            this.noteContentTextBox.Location = new System.Drawing.Point(105, 98);
            this.noteContentTextBox.Multiline = true;
            this.noteContentTextBox.Name = "noteContentTextBox";
            this.noteContentTextBox.Size = new System.Drawing.Size(208, 169);
            this.noteContentTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(713, 412);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panelBlock
            // 
            this.panelBlock.BackColor = System.Drawing.Color.LightGray;
            this.panelBlock.Controls.Add(this.contentTextBox);
            this.panelBlock.Location = new System.Drawing.Point(335, 128);
            this.panelBlock.Name = "panelBlock";
            this.panelBlock.Size = new System.Drawing.Size(465, 261);
            this.panelBlock.TabIndex = 5;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contentTextBox.Location = new System.Drawing.Point(3, 3);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.Size = new System.Drawing.Size(459, 255);
            this.contentTextBox.TabIndex = 1;
            this.contentTextBox.Text = "...";
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextLabel.Location = new System.Drawing.Point(406, 63);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(30, 17);
            this.nameTextLabel.TabIndex = 1;
            this.nameTextLabel.Text = "title";
            // 
            // createdTextLabel
            // 
            this.createdTextLabel.AutoSize = true;
            this.createdTextLabel.Location = new System.Drawing.Point(345, 106);
            this.createdTextLabel.Name = "createdTextLabel";
            this.createdTextLabel.Size = new System.Drawing.Size(46, 13);
            this.createdTextLabel.TabIndex = 2;
            this.createdTextLabel.Text = "created:";
            // 
            // lastEditTextLabel
            // 
            this.lastEditTextLabel.AutoSize = true;
            this.lastEditTextLabel.Location = new System.Drawing.Point(634, 106);
            this.lastEditTextLabel.Name = "lastEditTextLabel";
            this.lastEditTextLabel.Size = new System.Drawing.Size(46, 13);
            this.lastEditTextLabel.TabIndex = 3;
            this.lastEditTextLabel.Text = "last edit:";
            // 
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameInputLabel.Location = new System.Drawing.Point(12, 55);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(63, 24);
            this.nameInputLabel.TabIndex = 6;
            this.nameInputLabel.Text = "name:";
            // 
            // contentInputLabel
            // 
            this.contentInputLabel.AutoSize = true;
            this.contentInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contentInputLabel.Location = new System.Drawing.Point(12, 98);
            this.contentInputLabel.Name = "contentInputLabel";
            this.contentInputLabel.Size = new System.Drawing.Size(77, 24);
            this.contentInputLabel.TabIndex = 7;
            this.contentInputLabel.Text = "content:";
            // 
            // categorySelectLabel
            // 
            this.categorySelectLabel.AutoSize = true;
            this.categorySelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categorySelectLabel.Location = new System.Drawing.Point(12, 303);
            this.categorySelectLabel.Name = "categorySelectLabel";
            this.categorySelectLabel.Size = new System.Drawing.Size(87, 24);
            this.categorySelectLabel.TabIndex = 8;
            this.categorySelectLabel.Text = "category:";
            // 
            // dateOfCreationTextBox
            // 
            this.dateOfCreationTextBox.Location = new System.Drawing.Point(397, 102);
            this.dateOfCreationTextBox.Name = "dateOfCreationTextBox";
            this.dateOfCreationTextBox.ReadOnly = true;
            this.dateOfCreationTextBox.Size = new System.Drawing.Size(104, 20);
            this.dateOfCreationTextBox.TabIndex = 9;
            // 
            // dateOfLastEditTextBox
            // 
            this.dateOfLastEditTextBox.Location = new System.Drawing.Point(686, 102);
            this.dateOfLastEditTextBox.Name = "dateOfLastEditTextBox";
            this.dateOfLastEditTextBox.ReadOnly = true;
            this.dateOfLastEditTextBox.Size = new System.Drawing.Size(104, 20);
            this.dateOfLastEditTextBox.TabIndex = 10;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.categoryLabel.Location = new System.Drawing.Point(332, 415);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(65, 17);
            this.categoryLabel.TabIndex = 11;
            this.categoryLabel.Text = "Category";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.footerPanel.Controls.Add(this.listOfNotesLabel);
            this.footerPanel.Controls.Add(this.listOfNotesComboBox);
            this.footerPanel.Controls.Add(this.listOfNotesTextBox);
            this.footerPanel.Controls.Add(this.currentProjectLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 444);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(800, 146);
            this.footerPanel.TabIndex = 12;
            // 
            // listOfNotesTextBox
            // 
            this.listOfNotesTextBox.Location = new System.Drawing.Point(16, 39);
            this.listOfNotesTextBox.Multiline = true;
            this.listOfNotesTextBox.Name = "listOfNotesTextBox";
            this.listOfNotesTextBox.ReadOnly = true;
            this.listOfNotesTextBox.Size = new System.Drawing.Size(248, 95);
            this.listOfNotesTextBox.TabIndex = 2;
            // 
            // currentProjectLabel
            // 
            this.currentProjectLabel.AutoSize = true;
            this.currentProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentProjectLabel.Location = new System.Drawing.Point(12, 12);
            this.currentProjectLabel.Name = "currentProjectLabel";
            this.currentProjectLabel.Size = new System.Drawing.Size(135, 24);
            this.currentProjectLabel.TabIndex = 13;
            this.currentProjectLabel.Text = "Current Project";
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.greetingsLabel.Location = new System.Drawing.Point(13, 9);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(103, 17);
            this.greetingsLabel.TabIndex = 13;
            this.greetingsLabel.Text = "Make new note";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.headerPanel.Controls.Add(this.greetingsLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 39);
            this.headerPanel.TabIndex = 14;
            // 
            // noteTitleLabel
            // 
            this.noteTitleLabel.AutoSize = true;
            this.noteTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.noteTitleLabel.Location = new System.Drawing.Point(332, 63);
            this.noteTitleLabel.Name = "noteTitleLabel";
            this.noteTitleLabel.Size = new System.Drawing.Size(68, 17);
            this.noteTitleLabel.TabIndex = 15;
            this.noteTitleLabel.Text = "Note title:";
            // 
            // listOfNotesComboBox
            // 
            this.listOfNotesComboBox.FormattingEnabled = true;
            this.listOfNotesComboBox.Location = new System.Drawing.Point(587, 17);
            this.listOfNotesComboBox.Name = "listOfNotesComboBox";
            this.listOfNotesComboBox.Size = new System.Drawing.Size(162, 21);
            this.listOfNotesComboBox.TabIndex = 14;
            this.listOfNotesComboBox.SelectedIndexChanged += new System.EventHandler(this.listOfNotesComboBox_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(614, 412);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // listBoxOfNoteCategory
            // 
            this.listBoxOfNoteCategory.FormattingEnabled = true;
            this.listBoxOfNoteCategory.Items.AddRange(new object[] {
            "Work",
            "Home",
            "Health and Sport",
            "People",
            "Documents",
            "Finance",
            "Other"});
            this.listBoxOfNoteCategory.Location = new System.Drawing.Point(105, 303);
            this.listBoxOfNoteCategory.Name = "listBoxOfNoteCategory";
            this.listBoxOfNoteCategory.Size = new System.Drawing.Size(208, 95);
            this.listBoxOfNoteCategory.TabIndex = 17;
            this.listBoxOfNoteCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxOfNoteCategory_SelectedIndexChanged);
            // 
            // listOfNotesLabel
            // 
            this.listOfNotesLabel.AutoSize = true;
            this.listOfNotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfNotesLabel.Location = new System.Drawing.Point(468, 14);
            this.listOfNotesLabel.Name = "listOfNotesLabel";
            this.listOfNotesLabel.Size = new System.Drawing.Size(113, 24);
            this.listOfNotesLabel.TabIndex = 15;
            this.listOfNotesLabel.Text = "List of notes:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.listBoxOfNoteCategory);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.noteTitleLabel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.dateOfLastEditTextBox);
            this.Controls.Add(this.dateOfCreationTextBox);
            this.Controls.Add(this.categorySelectLabel);
            this.Controls.Add(this.contentInputLabel);
            this.Controls.Add(this.nameInputLabel);
            this.Controls.Add(this.lastEditTextLabel);
            this.Controls.Add(this.panelBlock);
            this.Controls.Add(this.createdTextLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameTextLabel);
            this.Controls.Add(this.noteContentTextBox);
            this.Controls.Add(this.nameOfNoteTextBox);
            this.Name = "MainForm";
            this.Text = "Test";
            this.panelBlock.ResumeLayout(false);
            this.panelBlock.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameOfNoteTextBox;
        private System.Windows.Forms.TextBox noteContentTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panelBlock;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label lastEditTextLabel;
        private System.Windows.Forms.Label createdTextLabel;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label contentInputLabel;
        private System.Windows.Forms.Label categorySelectLabel;
        private System.Windows.Forms.TextBox dateOfCreationTextBox;
        private System.Windows.Forms.TextBox dateOfLastEditTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label currentProjectLabel;
        private System.Windows.Forms.TextBox listOfNotesTextBox;
        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label noteTitleLabel;
        private System.Windows.Forms.ComboBox listOfNotesComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox listBoxOfNoteCategory;
        private System.Windows.Forms.Label listOfNotesLabel;
    }
}

