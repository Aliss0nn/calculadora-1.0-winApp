using System.Configuration;

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

            ConfigurarBotoes();
        }     

        private void AtribuirNumero(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            txtResultado.Text += botaoClicado.Text;
        }

        private void ConfigurarBotoes()
        {
            btn0.Click += AtribuirNumero;
            btn1.Click += AtribuirNumero;
            btn2.Click += AtribuirNumero;
            btn3.Click += AtribuirNumero;
            btn4.Click += AtribuirNumero;
            btn5.Click += AtribuirNumero;
            btn6.Click += AtribuirNumero;
            btn7.Click += AtribuirNumero;
            btn8.Click += AtribuirNumero;
            btn9.Click += AtribuirNumero;
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