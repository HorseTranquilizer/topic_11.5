namespace topic_11._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Ans1;
            Ans1 = Convert.ToDouble(textBox1.Text);
            double ans2;
            ans2 = Convert.ToDouble(textBox2.Text);
            double total;
            total = Ans1 + ans2;
            label2.Text = total.ToString();
            label1.Text = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Ans1;
            Ans1 = Convert.ToDouble(textBox1.Text);
            double ans2;
            ans2 = Convert.ToDouble(textBox2.Text);
            double total;
            total = ans2 - Ans1;
            label2.Text = total.ToString();
            label1.Text = "-";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Ans1;
            Ans1 = Convert.ToDouble(textBox1.Text);
            double ans2;
            ans2 = Convert.ToDouble(textBox2.Text);
            double total;
            total = Ans1 * ans2;
            label2.Text = total.ToString();
            label1.Text = "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Ans1;
            Ans1 = Convert.ToDouble(textBox1.Text);
            double ans2;
            ans2 = Convert.ToDouble(textBox2.Text);
            double total;
            total = ans2 / Ans1;
            label2.Text = total.ToString();
            label1.Text = "÷";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double Ans1;
            Ans1 = Convert.ToDouble(textBox1.Text);
            double ans2;
            ans2 = Convert.ToDouble(textBox2.Text);
            double total;
            total = Ans1 + ans2;
            double total2;
            total2 = total / 2;
            label2.Text = total2.ToString();
            label1.Text = "Average";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double Ans1;
            Ans1 = Convert.ToDouble(textBox1.Text);
            double ans2;
            ans2 = Convert.ToDouble(textBox2.Text);
            double total;
            total = Math.Pow(Ans1, ans2);
            label2.Text = total.ToString();
            label1.Text = "^";
        }
    }
}
