using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System.Xml.Linq;


namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        private Festa festa;
        private TelaFestaControl telaFesta;
        private TelaAluguelControl telaAluguelCon;
        public List<Cliente> clienteLista;
        public List<Tema> temaLista;

        public Aluguel Aluguel
        {
            set
            {
                //fazer
            }
            get
            {
                return this.aluguel;
            }
        }

        


        //contrutor
        public TelaAluguelForm()
        {
            InitializeComponent();
            this.lblTitulo.Text = "Dados da Festa";

            telaFesta = new TelaFestaControl();
            telaFesta.Dock = DockStyle.Fill;

            this.painelPrincipal.Controls.Add(telaFesta);
            this.brnGravar.Text = "Próximo";
            this.aluguel = new Aluguel();
        }


        private void brnGravar_Click(object sender, EventArgs e)
        {
            if (brnGravar.Text.Equals("Próximo"))
            {
                this.festa = telaFesta.Festa;
                ProximaTela();
                return;
            }
            this.aluguel = telaAluguelCon.Aluguel;
            this.aluguel.Festa = this.festa;

            //valida os dados coletados
            List<string> erros = aluguel.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            DialogResult = DialogResult.OK;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ProximaTela()
        {
            this.brnGravar.Text = "Gravar";
            this.lblTitulo.Text = "Dados do Aluguel";

            this.painelPrincipal.Controls.Clear();

            telaAluguelCon = new TelaAluguelControl();

            telaAluguelCon.Dock = DockStyle.Fill;
            telaAluguelCon.clientes = clienteLista;
            telaAluguelCon.temas = temaLista;

            telaAluguelCon.CarregarClientes();
            telaAluguelCon.CarregarTemas();
            
            this.painelPrincipal.Controls.Add(telaAluguelCon);
        }

        
    }
}
