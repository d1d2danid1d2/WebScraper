
namespace WebScraper.Forms
{
    partial class SearchForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.pageCount = new System.Windows.Forms.TextBox();
            this.nrOfResults = new System.Windows.Forms.TextBox();
            this.searchLink = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultBoxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(29, 302);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 57);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pageCount
            // 
            this.pageCount.Location = new System.Drawing.Point(38, 56);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(125, 27);
            this.pageCount.TabIndex = 3;
            // 
            // nrOfResults
            // 
            this.nrOfResults.Location = new System.Drawing.Point(0, 0);
            this.nrOfResults.Name = "nrOfResults";
            this.nrOfResults.Size = new System.Drawing.Size(100, 27);
            this.nrOfResults.TabIndex = 6;
            // 
            // searchLink
            // 
            this.searchLink.Location = new System.Drawing.Point(3, 48);
            this.searchLink.Name = "searchLink";
            this.searchLink.Size = new System.Drawing.Size(206, 27);
            this.searchLink.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultBoxCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nrOfResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 450);
            this.panel1.TabIndex = 6;
            // 
            // resultBoxCount
            // 
            this.resultBoxCount.Location = new System.Drawing.Point(29, 411);
            this.resultBoxCount.Name = "resultBoxCount";
            this.resultBoxCount.ReadOnly = true;
            this.resultBoxCount.Size = new System.Drawing.Size(125, 27);
            this.resultBoxCount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Results nr";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pageCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 129);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nr of \r\npages to search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel);
            this.panel2.Controls.Add(this.searchLink);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 129);
            this.panel2.TabIndex = 0;
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel.Location = new System.Drawing.Point(70, 9);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(73, 36);
            this.linkLabel.TabIndex = 0;
            this.linkLabel.Text = "Link";
            // 
            // resultBox
            // 
            this.resultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultBox.ItemHeight = 20;
            this.resultBox.Location = new System.Drawing.Point(212, 0);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(588, 450);
            this.resultBox.TabIndex = 0;
            this.resultBox.SelectedIndexChanged += new System.EventHandler(this.ResultBox_SelectedIndexChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox pageCount;
        private System.Windows.Forms.TextBox nrOfResults;
        private System.Windows.Forms.TextBox searchLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBoxCount;
        public System.Windows.Forms.ListBox resultBox;
    }
}