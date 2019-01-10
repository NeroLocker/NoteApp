namespace NoteAppUI
{
    partial class AddEditNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditNoteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.DateOfCreationTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.DateOfLastEditTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.OkButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CancelButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorShowingToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CategoryComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(82, 34);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CategoryComboBox.MaxLength = 20;
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(195, 24);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.Enter += new System.EventHandler(this.CategoryComboBox_Enter);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(743, 404);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(658, 404);
            this.OkButton.Margin = new System.Windows.Forms.Padding(5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentTextBox.Location = new System.Drawing.Point(5, 97);
            this.ContentTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ContentTextBox.MaxLength = 4096;
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(822, 297);
            this.ContentTextBox.TabIndex = 1;
            this.ContentTextBox.Enter += new System.EventHandler(this.ContentTextBox_Enter);
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CreatedLabel.Location = new System.Drawing.Point(6, 71);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(65, 16);
            this.CreatedLabel.TabIndex = 4;
            this.CreatedLabel.Text = "Created:  ";
            // 
            // DateOfCreationTextBox
            // 
            this.DateOfCreationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DateOfCreationTextBox.Location = new System.Drawing.Point(82, 68);
            this.DateOfCreationTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DateOfCreationTextBox.Name = "DateOfCreationTextBox";
            this.DateOfCreationTextBox.ReadOnly = true;
            this.DateOfCreationTextBox.Size = new System.Drawing.Size(119, 22);
            this.DateOfCreationTextBox.TabIndex = 5;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ModifiedLabel.Location = new System.Drawing.Point(211, 71);
            this.ModifiedLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(63, 16);
            this.ModifiedLabel.TabIndex = 7;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // DateOfLastEditTextBox
            // 
            this.DateOfLastEditTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DateOfLastEditTextBox.Location = new System.Drawing.Point(284, 68);
            this.DateOfLastEditTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DateOfLastEditTextBox.Name = "DateOfLastEditTextBox";
            this.DateOfLastEditTextBox.ReadOnly = true;
            this.DateOfLastEditTextBox.Size = new System.Drawing.Size(120, 22);
            this.DateOfLastEditTextBox.TabIndex = 8;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TitleLabel.Location = new System.Drawing.Point(6, 5);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(37, 16);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TitleTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TitleTextBox.Location = new System.Drawing.Point(82, 2);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TitleTextBox.MaxLength = 70;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(745, 22);
            this.TitleTextBox.TabIndex = 4;
            this.TitleTextBox.Enter += new System.EventHandler(this.TitleTextBox_Enter);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CancelButton);
            this.MainPanel.Controls.Add(this.OkButton);
            this.MainPanel.Controls.Add(this.CreatedLabel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.ContentTextBox);
            this.MainPanel.Controls.Add(this.DateOfCreationTextBox);
            this.MainPanel.Controls.Add(this.TitleTextBox);
            this.MainPanel.Controls.Add(this.ModifiedLabel);
            this.MainPanel.Controls.Add(this.CategoryComboBox);
            this.MainPanel.Controls.Add(this.DateOfLastEditTextBox);
            this.MainPanel.Controls.Add(this.TitleLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(832, 441);
            this.MainPanel.TabIndex = 1;
            // 
            // AddEditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 441);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(848, 480);
            this.Name = "AddEditNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Note";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button CancelButton;
        private new System.Windows.Forms.Button CancelButton;

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox DateOfCreationTextBox;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.TextBox DateOfLastEditTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ToolTip OkButtonToolTip;
        private System.Windows.Forms.ToolTip CancelButtonToolTip;
        private System.Windows.Forms.ToolTip ErrorShowingToolTip;
        private System.Windows.Forms.Panel MainPanel;
    }
}