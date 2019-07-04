namespace StockManagementSystemApp
{
    partial class Home
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
            this.categorySetupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.companySetupLinkLevel = new System.Windows.Forms.LinkLabel();
            this.itemSetupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.stockInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.stockOutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchSummaryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchViewLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // categorySetupLinkLabel
            // 
            this.categorySetupLinkLabel.AutoSize = true;
            this.categorySetupLinkLabel.Location = new System.Drawing.Point(333, 90);
            this.categorySetupLinkLabel.Name = "categorySetupLinkLabel";
            this.categorySetupLinkLabel.Size = new System.Drawing.Size(80, 13);
            this.categorySetupLinkLabel.TabIndex = 0;
            this.categorySetupLinkLabel.TabStop = true;
            this.categorySetupLinkLabel.Text = "Category Setup";
            this.categorySetupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.categorySetupLinkLabel_LinkClicked);
            // 
            // companySetupLinkLevel
            // 
            this.companySetupLinkLevel.AutoSize = true;
            this.companySetupLinkLevel.Location = new System.Drawing.Point(333, 127);
            this.companySetupLinkLevel.Name = "companySetupLinkLevel";
            this.companySetupLinkLevel.Size = new System.Drawing.Size(82, 13);
            this.companySetupLinkLevel.TabIndex = 0;
            this.companySetupLinkLevel.TabStop = true;
            this.companySetupLinkLevel.Text = "Company Setup";
            this.companySetupLinkLevel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.companySetupLinkLevel_LinkClicked);
            // 
            // itemSetupLinkLabel
            // 
            this.itemSetupLinkLabel.AutoSize = true;
            this.itemSetupLinkLabel.Location = new System.Drawing.Point(333, 163);
            this.itemSetupLinkLabel.Name = "itemSetupLinkLabel";
            this.itemSetupLinkLabel.Size = new System.Drawing.Size(58, 13);
            this.itemSetupLinkLabel.TabIndex = 0;
            this.itemSetupLinkLabel.TabStop = true;
            this.itemSetupLinkLabel.Text = "Item Setup";
            this.itemSetupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.itemSetupLinkLabel_LinkClicked);
            // 
            // stockInLinkLabel
            // 
            this.stockInLinkLabel.AutoSize = true;
            this.stockInLinkLabel.Location = new System.Drawing.Point(333, 204);
            this.stockInLinkLabel.Name = "stockInLinkLabel";
            this.stockInLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.stockInLinkLabel.TabIndex = 0;
            this.stockInLinkLabel.TabStop = true;
            this.stockInLinkLabel.Text = "Stock In";
            this.stockInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stockInLinkLabel_LinkClicked);
            // 
            // stockOutLinkLabel
            // 
            this.stockOutLinkLabel.AutoSize = true;
            this.stockOutLinkLabel.Location = new System.Drawing.Point(333, 237);
            this.stockOutLinkLabel.Name = "stockOutLinkLabel";
            this.stockOutLinkLabel.Size = new System.Drawing.Size(55, 13);
            this.stockOutLinkLabel.TabIndex = 0;
            this.stockOutLinkLabel.TabStop = true;
            this.stockOutLinkLabel.Text = "Stock Out";
            this.stockOutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stockOutLinkLabel_LinkClicked);
            // 
            // searchSummaryLinkLabel
            // 
            this.searchSummaryLinkLabel.AutoSize = true;
            this.searchSummaryLinkLabel.Location = new System.Drawing.Point(333, 267);
            this.searchSummaryLinkLabel.Name = "searchSummaryLinkLabel";
            this.searchSummaryLinkLabel.Size = new System.Drawing.Size(87, 13);
            this.searchSummaryLinkLabel.TabIndex = 0;
            this.searchSummaryLinkLabel.TabStop = true;
            this.searchSummaryLinkLabel.Text = "Search Summary";
            this.searchSummaryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.searchSummaryLinkLabel_LinkClicked);
            // 
            // searchViewLinkLabel
            // 
            this.searchViewLinkLabel.AutoSize = true;
            this.searchViewLinkLabel.Location = new System.Drawing.Point(333, 295);
            this.searchViewLinkLabel.Name = "searchViewLinkLabel";
            this.searchViewLinkLabel.Size = new System.Drawing.Size(67, 13);
            this.searchViewLinkLabel.TabIndex = 0;
            this.searchViewLinkLabel.TabStop = true;
            this.searchViewLinkLabel.Text = "Search View";
            this.searchViewLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.searchViewLinkLabel_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchViewLinkLabel);
            this.Controls.Add(this.searchSummaryLinkLabel);
            this.Controls.Add(this.stockOutLinkLabel);
            this.Controls.Add(this.stockInLinkLabel);
            this.Controls.Add(this.itemSetupLinkLabel);
            this.Controls.Add(this.companySetupLinkLevel);
            this.Controls.Add(this.categorySetupLinkLabel);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel categorySetupLinkLabel;
        private System.Windows.Forms.LinkLabel companySetupLinkLevel;
        private System.Windows.Forms.LinkLabel itemSetupLinkLabel;
        private System.Windows.Forms.LinkLabel stockInLinkLabel;
        private System.Windows.Forms.LinkLabel stockOutLinkLabel;
        private System.Windows.Forms.LinkLabel searchSummaryLinkLabel;
        private System.Windows.Forms.LinkLabel searchViewLinkLabel;
    }
}