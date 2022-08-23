namespace Tutorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idnum = new System.Windows.Forms.TextBox();
            this.invnum = new System.Windows.Forms.TextBox();
            this.objName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cnt = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dpicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.availables = new System.Windows.Forms.CheckedListBox();
            this.Available = new System.Windows.Forms.RadioButton();
            this.NotAvailable = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.paymethod = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Gender.SuspendLayout();
            this.paymethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mnf. date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product discription:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory Number: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount: ";
            // 
            // idnum
            // 
            this.idnum.Location = new System.Drawing.Point(135, 30);
            this.idnum.Name = "idnum";
            this.idnum.Size = new System.Drawing.Size(265, 20);
            this.idnum.TabIndex = 5;
            // 
            // invnum
            // 
            this.invnum.Location = new System.Drawing.Point(163, 96);
            this.invnum.Name = "invnum";
            this.invnum.Size = new System.Drawing.Size(271, 20);
            this.invnum.TabIndex = 7;
            // 
            // objName
            // 
            this.objName.Location = new System.Drawing.Point(163, 165);
            this.objName.Multiline = true;
            this.objName.Name = "objName";
            this.objName.Size = new System.Drawing.Size(291, 81);
            this.objName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price: ";
            // 
            // cnt
            // 
            this.cnt.Location = new System.Drawing.Point(163, 129);
            this.cnt.Name = "cnt";
            this.cnt.Size = new System.Drawing.Size(219, 20);
            this.cnt.TabIndex = 10;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(191, 271);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(209, 20);
            this.PriceBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(60, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(408, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dpicker
            // 
            this.dpicker.Location = new System.Drawing.Point(135, 63);
            this.dpicker.Name = "dpicker";
            this.dpicker.Size = new System.Drawing.Size(247, 20);
            this.dpicker.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // availables
            // 
            this.availables.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.availables.FormattingEnabled = true;
            this.availables.Items.AddRange(new object[] {
            "Red ",
            "Black",
            "White",
            "Blue",
            "None"});
            this.availables.Location = new System.Drawing.Point(569, 68);
            this.availables.Name = "availables";
            this.availables.Size = new System.Drawing.Size(120, 79);
            this.availables.TabIndex = 16;
            // 
            // Available
            // 
            this.Available.AutoSize = true;
            this.Available.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available.Location = new System.Drawing.Point(16, 19);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(90, 24);
            this.Available.TabIndex = 17;
            this.Available.TabStop = true;
            this.Available.Text = "Available";
            this.Available.UseVisualStyleBackColor = true;
            // 
            // NotAvailable
            // 
            this.NotAvailable.AutoSize = true;
            this.NotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotAvailable.Location = new System.Drawing.Point(104, 19);
            this.NotAvailable.Name = "NotAvailable";
            this.NotAvailable.Size = new System.Drawing.Size(119, 24);
            this.NotAvailable.TabIndex = 18;
            this.NotAvailable.TabStop = true;
            this.NotAvailable.Text = "Not Available";
            this.NotAvailable.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.NotAvailable);
            this.Gender.Controls.Add(this.Available);
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(408, 267);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(228, 53);
            this.Gender.TabIndex = 19;
            this.Gender.TabStop = false;
            this.Gender.Text = "Availability";
            // 
            // paymethod
            // 
            this.paymethod.Controls.Add(this.radioButton1);
            this.paymethod.Controls.Add(this.radioButton2);
            this.paymethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymethod.Location = new System.Drawing.Point(515, 178);
            this.paymethod.Name = "paymethod";
            this.paymethod.Size = new System.Drawing.Size(231, 54);
            this.paymethod.TabIndex = 20;
            this.paymethod.TabStop = false;
            this.paymethod.Text = "Payement method:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(134, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 24);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Telebirr";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(16, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 24);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Paypal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "User: ";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(618, 13);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(100, 20);
            this.uname.TabIndex = 22;
            this.uname.Text = "label for user";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(565, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Color Choice: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(758, 416);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paymethod);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.availables);
            this.Controls.Add(this.dpicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.cnt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.objName);
            this.Controls.Add(this.invnum);
            this.Controls.Add(this.idnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.paymethod.ResumeLayout(false);
            this.paymethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idnum;
        private System.Windows.Forms.TextBox invnum;
        private System.Windows.Forms.TextBox objName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cnt;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dpicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox availables;
        private System.Windows.Forms.RadioButton NotAvailable;
        private System.Windows.Forms.RadioButton Available;
        private System.Windows.Forms.GroupBox paymethod;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

