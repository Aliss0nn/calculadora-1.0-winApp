namespace calculadora_1._0_winApp
{

    public partial class Calculadora : Form
    {
        decimal valor1;
        decimal valor2;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text);

            if (operacao == "Soma")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "Subtração")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "Multiplicação")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "Divisão")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text);
            this.operacao = "Soma";
            txtResultado.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor1 = valor1 = decimal.Parse(txtResultado.Text);
            this.operacao = "Subtração";
            txtResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = valor1 = decimal.Parse(txtResultado.Text);
            this.operacao = "Multiplicação";
            txtResultado.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = valor1 = decimal.Parse(txtResultado.Text);
            this.operacao = "Divisão";
            txtResultado.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}