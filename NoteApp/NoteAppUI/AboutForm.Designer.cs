namespace NoteAppUI
{
    partial class AboutForm
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
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppNameLabel.Location = new System.Drawing.Point(28, 23);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(92, 24);
            this.AppNameLabel.TabIndex = 1;
            this.AppNameLabel.Text = "NoteApp";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.VersionLabel);
            this.HeaderPanel.Controls.Add(this.AppNameLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(509, 100);
            this.HeaderPanel.TabIndex = 2;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel.Location = new System.Drawing.Point(29, 59);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(45, 15);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GitHubLinkLabel);
            this.panel1.Controls.Add(this.EmailLinkLabel);
            this.panel1.Controls.Add(this.GitHubLabel);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.AuthorLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 155);
            this.panel1.TabIndex = 3;
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(77, 113);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(156, 13);
            this.GitHubLinkLabel.TabIndex = 7;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "https://github.com/NeroLocker";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Location = new System.Drawing.Point(77, 83);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(122, 13);
            this.EmailLinkLabel.TabIndex = 6;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "halfer.locker@yandex.ru";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHubLabel.Location = new System.Drawing.Point(29, 112);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(48, 15);
            this.GitHubLabel.TabIndex = 5;
            this.GitHubLabel.Text = "GitHub:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(29, 82);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 15);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(29, 40);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(154, 15);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Author: Alexander Chudnov";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.FooterLabel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 302);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(509, 44);
            this.FooterPanel.TabIndex = 4;
            // 
            // FooterLabel
            // 
            this.FooterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FooterLabel.AutoSize = true;
            this.FooterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FooterLabel.Location = new System.Drawing.Point(29, 20);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(156, 15);
            this.FooterLabel.TabIndex = 6;
            this.FooterLabel.Text = "2018 Alexander Chudnov ©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 346);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label FooterLabel;
    }
}