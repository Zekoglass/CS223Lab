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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgview = new System.Windows.Forms.DataGridView();
            this.cLBProductC = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxPType = new System.Windows.Forms.GroupBox();
            this.rbsimple = new System.Windows.Forms.RadioButton();
            this.rbvariable = new System.Windows.Forms.RadioButton();
            this.cBisAva = new System.Windows.Forms.CheckBox();
            this.gBoxAva = new System.Windows.Forms.GroupBox();
            this.current_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.gBoxPType.SuspendLayout();
            this.gBoxAva.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(151, 347);
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
            this.Cancel.Location = new System.Drawing.Point(337, 342);
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
            this.n.Click += new System.EventHandler(this.n_Click);
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
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(333, 157);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(150, 20);
            this.I.TabIndex = 4;
            this.I.Text = "Inventory Number";
            this.I.Click += new System.EventHandler(this.I_Click);
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
            this.O.Click += new System.EventHandler(this.O_Click);
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
            this.C.Click += new System.EventHandler(this.C_Click);
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
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // numberrr
            // 
            this.numberrr.Location = new System.Drawing.Point(50, 87);
            this.numberrr.Name = "numberrr";
            this.numberrr.Size = new System.Drawing.Size(176, 20);
            this.numberrr.TabIndex = 8;
            this.numberrr.TextChanged += new System.EventHandler(this.numberrr_TextChanged);
            // 
            // inv_numberrr
            // 
            this.inv_numberrr.Location = new System.Drawing.Point(338, 190);
            this.inv_numberrr.Name = "inv_numberrr";
            this.inv_numberrr.Size = new System.Drawing.Size(200, 20);
            this.inv_numberrr.TabIndex = 9;
            this.inv_numberrr.TextChanged += new System.EventHandler(this.inv_numberrr_TextChanged);
            // 
            // obj_nameee
            // 
            this.obj_nameee.Location = new System.Drawing.Point(50, 190);
            this.obj_nameee.Name = "obj_nameee";
            this.obj_nameee.Size = new System.Drawing.Size(176, 20);
            this.obj_nameee.TabIndex = 10;
            this.obj_nameee.TextChanged += new System.EventHandler(this.obj_nameee_TextChanged);
            // 
            // Counttt
            // 
            this.Counttt.Location = new System.Drawing.Point(50, 291);
            this.Counttt.Name = "Counttt";
            this.Counttt.Size = new System.Drawing.Size(176, 20);
            this.Counttt.TabIndex = 11;
            this.Counttt.TextChanged += new System.EventHandler(this.Counttt_TextChanged);
            // 
            // priceee
            // 
            this.priceee.Location = new System.Drawing.Point(337, 291);
            this.priceee.Name = "priceee";
            this.priceee.Size = new System.Drawing.Size(201, 20);
            this.priceee.TabIndex = 12;
            this.priceee.TextChanged += new System.EventHandler(this.priceee_TextChanged);
            // 
            // dateee
            // 
            this.dateee.Location = new System.Drawing.Point(338, 84);
            this.dateee.Name = "dateee";
            this.dateee.Size = new System.Drawing.Size(200, 20);
            this.dateee.TabIndex = 13;
            this.dateee.ValueChanged += new System.EventHandler(this.dateee_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgview
            // 
            this.dgview.AccessibleName = "";
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(50, 387);
            this.dgview.Name = "dgview";
            this.dgview.Size = new System.Drawing.Size(488, 163);
            this.dgview.TabIndex = 14;
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick);
            // 
            // cLBProductC
            // 
            this.cLBProductC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLBProductC.FormattingEnabled = true;
            this.cLBProductC.Items.AddRange(new object[] {
            "FOOD",
            "ELECTRONICS",
            "TOYS"});
            this.cLBProductC.Location = new System.Drawing.Point(594, 70);
            this.cLBProductC.Name = "cLBProductC";
            this.cLBProductC.Size = new System.Drawing.Size(116, 64);
            this.cLBProductC.TabIndex = 15;
            this.cLBProductC.SelectedIndexChanged += new System.EventHandler(this.cLBProductC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Catagory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gBoxPType
            // 
            this.gBoxPType.Controls.Add(this.rbsimple);
            this.gBoxPType.Controls.Add(this.rbvariable);
            this.gBoxPType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxPType.Location = new System.Drawing.Point(593, 291);
            this.gBoxPType.Name = "gBoxPType";
            this.gBoxPType.Size = new System.Drawing.Size(144, 100);
            this.gBoxPType.TabIndex = 17;
            this.gBoxPType.TabStop = false;
            this.gBoxPType.Text = "Product Type";
            this.gBoxPType.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // gBoxAva
            // 
            this.gBoxAva.Controls.Add(this.cBisAva);
            this.gBoxAva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAva.Location = new System.Drawing.Point(594, 157);
            this.gBoxAva.Name = "gBoxAva";
            this.gBoxAva.Size = new System.Drawing.Size(148, 97);
            this.gBoxAva.TabIndex = 19;
            this.gBoxAva.TabStop = false;
            this.gBoxAva.Text = "Availability";
            this.gBoxAva.Enter += new System.EventHandler(this.gBoxAva_Enter);
            // 
            // current_user
            // 
            this.current_user.AutoSize = true;
            this.current_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_user.Location = new System.Drawing.Point(12, 9);
            this.current_user.Name = "current_user";
            this.current_user.Size = new System.Drawing.Size(92, 16);
            this.current_user.TabIndex = 20;
            this.current_user.Text = "current_user";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 557);
            this.Controls.Add(this.current_user);
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
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.gBoxPType.ResumeLayout(false);
            this.gBoxPType.PerformLayout();
            this.gBoxAva.ResumeLayout(false);
            this.gBoxAva.PerformLayout();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.GroupBox gBoxPType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cLBProductC;
        private System.Windows.Forms.GroupBox gBoxAva;
        private System.Windows.Forms.CheckBox cBisAva;
        private System.Windows.Forms.RadioButton rbsimple;
        private System.Windows.Forms.RadioButton rbvariable;
        private System.Windows.Forms.Label current_user;
    }
}

