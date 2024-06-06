using FestasInfantis.Dominio.ModuloAluguel;


namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        private Festa festa;
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

        private TelaFestaControl TelaFesta;
        public TelaAluguelForm()
        {
            InitializeComponent();
            this.lblTitulo.Text = "Dados da Festa";

            TelaFesta = new TelaFestaControl();
            TelaFesta.Dock = DockStyle.Fill;

            this.painelPrincipal.Controls.Add(TelaFesta);
            this.brnGravar.Text = "Próximo";
            this.aluguel = new Aluguel();
        }

        private void brnGravar_Click(object sender, EventArgs e)
        {
            if (brnGravar.Text.Equals("Próximo"))
            {
                this.festa = TelaFesta.Festa;

                this.brnGravar.Text = "Gravar";
                this.lblTitulo.Text = "Dados do Aluguel";

                TelaAluguelControl telaAluguelCon = new TelaAluguelControl();
                telaAluguelCon.Dock = DockStyle.Fill;

                this.painelPrincipal.Controls.Add(telaAluguelCon);
            }



        }
        private void ProximaTela()
        {

        }
    }
}
