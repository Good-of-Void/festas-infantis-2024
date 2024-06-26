using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        ContextoDados contexto;

        IRepositorioItem repositorioItem;
        IRepositorioTema repositorioTema;
        IRepositorioCliente repositorioCliente;
        IRepositorioAluguel repositorioAluguel;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            contexto = new ContextoDados(carregarDados: true);

            repositorioItem = new RepositorioItemEmArquivo(contexto);
            repositorioTema = new RepositorioTemaEmArquivo(contexto);
            repositorioCliente = new RepositorioClienteEmArquivo(contexto);
            repositorioAluguel = new RepositorioAluguelEmArquivo(contexto);
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }

        // Eventos

        //telas
        private void itemMenuItem_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorItem(repositorioItem);

            ConfigurarTelaPrincipal(controlador);
        }
        private void temaMenuItem_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorTema(repositorioTema, repositorioItem);

            ConfigurarTelaPrincipal(controlador);
        }
        private void clienteMenuItem_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorCliente(repositorioCliente);

            ConfigurarTelaPrincipal(controlador);
        }
        private void aluguelMenuItem_Click(object sender, EventArgs e)
        {
            this.controlador = new ControladorAluguel(repositorioAluguel,repositorioTema,repositorioCliente);

            ConfigurarTelaPrincipal(controlador);
        }
        //botoes
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        
    }
}
