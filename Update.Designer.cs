namespace sqlconn
{
    partial class Update
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
            this.components = new System.ComponentModel.Container();
            this.gBoxAva = new System.Windows.Forms.GroupBox();
            this.cBisAva = new System.Windows.Forms.CheckBox();
            this.gBoxPType = new System.Windows.Forms.GroupBox();
            this.rbsimple = new System.Windows.Forms.RadioButton();
            this.rbvariable = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cLBProductC = new System.Windows.Forms.CheckedListBox();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.dateee = new System.Windows.Forms.DateTimePicker();
            this.priceee = new System.Windows.Forms.TextBox();
            this.Counttt = new System.Windows.Forms.TextBox();
            this.obj_nameee = new System.Windows.Forms.TextBox();
            this.inv_numberrr = new System.Windows.Forms.TextBox();
            this.numberrr = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxAva.SuspendLayout();
            this.gBoxPType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxAva
            // 
            this.gBoxAva.Controls.Add(this.cBisAva);
            this.gBoxAva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAva.Location = new System.Drawing.Point(572, 305);
            this.gBoxAva.Name = "gBoxAva";
            this.gBoxAva.Size = new System.Drawing.Size(148, 97);
            this.gBoxAva.TabIndex = 38;
            this.gBoxAva.TabStop = false;
            this.gBoxAva.Text = "Availability";
            // 
            // cBisAva
            // 
            this.cBisAva.AutoSize = true;
            this.cBisAva.Location = new System.Drawing.Point(9, 33);
            this.cBisAva.Name = "cBisAva";
            this.cBisAva.Size = new System.Drawing.Size(108, 20);
            this.cBisAva.TabIndex = 18;
            this.cBisAva.Text = "Is Available";
            this.cBisAva.UseVisualStyleBackColor = true;
            // 
            // gBoxPType
            // 
            this.gBoxPType.Controls.Add(this.rbsimple);
            this.gBoxPType.Controls.Add(this.rbvariable);
            this.gBoxPType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxPType.Location = new System.Drawing.Point(571, 439);
            this.gBoxPType.Name = "gBoxPType";
            this.gBoxPType.Size = new System.Drawing.Size(144, 100);
            this.gBoxPType.TabIndex = 37;
            this.gBoxPType.TabStop = false;
            this.gBoxPType.Text = "Product Type";
            // 
            // rbsimple
            // 
            this.rbsimple.AutoSize = true;
            this.rbsimple.Location = new System.Drawing.Point(8, 56);
            this.rbsimple.Name = "rbsimple";
            this.rbsimple.Size = new System.Drawing.Size(71, 20);
            this.rbsimple.TabIndex = 1;
            this.rbsimple.TabStop = true;
            this.rbsimple.Text = "simple";
            this.rbsimple.UseVisualStyleBackColor = true;
            // 
            // rbvariable
            // 
            this.rbvariable.AutoSize = true;
            this.rbvariable.Location = new System.Drawing.Point(9, 32);
            this.rbvariable.Name = "rbvariable";
            this.rbvariable.Size = new System.Drawing.Size(84, 20);
            this.rbvariable.TabIndex = 0;
            this.rbvariable.TabStop = true;
            this.rbvariable.Text = "Variable";
            this.rbvariable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Product Catagory";
            // 
            // cLBProductC
            // 
            this.cLBProductC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLBProductC.FormattingEnabled = true;
            this.cLBProductC.Items.AddRange(new object[] {
            "FOOD",
            "ELECTRONICS",
            "TOYS"});
            this.cLBProductC.Location = new System.Drawing.Point(572, 218);
            this.cLBProductC.Name = "cLBProductC";
            this.cLBProductC.Size = new System.Drawing.Size(116, 64);
            this.cLBProductC.TabIndex = 35;
            // 
            // dgview
            // 
            this.dgview.AccessibleName = "";
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(29, 22);
            this.dgview.Name = "dgview";
            this.dgview.Size = new System.Drawing.Size(543, 150);
            this.dgview.TabIndex = 34;
            // 
            // dateee
            // 
            this.dateee.Location = new System.Drawing.Point(316, 232);
            this.dateee.Name = "dateee";
            this.dateee.Size = new System.Drawing.Size(200, 20);
            this.dateee.TabIndex = 33;
            // 
            // priceee
            // 
            this.priceee.Location = new System.Drawing.Point(315, 439);
            this.priceee.Name = "priceee";
            this.priceee.Size = new System.Drawing.Size(201, 20);
            this.priceee.TabIndex = 32;
            // 
            // Counttt
            // 
            this.Counttt.Location = new System.Drawing.Point(28, 439);
            this.Counttt.Name = "Counttt";
            this.Counttt.Size = new System.Drawing.Size(176, 20);
            this.Counttt.TabIndex = 31;
            // 
            // obj_nameee
            // 
            this.obj_nameee.Location = new System.Drawing.Point(28, 338);
            this.obj_nameee.Name = "obj_nameee";
            this.obj_nameee.Size = new System.Drawing.Size(176, 20);
            this.obj_nameee.TabIndex = 30;
            // 
            // inv_numberrr
            // 
            this.inv_numberrr.Location = new System.Drawing.Point(316, 338);
            this.inv_numberrr.Name = "inv_numberrr";
            this.inv_numberrr.Size = new System.Drawing.Size(200, 20);
            this.inv_numberrr.TabIndex = 29;
            // 
            // numberrr
            // 
            this.numberrr.Location = new System.Drawing.Point(28, 235);
            this.numberrr.Name = "numberrr";
            this.numberrr.Size = new System.Drawing.Size(176, 20);
            this.numberrr.TabIndex = 28;
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(312, 410);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(49, 20);
            this.P.TabIndex = 27;
            this.P.Text = "Price";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(25, 410);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(57, 20);
            this.C.TabIndex = 26;
            this.C.Text = "Count";
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.Location = new System.Drawing.Point(25, 305);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(112, 20);
            this.O.TabIndex = 25;
            this.O.Text = "Object Name";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(311, 305);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(150, 20);
            this.I.TabIndex = 24;
            this.I.Text = "Inventory Number";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(312, 199);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(40, 16);
            this.D.TabIndex = 23;
            this.D.Text = "Date";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(25, 199);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(71, 20);
            this.n.TabIndex = 22;
            this.n.Text = "Number";
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(315, 490);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(107, 34);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(129, 486);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 38);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(602, 77);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(87, 40);
            this.ShowButton.TabIndex = 39;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 551);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.gBoxAva);
            this.Controls.Add(this.gBoxPType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cLBProductC);
            this.Controls.Add(this.dgview);
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
            this.Controls.Add(this.updateButton);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.gBoxAva.ResumeLayout(false);
            this.gBoxAva.PerformLayout();
            this.gBoxPType.ResumeLayout(false);
            this.gBoxPType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxAva;
        private System.Windows.Forms.CheckBox cBisAva;
        private System.Windows.Forms.GroupBox gBoxPType;
        private System.Windows.Forms.RadioButton rbsimple;
        private System.Windows.Forms.RadioButton rbvariable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cLBProductC;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.DateTimePicker dateee;
        private System.Windows.Forms.TextBox priceee;
        private System.Windows.Forms.TextBox Counttt;
        private System.Windows.Forms.TextBox obj_nameee;
        private System.Windows.Forms.TextBox inv_numberrr;
        private System.Windows.Forms.TextBox numberrr;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label O;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}