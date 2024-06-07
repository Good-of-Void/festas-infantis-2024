
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelControl : UserControl
    {
        public List<Tema> temas;
        public List<Cliente> clientes;

        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {

            }
            get
            {
                PegarDados();
                return aluguel;
            }
        }

        private void PegarDados()
        {
            aluguel = new Aluguel();
            aluguel.Cliente = (Cliente)this.cboxCliente.SelectedItem;
            aluguel.Tema = (Tema)this.cboxTema.SelectedItem;
            aluguel.ValorEntrada = Convert.ToDecimal(this.txtValorEntrada.Text);
            aluguel.ValorTotal = Convert.ToDecimal(this.txtValorEntrada.Text);
        }

        
        //contrutor
        public TelaAluguelControl()
        {
            InitializeComponent();

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CarregarClientes()
        {
            this.cboxCliente.Items.Clear();
            foreach (Cliente c in clientes)
            {
                this.cboxCliente.Items.Add(c);
            }
        }

        public void CarregarTemas()
        {
            this.cboxTema.Items.Clear();
            foreach (Tema t in temas)
            {
                this.cboxTema.Items.Add(t);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            Cliente cliente = (Cliente)this.cboxCliente.SelectedItem;
            Tema tema = (Tema)this.cboxTema.SelectedItem;
            decimal entrada = Convert.ToDecimal(this.cboxEntrada.SelectedItem);
            entrada = entrada / 100;
            decimal total;

            //txtValorTema
            this.txtValorTema.Text = tema.Valor.ToString();
            total = tema.Valor;
        
            //txtDesconto
            decimal descontoCliente = cliente.QuantidadeAlugueis;
            if (descontoCliente >= 5)
            {
                descontoCliente = (5 * 5) / 100;
                this.txtDesconto.Text = Convert.ToString(descontoCliente * 100);
            }
            else
            {
                descontoCliente = (descontoCliente * 5) / 100;
                this.txtDesconto.Text = Convert.ToString(descontoCliente * 100);
            }
            total = total - (total * descontoCliente);

            //txtTemaDesconto 
            this.txtTemaDesconto.Text = total.ToString();

            //txtValorEntrada
            entrada = total * entrada;
            this.txtValorEntrada.Text = entrada.ToString();

            //txtValorTotal
            this.txtValorTotal.Text = total.ToString();

            //txtPedente
            total -= entrada;
            this.txtPedente.Text = total.ToString();
        }
    }
}
