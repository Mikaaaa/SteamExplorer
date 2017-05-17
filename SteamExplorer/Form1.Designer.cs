namespace SteamExplorer
{
    partial class Form1
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
            this.Lbltitle = new MetroFramework.Controls.MetroLabel();
            this.LblContent = new MetroFramework.Controls.MetroLabel();
            this.WbContent = new System.Windows.Forms.WebBrowser();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CbxUpdate = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbltitle
            // 
            this.Lbltitle.AutoSize = true;
            this.Lbltitle.Location = new System.Drawing.Point(24, 64);
            this.Lbltitle.Name = "Lbltitle";
            this.Lbltitle.Size = new System.Drawing.Size(33, 19);
            this.Lbltitle.TabIndex = 0;
            this.Lbltitle.Text = "Title";
            // 
            // LblContent
            // 
            this.LblContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContent.AutoSize = true;
            this.LblContent.Location = new System.Drawing.Point(24, 113);
            this.LblContent.Name = "LblContent";
            this.LblContent.Size = new System.Drawing.Size(55, 19);
            this.LblContent.TabIndex = 30;
            this.LblContent.Text = "Content";
            // 
            // WbContent
            // 
            this.WbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WbContent.Location = new System.Drawing.Point(0, 0);
            this.WbContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.WbContent.Name = "WbContent";
            this.WbContent.Size = new System.Drawing.Size(647, 308);
            this.WbContent.TabIndex = 31;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.WbContent);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 96);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(647, 308);
            this.metroPanel1.TabIndex = 32;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CbxUpdate
            // 
            this.CbxUpdate.FormattingEnabled = true;
            this.CbxUpdate.ItemHeight = 23;
            this.CbxUpdate.Location = new System.Drawing.Point(118, 27);
            this.CbxUpdate.Name = "CbxUpdate";
            this.CbxUpdate.Size = new System.Drawing.Size(538, 29);
            this.CbxUpdate.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 415);
            this.Controls.Add(this.CbxUpdate);
            this.Controls.Add(this.LblContent);
            this.Controls.Add(this.Lbltitle);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "News";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Lbltitle;
        private MetroFramework.Controls.MetroLabel LblContent;
        private System.Windows.Forms.WebBrowser WbContent;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox CbxUpdate;
    }
}

