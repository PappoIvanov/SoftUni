namespace Calculator
{
    partial class Form1
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
            T = new TextBox();
            UnderRoot = new Button();
            MathPI = new Button();
            FactorialButton = new Button();
            ACButton = new Button();
            DevideButton = new Button();
            CubeButton = new Button();
            SquareButton = new Button();
            InverseButton = new Button();
            MinusButton = new Button();
            SixButton = new Button();
            FiveButton = new Button();
            FourButton = new Button();
            MultiplyButton = new Button();
            NineButton = new Button();
            EightButton = new Button();
            SevenButton = new Button();
            EquallButton = new Button();
            ZeroButton = new Button();
            PlusMinusButton = new Button();
            PlusButton = new Button();
            ThreeButton = new Button();
            TwoButton = new Button();
            OneButton = new Button();
            button18 = new Button();
            DotButton = new Button();
            SuspendLayout();
            // 
            // T
            // 
            T.BorderStyle = BorderStyle.None;
            T.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            T.Location = new Point(12, 24);
            T.Multiline = true;
            T.Name = "T";
            T.Size = new Size(429, 75);
            T.TabIndex = 0;
            T.Text = "0";
            T.TextAlign = HorizontalAlignment.Right;
            T.TextChanged += textBox1_TextChanged;
            // 
            // UnderRoot
            // 
            UnderRoot.FlatStyle = FlatStyle.Flat;
            UnderRoot.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            UnderRoot.ForeColor = Color.Red;
            UnderRoot.Location = new Point(12, 129);
            UnderRoot.Name = "UnderRoot";
            UnderRoot.Size = new Size(93, 65);
            UnderRoot.TabIndex = 1;
            UnderRoot.Text = "√";
            UnderRoot.UseVisualStyleBackColor = true;
            // 
            // MathPI
            // 
            MathPI.FlatStyle = FlatStyle.Flat;
            MathPI.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MathPI.ForeColor = Color.Red;
            MathPI.Location = new Point(128, 129);
            MathPI.Name = "MathPI";
            MathPI.Size = new Size(88, 65);
            MathPI.TabIndex = 2;
            MathPI.Text = "π";
            MathPI.UseVisualStyleBackColor = true;
            // 
            // FactorialButton
            // 
            FactorialButton.FlatStyle = FlatStyle.Flat;
            FactorialButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FactorialButton.ForeColor = Color.Red;
            FactorialButton.Location = new Point(243, 129);
            FactorialButton.Name = "FactorialButton";
            FactorialButton.Size = new Size(88, 65);
            FactorialButton.TabIndex = 3;
            FactorialButton.Text = "n!";
            FactorialButton.UseVisualStyleBackColor = true;
            FactorialButton.Click += button3_Click;
            // 
            // ACButton
            // 
            ACButton.FlatStyle = FlatStyle.Flat;
            ACButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ACButton.Location = new Point(353, 129);
            ACButton.Name = "ACButton";
            ACButton.Size = new Size(88, 65);
            ACButton.TabIndex = 4;
            ACButton.Text = "AC";
            ACButton.UseVisualStyleBackColor = true;
            ACButton.Click += ACButton_Click;
            // 
            // DevideButton
            // 
            DevideButton.FlatStyle = FlatStyle.Flat;
            DevideButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            DevideButton.ForeColor = Color.Red;
            DevideButton.Location = new Point(353, 220);
            DevideButton.Name = "DevideButton";
            DevideButton.Size = new Size(88, 65);
            DevideButton.TabIndex = 8;
            DevideButton.Text = "÷";
            DevideButton.TextAlign = ContentAlignment.TopCenter;
            DevideButton.UseVisualStyleBackColor = true;
            DevideButton.Click += DevideButton_Click;
            // 
            // CubeButton
            // 
            CubeButton.FlatStyle = FlatStyle.Flat;
            CubeButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CubeButton.ForeColor = Color.Red;
            CubeButton.Location = new Point(243, 220);
            CubeButton.Name = "CubeButton";
            CubeButton.Size = new Size(88, 65);
            CubeButton.TabIndex = 7;
            CubeButton.Text = "x3";
            CubeButton.UseVisualStyleBackColor = true;
            // 
            // SquareButton
            // 
            SquareButton.FlatStyle = FlatStyle.Flat;
            SquareButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SquareButton.ForeColor = Color.Red;
            SquareButton.Location = new Point(128, 221);
            SquareButton.Name = "SquareButton";
            SquareButton.Size = new Size(88, 65);
            SquareButton.TabIndex = 6;
            SquareButton.Text = "x2";
            SquareButton.UseVisualStyleBackColor = true;
            // 
            // InverseButton
            // 
            InverseButton.FlatStyle = FlatStyle.Flat;
            InverseButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            InverseButton.ForeColor = Color.Red;
            InverseButton.Location = new Point(12, 220);
            InverseButton.Name = "InverseButton";
            InverseButton.Size = new Size(93, 65);
            InverseButton.TabIndex = 5;
            InverseButton.Text = "1/x";
            InverseButton.UseVisualStyleBackColor = true;
            // 
            // MinusButton
            // 
            MinusButton.FlatStyle = FlatStyle.Flat;
            MinusButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MinusButton.ForeColor = Color.Red;
            MinusButton.Location = new Point(353, 401);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(88, 65);
            MinusButton.TabIndex = 16;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // SixButton
            // 
            SixButton.BackColor = Color.White;
            SixButton.FlatStyle = FlatStyle.Flat;
            SixButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SixButton.ForeColor = Color.FromArgb(0, 192, 0);
            SixButton.Location = new Point(243, 401);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(88, 65);
            SixButton.TabIndex = 15;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = false;
            SixButton.Click += SixButton_Click;
            // 
            // FiveButton
            // 
            FiveButton.BackColor = Color.White;
            FiveButton.FlatStyle = FlatStyle.Flat;
            FiveButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FiveButton.ForeColor = Color.FromArgb(0, 192, 0);
            FiveButton.Location = new Point(128, 401);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(88, 65);
            FiveButton.TabIndex = 14;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = false;
            FiveButton.Click += FiveButton_Click;
            // 
            // FourButton
            // 
            FourButton.BackColor = Color.White;
            FourButton.FlatStyle = FlatStyle.Flat;
            FourButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FourButton.ForeColor = Color.FromArgb(0, 192, 0);
            FourButton.Location = new Point(12, 401);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(93, 65);
            FourButton.TabIndex = 13;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = false;
            FourButton.Click += FourButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.FlatStyle = FlatStyle.Flat;
            MultiplyButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MultiplyButton.ForeColor = Color.Red;
            MultiplyButton.Location = new Point(353, 310);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(88, 65);
            MultiplyButton.TabIndex = 12;
            MultiplyButton.Text = "x";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // NineButton
            // 
            NineButton.BackColor = Color.White;
            NineButton.FlatStyle = FlatStyle.Flat;
            NineButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NineButton.ForeColor = Color.FromArgb(0, 192, 0);
            NineButton.Location = new Point(243, 310);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(88, 65);
            NineButton.TabIndex = 11;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = false;
            NineButton.Click += NineButton_Click;
            // 
            // EightButton
            // 
            EightButton.BackColor = Color.White;
            EightButton.FlatStyle = FlatStyle.Flat;
            EightButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            EightButton.ForeColor = Color.FromArgb(0, 192, 0);
            EightButton.Location = new Point(128, 310);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(88, 65);
            EightButton.TabIndex = 10;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = false;
            EightButton.Click += EightButton_Click;
            // 
            // SevenButton
            // 
            SevenButton.BackColor = Color.White;
            SevenButton.FlatStyle = FlatStyle.Flat;
            SevenButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SevenButton.ForeColor = Color.FromArgb(0, 192, 0);
            SevenButton.Location = new Point(12, 310);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(93, 65);
            SevenButton.TabIndex = 9;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = false;
            SevenButton.Click += button16_Click;
            // 
            // EquallButton
            // 
            EquallButton.FlatStyle = FlatStyle.Flat;
            EquallButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            EquallButton.ForeColor = Color.FromArgb(0, 0, 192);
            EquallButton.Location = new Point(353, 583);
            EquallButton.Name = "EquallButton";
            EquallButton.Size = new Size(88, 67);
            EquallButton.TabIndex = 24;
            EquallButton.Text = "=";
            EquallButton.TextAlign = ContentAlignment.TopCenter;
            EquallButton.UseVisualStyleBackColor = true;
            EquallButton.Click += button17_Click;
            // 
            // ZeroButton
            // 
            ZeroButton.BackColor = Color.White;
            ZeroButton.FlatStyle = FlatStyle.Flat;
            ZeroButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ZeroButton.ForeColor = Color.FromArgb(0, 192, 0);
            ZeroButton.Location = new Point(128, 583);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(88, 65);
            ZeroButton.TabIndex = 22;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = false;
            ZeroButton.Click += button19_Click;
            // 
            // PlusMinusButton
            // 
            PlusMinusButton.FlatStyle = FlatStyle.Flat;
            PlusMinusButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PlusMinusButton.ForeColor = Color.Red;
            PlusMinusButton.Location = new Point(12, 583);
            PlusMinusButton.Name = "PlusMinusButton";
            PlusMinusButton.Size = new Size(93, 65);
            PlusMinusButton.TabIndex = 21;
            PlusMinusButton.Text = "+/-";
            PlusMinusButton.UseVisualStyleBackColor = true;
            // 
            // PlusButton
            // 
            PlusButton.FlatStyle = FlatStyle.Flat;
            PlusButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PlusButton.ForeColor = Color.Red;
            PlusButton.Location = new Point(353, 492);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(88, 65);
            PlusButton.TabIndex = 20;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // ThreeButton
            // 
            ThreeButton.BackColor = Color.White;
            ThreeButton.FlatStyle = FlatStyle.Flat;
            ThreeButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ThreeButton.ForeColor = Color.FromArgb(0, 192, 0);
            ThreeButton.Location = new Point(243, 492);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(88, 65);
            ThreeButton.TabIndex = 19;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = false;
            ThreeButton.Click += ThreeButton_Click;
            // 
            // TwoButton
            // 
            TwoButton.BackColor = Color.White;
            TwoButton.FlatStyle = FlatStyle.Flat;
            TwoButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TwoButton.ForeColor = Color.FromArgb(0, 192, 0);
            TwoButton.Location = new Point(128, 492);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(88, 65);
            TwoButton.TabIndex = 18;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = false;
            TwoButton.Click += TwoButton_Click;
            // 
            // OneButton
            // 
            OneButton.BackColor = Color.White;
            OneButton.FlatStyle = FlatStyle.Flat;
            OneButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            OneButton.ForeColor = Color.FromArgb(0, 192, 0);
            OneButton.Location = new Point(12, 492);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(93, 65);
            OneButton.TabIndex = 17;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = false;
            OneButton.Click += OneButton_Click;
            // 
            // button18
            // 
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(12, 665);
            button18.Name = "button18";
            button18.Size = new Size(429, 65);
            button18.TabIndex = 25;
            button18.Text = "Change Color of Calculator";
            button18.UseVisualStyleBackColor = true;
            // 
            // DotButton
            // 
            DotButton.FlatStyle = FlatStyle.Flat;
            DotButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            DotButton.ForeColor = Color.Red;
            DotButton.Location = new Point(243, 583);
            DotButton.Name = "DotButton";
            DotButton.Size = new Size(88, 67);
            DotButton.TabIndex = 26;
            DotButton.Text = ".";
            DotButton.TextAlign = ContentAlignment.TopCenter;
            DotButton.UseVisualStyleBackColor = true;
            DotButton.Click += button25_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 742);
            Controls.Add(DotButton);
            Controls.Add(button18);
            Controls.Add(EquallButton);
            Controls.Add(ZeroButton);
            Controls.Add(PlusMinusButton);
            Controls.Add(PlusButton);
            Controls.Add(ThreeButton);
            Controls.Add(TwoButton);
            Controls.Add(OneButton);
            Controls.Add(MinusButton);
            Controls.Add(SixButton);
            Controls.Add(FiveButton);
            Controls.Add(FourButton);
            Controls.Add(MultiplyButton);
            Controls.Add(NineButton);
            Controls.Add(EightButton);
            Controls.Add(SevenButton);
            Controls.Add(DevideButton);
            Controls.Add(CubeButton);
            Controls.Add(SquareButton);
            Controls.Add(InverseButton);
            Controls.Add(ACButton);
            Controls.Add(FactorialButton);
            Controls.Add(MathPI);
            Controls.Add(UnderRoot);
            Controls.Add(T);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox T;
        private Button UnderRoot;
        private Button MathPI;
        private Button FactorialButton;
        private Button ACButton;
        private Button DevideButton;
        private Button CubeButton;
        private Button SquareButton;
        private Button InverseButton;
        private Button MinusButton;
        private Button SixButton;
        private Button FiveButton;
        private Button FourButton;
        private Button MultiplyButton;
        private Button NineButton;
        private Button EightButton;
        private Button SevenButton;
        private Button EquallButton;
        private Button ZeroButton;
        private Button PlusMinusButton;
        private Button PlusButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button button18;
        private Button DotButton;
    }
}
