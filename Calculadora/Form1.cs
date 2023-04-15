using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public string Operador { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox3.Text != string.Empty)
            {
                double result = default(int);
                switch (Operador)
                {
                    case "+":
                        result = double.Parse(textBox1.Text, CultureInfo.InvariantCulture) + double.Parse(textBox3.Text, CultureInfo.InvariantCulture);
                        break;
                    case "-":
                        result = double.Parse(textBox3.Text, CultureInfo.InvariantCulture) - double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                        break;
                    case "*":
                        result = double.Parse(textBox1.Text, CultureInfo.InvariantCulture) * double.Parse(textBox3.Text, CultureInfo.InvariantCulture);
                        break;
                    case "/":
                        result = double.Parse(textBox3.Text, CultureInfo.InvariantCulture) / double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                        break;
                }

                textBox1.Text = result.ToString(CultureInfo.InvariantCulture);
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void RetornaNumero(object sender)
        {
            if (textBox1.Text.Count() < 20)
                textBox1.Text += (sender.ToString()[sender.ToString().Count() - 1]).ToString();
        }
        private void RetornaOperador(object sender)
        {
            Operador = (sender.ToString()[sender.ToString().Count() - 1]).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RetornaOperador(sender);
            textBox2.Text = Operador.ToString();
            textBox3.Text = textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RetornaOperador(sender);
            textBox2.Text = Operador.ToString();
            textBox3.Text = textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RetornaOperador(sender);
            textBox2.Text = Operador.ToString();
            textBox3.Text = textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RetornaOperador(sender);
            textBox2.Text = Operador.ToString();
            textBox3.Text = textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text == "" ? "" : textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            RetornaNumero(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() != 0 && !textBox1.Text.Contains('.'))
                RetornaNumero(sender);
        }
    }
}