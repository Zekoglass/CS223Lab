namespace sqlconn
{
    partial class Product_Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name_label = new System.Windows.Forms.Label();
            this.dESC_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(34, 49);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(55, 20);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "Name";
            // 
            // dESC_label
            // 
            this.dESC_label.AutoSize = true;
            this.dESC_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESC_label.Location = new System.Drawing.Point(35, 95);
            this.dESC_label.Name = "dESC_label";
            this.dESC_label.Size = new System.Drawing.Size(86, 16);
            this.dESC_label.TabIndex = 1;
            this.dESC_label.Text = "Description";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.Location = new System.Drawing.Point(35, 136);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(36, 13);
            this.Price_label.TabIndex = 2;
            this.Price_label.Text = "Price";
            // 
            // Product_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.dESC_label);
            this.Controls.Add(this.Name_label);
            this.Name = "Product_Card";
            this.Size = new System.Drawing.Size(217, 178);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label dESC_label;
        private System.Windows.Forms.Label Price_label;
    }
}
