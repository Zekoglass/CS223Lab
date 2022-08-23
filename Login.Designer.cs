namespace sqlconn
{
    partial class Login
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancButton = new System.Windows.Forms.Button();
            this.uName = new System.Windows.Forms.TextBox();
            this.pWord = new System.Windows.Forms.TextBox();
            this.userN = new System.Windows.Forms.Label();
            this.paw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(256, 271);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.ADD_Click);
            // 
            // cancButton
            // 
            this.cancButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancButton.Location = new System.Drawing.Point(405, 271);
            this.cancButton.Name = "cancButton";
            this.cancButton.Size = new System.Drawing.Size(116, 35);
            this.cancButton.TabIndex = 1;
            this.cancButton.Text = "CANCEL";
            this.cancButton.UseVisualStyleBackColor = true;
            this.cancButton.Click += new System.EventHandler(this.cancButton_Click);
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(353, 120);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(168, 20);
            this.uName.TabIndex = 2;
            // 
            // pWord
            // 
            this.pWord.Location = new System.Drawing.Point(353, 185);
            this.pWord.Name = "pWord";
            this.pWord.Size = new System.Drawing.Size(172, 20);
            this.pWord.TabIndex = 3;
            // 
            // userN
            // 
            this.userN.AutoSize = true;
            this.userN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userN.Location = new System.Drawing.Point(203, 118);
            this.userN.Name = "userN";
            this.userN.Size = new System.Drawing.Size(103, 20);
            this.userN.TabIndex = 4;
            this.userN.Text = "User Name ";
            // 
            // paw
            // 
            this.paw.AutoSize = true;
            this.paw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paw.Location = new System.Drawing.Point(206, 185);
            this.paw.Name = "paw";
            this.paw.Size = new System.Drawing.Size(86, 20);
            this.paw.TabIndex = 5;
            this.paw.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paw);
            this.Controls.Add(this.userN);
            this.Controls.Add(this.pWord);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.cancButton);
            this.Controls.Add(this.addButton);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancButton;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.TextBox pWord;
        private System.Windows.Forms.Label userN;
        private System.Windows.Forms.Label paw;
    }
}