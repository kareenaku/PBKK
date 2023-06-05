namespace kalkulatorrr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(textBox1.Text);
            int nilai2 = int.Parse(textBox2.Text);
            int hasil = nilai1 + nilai2;
            textBox3.Text = hasil.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(textBox1.Text);
            int nilai2 = int.Parse(textBox2.Text);
            int hasil = nilai1 - nilai2;
            textBox3.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(textBox1.Text);
            int nilai2 = int.Parse(textBox2.Text);
            int hasil = nilai1 / nilai2;
            textBox3.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(textBox1.Text);
            int nilai2 = int.Parse(textBox2.Text);
            int hasil = nilai1 * nilai2;
            textBox3.Text = hasil.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}