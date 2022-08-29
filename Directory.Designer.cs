namespace sqlconn
{
    partial class Directory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Indicater_panel = new System.Windows.Forms.Panel();
            this.pListButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.upadteButton = new System.Windows.Forms.Button();
            this.add_ProductButton = new System.Windows.Forms.Button();
            this.panel_Mid = new System.Windows.Forms.Panel();
            this.PList_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.product_Card1 = new sqlconn.Product_Card();
            this.panel1.SuspendLayout();
            this.panel_Mid.SuspendLayout();
            this.PList_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Indicater_panel);
            this.panel1.Controls.Add(this.pListButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.upadteButton);
            this.panel1.Controls.Add(this.add_ProductButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 450);
            this.panel1.TabIndex = 0;
            // 
            // Indicater_panel
            // 
            this.Indicater_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Indicater_panel.Location = new System.Drawing.Point(34, 111);
            this.Indicater_panel.Name = "Indicater_panel";
            this.Indicater_panel.Size = new System.Drawing.Size(8, 20);
            this.Indicater_panel.TabIndex = 5;
            // 
            // pListButton
            // 
            this.pListButton.Location = new System.Drawing.Point(102, 334);
            this.pListButton.Name = "pListButton";
            this.pListButton.Size = new System.Drawing.Size(75, 23);
            this.pListButton.TabIndex = 4;
            this.pListButton.Text = "Product List";
            this.pListButton.UseVisualStyleBackColor = true;
            this.pListButton.Click += new System.EventHandler(this.pListButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(102, 281);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(102, 224);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // upadteButton
            // 
            this.upadteButton.Location = new System.Drawing.Point(102, 173);
            this.upadteButton.Name = "upadteButton";
            this.upadteButton.Size = new System.Drawing.Size(75, 23);
            this.upadteButton.TabIndex = 1;
            this.upadteButton.Text = "Update";
            this.upadteButton.UseVisualStyleBackColor = true;
            this.upadteButton.Click += new System.EventHandler(this.upadteButton_Click);
            // 
            // add_ProductButton
            // 
            this.add_ProductButton.Location = new System.Drawing.Point(102, 109);
            this.add_ProductButton.Name = "add_ProductButton";
            this.add_ProductButton.Size = new System.Drawing.Size(75, 23);
            this.add_ProductButton.TabIndex = 0;
            this.add_ProductButton.Text = "Add Product";
            this.add_ProductButton.UseVisualStyleBackColor = true;
            this.add_ProductButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_Mid
            // 
            this.panel_Mid.Controls.Add(this.PList_flowLayoutPanel);
            this.panel_Mid.Location = new System.Drawing.Point(289, 0);
            this.panel_Mid.Name = "panel_Mid";
            this.panel_Mid.Size = new System.Drawing.Size(510, 449);
            this.panel_Mid.TabIndex = 1;
            // 
            // PList_flowLayoutPanel
            // 
            this.PList_flowLayoutPanel.Controls.Add(this.product_Card1);
            this.PList_flowLayoutPanel.Location = new System.Drawing.Point(143, 61);
            this.PList_flowLayoutPanel.Name = "PList_flowLayoutPanel";
            this.PList_flowLayoutPanel.Size = new System.Drawing.Size(364, 377);
            this.PList_flowLayoutPanel.TabIndex = 0;
            // 
            // product_Card1
            // 
            this.product_Card1.Location = new System.Drawing.Point(3, 3);
            this.product_Card1.Name = "product_Card1";
            this.product_Card1.ProductDescription = null;
            this.product_Card1.Productname = null;
            this.product_Card1.ProductPrice = null;
            this.product_Card1.Size = new System.Drawing.Size(217, 178);
            this.product_Card1.TabIndex = 0;
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Mid);
            this.Controls.Add(this.panel1);
            this.Name = "Directory";
            this.Text = "Directory";
            this.Load += new System.EventHandler(this.Directory_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Mid.ResumeLayout(false);
            this.PList_flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Indicater_panel;
        private System.Windows.Forms.Button pListButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button upadteButton;
        private System.Windows.Forms.Button add_ProductButton;
        private System.Windows.Forms.Panel panel_Mid;
        private System.Windows.Forms.FlowLayoutPanel PList_flowLayoutPanel;
        private Product_Card product_Card1;
    }
}