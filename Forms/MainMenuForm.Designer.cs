
namespace WebScraper.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.savedCarsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.savedCarsButton);
            this.buttonsPanel.Controls.Add(this.searchButton);
            this.buttonsPanel.Controls.Add(this.panel1);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(160, 753);
            this.buttonsPanel.TabIndex = 0;
            // 
            // savedCarsButton
            // 
            this.savedCarsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.savedCarsButton.Location = new System.Drawing.Point(0, 142);
            this.savedCarsButton.Name = "savedCarsButton";
            this.savedCarsButton.Size = new System.Drawing.Size(160, 64);
            this.savedCarsButton.TabIndex = 3;
            this.savedCarsButton.Text = "Saved Cars";
            this.savedCarsButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.Location = new System.Drawing.Point(0, 78);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 64);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 78);
            this.panel1.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(160, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(822, 78);
            this.titlePanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Sylfaen", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(276, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(217, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Car Searcher";
            // 
            // formPanel
            // 
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(160, 78);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(822, 675);
            this.formPanel.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.buttonsPanel);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.buttonsPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button savedCarsButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Panel formPanel;
    }
}