namespace Sumator
{
    partial class FormCalculate
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
            Calculate = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBoxSum = new TextBox();
            plus = new Label();
            equal = new Label();
            SuspendLayout();
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Calculate.Location = new Point(12, 118);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(452, 60);
            Calculate.TabIndex = 0;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 35);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 53);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 55);
            textBox1.TabIndex = 2;
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(346, 37);
            textBoxSum.Multiline = true;
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(118, 53);
            textBoxSum.TabIndex = 3;
            // 
            // plus
            // 
            plus.AutoSize = true;
            plus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            plus.Location = new Point(147, 46);
            plus.Name = "plus";
            plus.Size = new Size(30, 32);
            plus.TabIndex = 4;
            plus.Text = "+";
            plus.Click += label1_Click;
            // 
            // equal
            // 
            equal.AutoSize = true;
            equal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            equal.Location = new Point(310, 46);
            equal.Name = "equal";
            equal.Size = new Size(30, 32);
            equal.TabIndex = 5;
            equal.Text = "=";
            equal.Click += equal_Click;
            // 
            // FormCalculate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 215);
            Controls.Add(equal);
            Controls.Add(plus);
            Controls.Add(textBoxSum);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(Calculate);
            Name = "FormCalculate";
            Text = "Sumator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculate;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBoxSum;
        private Label plus;
        private Label equal;
    }
}
