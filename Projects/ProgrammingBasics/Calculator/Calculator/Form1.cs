namespace Calculator
{
    public partial class Form1 : Form
    {
        double a, b, c;
        string d;
        public Form1()
        {
            InitializeComponent();
        }
        public void process(string s)
        {
            d = s;
            a = Convert.ToDouble(T.Text);
            T.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(T.Text);
            switch(d)
            {
                case "/": c = a / b; break;
                case "*": c = a * b; break;
                case "+": c = a + b; break;
                case "-": c = a - b; break;
            }
            T.Text = c.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            KeyEnter(0);
        }

        private void KeyEnter(int i)
        {
            if (T.Text == "0")
                T.Text = i.ToString();
            else
                T.Text += i.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            KeyEnter(7);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            KeyEnter(1);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            KeyEnter(2);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            KeyEnter(3);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            KeyEnter(4);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            KeyEnter(5);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            KeyEnter(6);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            KeyEnter(8);

        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            KeyEnter(9);

        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            T.Clear();
            T.Text = "0";
        }

        private void DevideButton_Click(object sender, EventArgs e)
        {
            process("/");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            process("*");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            process("-");
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            process("+");
        }
    }
}
