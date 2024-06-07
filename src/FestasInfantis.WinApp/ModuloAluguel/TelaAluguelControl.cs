
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
            aluguel.ValorEntrada = Convert.ToDecimal(this.txtValorEntrada.Text);
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
            Console.WriteLine();
        }
    }
}
