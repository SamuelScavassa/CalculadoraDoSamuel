namespace CalculadoraDoSamuel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double tela { get; set; }
        public double one { get; set; }
        public char opcao { get; set; }

        public Calculadora calc = new Calculadora();

        private void um_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '1';
            tela = Convert.ToDouble(visor.Text);
        }

        private void dois_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '2';
            tela = Convert.ToDouble(visor.Text);
        }

        private void tres_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '3';
            tela = Convert.ToDouble(visor.Text);
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '4';
            tela = Convert.ToDouble(visor.Text);
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '5';
            tela = Convert.ToDouble(visor.Text);
        }

        private void seis_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '6';
            tela = Convert.ToDouble(visor.Text);
        }

        private void sete_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '7';
            tela = Convert.ToDouble(visor.Text);
        }

        private void oito_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '8';
            tela = Convert.ToDouble(visor.Text);
        }

        private void nove_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '9';
            tela = Convert.ToDouble(visor.Text);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + '0';
            tela = Convert.ToDouble(visor.Text);
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if(opcao == '+')
            {
                calc.NumUm = one;
                calc.NumDois = tela;
                visor.Text = calc.Soma();
                tela = Convert.ToDouble(visor.Text);

            }
            else
            {
                if(opcao == '-')
                {
                    calc.NumUm = one;
                    calc.NumDois = tela;
                    visor.Text = calc.Sub();
                    tela = Convert.ToDouble(visor.Text);
                }
                else
                {
                    if(opcao == '*')
                    {
                        calc.NumUm = one;
                        calc.NumDois = tela;
                        visor.Text = calc.Mult();
                        tela = Convert.ToDouble(visor.Text);
                    }
                    else
                    {
                        if(opcao== '/')
                        {
                            calc.NumUm = one;
                            calc.NumDois = tela;
                            visor.Text = calc.Div();
                            tela = Convert.ToDouble(visor.Text);
                        }
                        else
                        {
                            visor.Text = null;
                        }
                    }
                }
            }
        }

        private void mais_Click(object sender, EventArgs e)
        {
            one = tela;
            opcao = '+';
            visor.Text = null;

        }

        private void menos_Click(object sender, EventArgs e)
        {
            one = tela;
            opcao = '-';
            visor.Text = null;
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            one = tela;
            opcao = '*';
            visor.Text = null;
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            one = tela;
            opcao = '/';
            visor.Text = null;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            one = 0;
            visor.Text = null;
            tela = 0;
            opcao = ' ';
            calc.NumUm = 0;
            calc.NumDois = 0;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}