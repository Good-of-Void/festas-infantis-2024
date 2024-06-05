using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;


namespace FestasInfantis.WinApp.ModuloCliente
{
    internal class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl TabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }

        public override string TipoCadastro { get { return "Cliente"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar um Cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Cliente existente"; } }

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente novoCliente = telaCliente.Cliente;

            repositorioCliente.Cadastrar(novoCliente);

            CarregarCliente();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O cliente \"{novoCliente.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            int idSelecionado = TabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um cliente selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCliente.Cliente = clienteSelecionado;

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente clienteEditado = telaCliente.Cliente;

            repositorioCliente.Editar(clienteSelecionado.Id, clienteEditado);

            CarregarCliente();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O cliente \"{clienteEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = TabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um cliente selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
               $"Você deseja realmente excluir o cliente \"{clienteSelecionado.Nome}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (resposta != DialogResult.Yes)
                return;

            repositorioCliente.Excluir(clienteSelecionado.Id);

            CarregarCliente();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O cliente \"{clienteSelecionado.Nome}\" foi excluido com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (TabelaCliente == null)
                TabelaCliente = new TabelaClienteControl();

            CarregarCliente();

            return TabelaCliente;
        }

        private void CarregarCliente()
        {
            List<Cliente> contatos = repositorioCliente.SelecionarTodos();

            TabelaCliente.AtualizarRegistros(contatos);
        }
    }
}

