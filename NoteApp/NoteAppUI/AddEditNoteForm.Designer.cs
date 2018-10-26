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
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.OkCancelButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.DatesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.DateOfCreationTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.DateOfLastEditTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.OkButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CancelButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorShowingToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainTableLayoutPanel.SuspendLayout();
            this.CategoryFlowLayoutPanel.SuspendLayout();
            this.OkCancelButtonsFlowLayoutPanel.SuspendLayout();
            this.DatesFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.CategoryFlowLayoutPanel, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.OkCancelButtonsFlowLayoutPanel, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.ContentTextBox, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.DatesFlowLayoutPanel, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 5;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(832, 441);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // CategoryFlowLayoutPanel
            // 
            this.CategoryFlowLayoutPanel.Controls.Add(this.label1);
            this.CategoryFlowLayoutPanel.Controls.Add(this.CategoryComboBox);
            this.CategoryFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryFlowLayoutPanel.Location = new System.Drawing.Point(3, 38);
            this.CategoryFlowLayoutPanel.Name = "CategoryFlowLayoutPanel";
            this.CategoryFlowLayoutPanel.Size = new System.Drawing.Size(826, 29);
            this.CategoryFlowLayoutPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(81, 3);
            this.CategoryComboBox.MaxLength = 20;
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.Enter += new System.EventHandler(this.CategoryComboBox_Enter);
            // 
            // OkCancelButtonsFlowLayoutPanel
            // 
            this.OkCancelButtonsFlowLayoutPanel.Controls.Add(this.CancelButton);
            this.OkCancelButtonsFlowLayoutPanel.Controls.Add(this.OkButton);
            this.OkCancelButtonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkCancelButtonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.OkCancelButtonsFlowLayoutPanel.Location = new System.Drawing.Point(3, 409);
            this.OkCancelButtonsFlowLayoutPanel.Name = "OkCancelButtonsFlowLayoutPanel";
            this.OkCancelButtonsFlowLayoutPanel.Size = new System.Drawing.Size(826, 29);
            this.OkCancelButtonsFlowLayoutPanel.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CancelButton.Location = new System.Drawing.Point(746, 5);
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
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OkButton.Location = new System.Drawing.Point(661, 5);
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
            this.ContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentTextBox.Location = new System.Drawing.Point(15, 110);
            this.ContentTextBox.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.ContentTextBox.MaxLength = 500;
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(802, 291);
            this.ContentTextBox.TabIndex = 1;
            this.ContentTextBox.Enter += new System.EventHandler(this.ContentTextBox_Enter);
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
            this.DatesFlowLayoutPanel.Size = new System.Drawing.Size(826, 29);
            this.DatesFlowLayoutPanel.TabIndex = 5;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(3, 4);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(72, 18);
            this.CreatedLabel.TabIndex = 4;
            this.CreatedLabel.Text = "Created:  ";
            // 
            // DateOfCreationTextBox
            // 
            this.DateOfCreationTextBox.Location = new System.Drawing.Point(81, 3);
            this.DateOfCreationTextBox.Name = "DateOfCreationTextBox";
            this.DateOfCreationTextBox.ReadOnly = true;
            this.DateOfCreationTextBox.Size = new System.Drawing.Size(120, 20);
            this.DateOfCreationTextBox.TabIndex = 5;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedLabel.Location = new System.Drawing.Point(207, 4);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(68, 18);
            this.ModifiedLabel.TabIndex = 7;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // DateOfLastEditTextBox
            // 
            this.DateOfLastEditTextBox.Location = new System.Drawing.Point(281, 3);
            this.DateOfLastEditTextBox.Name = "DateOfLastEditTextBox";
            this.DateOfLastEditTextBox.ReadOnly = true;
            this.DateOfLastEditTextBox.Size = new System.Drawing.Size(120, 20);
            this.DateOfLastEditTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TitleTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 29);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 18);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TitleTextBox.Location = new System.Drawing.Point(81, 3);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.TitleTextBox.MaxLength = 20;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(730, 20);
            this.TitleTextBox.TabIndex = 4;
            this.TitleTextBox.Enter += new System.EventHandler(this.TitleTextBox_Enter);
            // 
            // AddEditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 441);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(848, 480);
            this.Name = "AddEditNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Note";
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.CategoryFlowLayoutPanel.ResumeLayout(false);
            this.CategoryFlowLayoutPanel.PerformLayout();
            this.OkCancelButtonsFlowLayoutPanel.ResumeLayout(false);
            this.DatesFlowLayoutPanel.ResumeLayout(false);
            this.DatesFlowLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel OkCancelButtonsFlowLayoutPanel;

        //private System.Windows.Forms.Button CancelButton;
        private new System.Windows.Forms.Button CancelButton;

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.FlowLayoutPanel DatesFlowLayoutPanel;
        private System.Windows.Forms.TextBox DateOfCreationTextBox;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.TextBox DateOfLastEditTextBox;
        private System.Windows.Forms.FlowLayoutPanel CategoryFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ToolTip OkButtonToolTip;
        private System.Windows.Forms.ToolTip CancelButtonToolTip;
        private System.Windows.Forms.ToolTip ErrorShowingToolTip;
    }
}