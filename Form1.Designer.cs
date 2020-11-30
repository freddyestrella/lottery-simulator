namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Roll_Button = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.OutPutBox = new System.Windows.Forms.RichTextBox();
            this.MoneyInputBox = new System.Windows.Forms.TextBox();
            this.Money_label = new System.Windows.Forms.Label();
            this.RoundsInputBox = new System.Windows.Forms.TextBox();
            this.Rouds_Label = new System.Windows.Forms.Label();
            this.InputNumbersBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputProces = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Roll_Button
            // 
            this.Roll_Button.AccessibleName = "Roll_Button";
            this.Roll_Button.BackColor = System.Drawing.Color.Firebrick;
            this.Roll_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Roll_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll_Button.Location = new System.Drawing.Point(367, 179);
            this.Roll_Button.Name = "Roll_Button";
            this.Roll_Button.Size = new System.Drawing.Size(83, 31);
            this.Roll_Button.TabIndex = 0;
            this.Roll_Button.Text = "Roll";
            this.Roll_Button.UseMnemonic = false;
            this.Roll_Button.UseVisualStyleBackColor = false;
            this.Roll_Button.Click += new System.EventHandler(this.button1_Click);
            this.Roll_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // OutPutBox
            // 
            this.OutPutBox.AccessibleName = "OutPutBox";
            this.OutPutBox.Location = new System.Drawing.Point(482, 49);
            this.OutPutBox.Name = "OutPutBox";
            this.OutPutBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutPutBox.Size = new System.Drawing.Size(256, 317);
            this.OutPutBox.TabIndex = 4;
            this.OutPutBox.Text = "";
            this.OutPutBox.TextChanged += new System.EventHandler(this.OutPutBox_TextChanged);
            // 
            // MoneyInputBox
            // 
            this.MoneyInputBox.AccessibleName = "MoneyInputBox";
            this.MoneyInputBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MoneyInputBox.Location = new System.Drawing.Point(112, 56);
            this.MoneyInputBox.Name = "MoneyInputBox";
            this.MoneyInputBox.Size = new System.Drawing.Size(69, 20);
            this.MoneyInputBox.TabIndex = 6;
            this.MoneyInputBox.Text = "100";
            // 
            // Money_label
            // 
            this.Money_label.AccessibleName = "Money_label";
            this.Money_label.AutoSize = true;
            this.Money_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money_label.Location = new System.Drawing.Point(47, 49);
            this.Money_label.Name = "Money_label";
            this.Money_label.Size = new System.Drawing.Size(49, 32);
            this.Money_label.TabIndex = 5;
            this.Money_label.Text = "start \r\nmoney";
            this.Money_label.Click += new System.EventHandler(this.Money_label_Click);
            // 
            // RoundsInputBox
            // 
            this.RoundsInputBox.AccessibleName = "RoundsInputBox";
            this.RoundsInputBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.RoundsInputBox.Location = new System.Drawing.Point(112, 108);
            this.RoundsInputBox.Name = "RoundsInputBox";
            this.RoundsInputBox.Size = new System.Drawing.Size(69, 20);
            this.RoundsInputBox.TabIndex = 8;
            this.RoundsInputBox.Text = "50";
            // 
            // Rouds_Label
            // 
            this.Rouds_Label.AccessibleName = "Rouds_Label";
            this.Rouds_Label.AutoSize = true;
            this.Rouds_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rouds_Label.Location = new System.Drawing.Point(47, 108);
            this.Rouds_Label.Name = "Rouds_Label";
            this.Rouds_Label.Size = new System.Drawing.Size(49, 16);
            this.Rouds_Label.TabIndex = 7;
            this.Rouds_Label.Text = "rounds";
            this.Rouds_Label.Click += new System.EventHandler(this.Rouds_Label_Click);
            // 
            // InputNumbersBox
            // 
            this.InputNumbersBox.AccessibleName = "InputNumbersBox";
            this.InputNumbersBox.Location = new System.Drawing.Point(216, 49);
            this.InputNumbersBox.Name = "InputNumbersBox";
            this.InputNumbersBox.Size = new System.Drawing.Size(128, 317);
            this.InputNumbersBox.TabIndex = 9;
            this.InputNumbersBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "input numbers";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "output box";
            // 
            // InputProces
            // 
            this.InputProces.AccessibleName = "InputProces";
            this.InputProces.Location = new System.Drawing.Point(43, 179);
            this.InputProces.Name = "InputProces";
            this.InputProces.Size = new System.Drawing.Size(77, 187);
            this.InputProces.TabIndex = 12;
            this.InputProces.Text = "-5\n10\n15\n20\n30\n50\n100\n500\n1000\n10000\n500000";
            this.InputProces.TextChanged += new System.EventHandler(this.InputProces_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "matched prices";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "4";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(369, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "the range of the numbers is defined by the largest and smallest input numbers";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "10";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "9";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "8";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 259);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 79);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "9";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(194, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "8";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(194, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "7";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(194, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "6";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(194, 116);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "5";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(194, 103);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "4";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(194, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "3";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(194, 77);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(194, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 13);
            this.label25.TabIndex = 31;
            this.label25.Text = "1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(194, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 13);
            this.label26.TabIndex = 30;
            this.label26.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputProces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputNumbersBox);
            this.Controls.Add(this.RoundsInputBox);
            this.Controls.Add(this.Rouds_Label);
            this.Controls.Add(this.MoneyInputBox);
            this.Controls.Add(this.Money_label);
            this.Controls.Add(this.OutPutBox);
            this.Controls.Add(this.Roll_Button);
            this.Name = "Form1";
            this.Text = "Lottery Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Roll_Button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox OutPutBox;
        private System.Windows.Forms.TextBox MoneyInputBox;
        private System.Windows.Forms.Label Money_label;
        private System.Windows.Forms.TextBox RoundsInputBox;
        private System.Windows.Forms.Label Rouds_Label;
        private System.Windows.Forms.RichTextBox InputNumbersBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox InputProces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}

