namespace sqlconn
{
    partial class connectToSql
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
            this.conlabel = new System.Windows.Forms.Label();
            this.ConButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conlabel
            // 
            this.conlabel.AutoSize = true;
            this.conlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conlabel.Location = new System.Drawing.Point(391, 96);
            this.conlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conlabel.Name = "conlabel";
            this.conlabel.Size = new System.Drawing.Size(351, 31);
            this.conlabel.TabIndex = 0;
            this.conlabel.Text = "Connect To Sql DataBase";
            // 
            // ConButton
            // 
            this.ConButton.Location = new System.Drawing.Point(520, 236);
            this.ConButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConButton.Name = "ConButton";
            this.ConButton.Size = new System.Drawing.Size(112, 28);
            this.ConButton.TabIndex = 1;
            this.ConButton.Text = "Connect";
            this.ConButton.UseVisualStyleBackColor = true;
            this.ConButton.Click += new System.EventHandler(this.ConButton_Click);
            // 
            // connectToSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.ConButton);
            this.Controls.Add(this.conlabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "connectToSql";
            this.Text = "connectToSql";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conlabel;
        private System.Windows.Forms.Button ConButton;
    }
}