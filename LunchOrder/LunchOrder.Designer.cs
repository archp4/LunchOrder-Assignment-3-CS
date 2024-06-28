namespace LunchOrder
{
    partial class LunchOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            cbTips = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbOrderTotal = new TextBox();
            tbTax = new TextBox();
            tbSubTotal = new TextBox();
            buttonPlace = new Button();
            buttonExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(198, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Main Course";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 116);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(124, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Burrito - $5.95";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(120, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Salad - $ 4.95";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(113, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pizza - $5.95";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(155, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hamburger - $6.95";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(216, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 128);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 87);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(tbOrderTotal);
            groupBox3.Controls.Add(tbTax);
            groupBox3.Controls.Add(tbSubTotal);
            groupBox3.Location = new Point(12, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 128);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 151);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "Tips:";
            // 
            // cbTips
            // 
            cbTips.FormattingEnabled = true;
            cbTips.Location = new Point(268, 148);
            cbTips.Name = "cbTips";
            cbTips.Size = new Size(116, 28);
            cbTips.TabIndex = 6;
            cbTips.SelectedIndexChanged += cbTips_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 99);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Order Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 66);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Tax (7.75%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 3;
            label1.Text = "Subtotal:";
            // 
            // tbOrderTotal
            // 
            tbOrderTotal.Location = new Point(108, 92);
            tbOrderTotal.Name = "tbOrderTotal";
            tbOrderTotal.ReadOnly = true;
            tbOrderTotal.Size = new Size(125, 27);
            tbOrderTotal.TabIndex = 2;
            // 
            // tbTax
            // 
            tbTax.Location = new Point(108, 59);
            tbTax.Name = "tbTax";
            tbTax.ReadOnly = true;
            tbTax.Size = new Size(125, 27);
            tbTax.TabIndex = 1;
            // 
            // tbSubTotal
            // 
            tbSubTotal.Location = new Point(108, 26);
            tbSubTotal.Name = "tbSubTotal";
            tbSubTotal.ReadOnly = true;
            tbSubTotal.Size = new Size(125, 27);
            tbSubTotal.TabIndex = 0;
            // 
            // buttonPlace
            // 
            buttonPlace.Location = new Point(355, 188);
            buttonPlace.Name = "buttonPlace";
            buttonPlace.Size = new Size(106, 38);
            buttonPlace.TabIndex = 3;
            buttonPlace.Text = "Place";
            buttonPlace.UseVisualStyleBackColor = true;
            buttonPlace.Click += buttonPlace_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(355, 263);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(106, 38);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // LunchOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 315);
            Controls.Add(label4);
            Controls.Add(buttonExit);
            Controls.Add(cbTips);
            Controls.Add(buttonPlace);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LunchOrder";
            Text = "Lunch Order";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbOrderTotal;
        private TextBox tbTax;
        private TextBox tbSubTotal;
        private Button buttonPlace;
        private Button buttonExit;
        private Label label4;
        private ComboBox cbTips;
    }
}
