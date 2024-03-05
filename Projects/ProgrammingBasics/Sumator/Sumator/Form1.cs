namespace Sumator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var num1 = decimal.Parse(this.textBox1.Text);
            var num2 = decimal.Parse(this.textBox2.Text);
            var sum = num1 + num2;
            textBoxSum.Text = sum.ToString();
        }
    }
}
