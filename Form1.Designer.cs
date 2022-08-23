namespace sqlconn
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
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.numberrr = new System.Windows.Forms.TextBox();
            this.inv_numberrr = new System.Windows.Forms.TextBox();
            this.obj_nameee = new System.Windows.Forms.TextBox();
            this.Counttt = new System.Windows.Forms.TextBox();
            this.priceee = new System.Windows.Forms.TextBox();
            this.dateee = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(289, 390);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 34);
            this.Add.TabIndex = 0;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(422, 390);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(107, 34);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(47, 51);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(71, 20);
            this.n.TabIndex = 2;
            this.n.Text = "Number";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(334, 51);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(40, 16);
            this.D.TabIndex = 3;
            this.D.Text = "Date";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(609, 51);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(150, 20);
            this.I.TabIndex = 4;
            this.I.Text = "Inventory Number";
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.Location = new System.Drawing.Point(47, 157);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(112, 20);
            this.O.TabIndex = 5;
            this.O.Text = "Object Name";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(47, 262);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(57, 20);
            this.C.TabIndex = 6;
            this.C.Text = "Count";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(334, 262);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(49, 20);
            this.P.TabIndex = 7;
            this.P.Text = "Price";
            // 
            // numberrr
            // 
            this.numberrr.Location = new System.Drawing.Point(50, 87);
            this.numberrr.Name = "numberrr";
            this.numberrr.Size = new System.Drawing.Size(176, 20);
            this.numberrr.TabIndex = 8;
            // 
            // inv_numberrr
            // 
            this.inv_numberrr.Location = new System.Drawing.Point(612, 84);
            this.inv_numberrr.Name = "inv_numberrr";
            this.inv_numberrr.Size = new System.Drawing.Size(176, 20);
            this.inv_numberrr.TabIndex = 9;
            // 
            // obj_nameee
            // 
            this.obj_nameee.Location = new System.Drawing.Point(50, 190);
            this.obj_nameee.Name = "obj_nameee";
            this.obj_nameee.Size = new System.Drawing.Size(176, 20);
            this.obj_nameee.TabIndex = 10;
            // 
            // Counttt
            // 
            this.Counttt.Location = new System.Drawing.Point(50, 291);
            this.Counttt.Name = "Counttt";
            this.Counttt.Size = new System.Drawing.Size(176, 20);
            this.Counttt.TabIndex = 11;
            // 
            // priceee
            // 
            this.priceee.Location = new System.Drawing.Point(337, 291);
            this.priceee.Name = "priceee";
            this.priceee.Size = new System.Drawing.Size(176, 20);
            this.priceee.TabIndex = 12;
            // 
            // dateee
            // 
            this.dateee.Location = new System.Drawing.Point(338, 84);
            this.dateee.Name = "dateee";
            this.dateee.Size = new System.Drawing.Size(200, 20);
            this.dateee.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateee);
            this.Controls.Add(this.priceee);
            this.Controls.Add(this.Counttt);
            this.Controls.Add(this.obj_nameee);
            this.Controls.Add(this.inv_numberrr);
            this.Controls.Add(this.numberrr);
            this.Controls.Add(this.P);
            this.Controls.Add(this.C);
            this.Controls.Add(this.O);
            this.Controls.Add(this.I);
            this.Controls.Add(this.D);
            this.Controls.Add(this.n);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Label O;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.TextBox numberrr;
        private System.Windows.Forms.TextBox inv_numberrr;
        private System.Windows.Forms.TextBox obj_nameee;
        private System.Windows.Forms.TextBox Counttt;
        private System.Windows.Forms.TextBox priceee;
        private System.Windows.Forms.DateTimePicker dateee;
    }
}

