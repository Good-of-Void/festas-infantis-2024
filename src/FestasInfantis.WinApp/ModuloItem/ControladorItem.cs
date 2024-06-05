using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private IRepositorioItem repositorioItem;
        private TabelaItemControl TabelaItem;

        public ControladorItem(IRepositorioItem repositorio)
        {
            repositorioItem = repositorio;
        }

        public override string TipoCadastro { get { return "Item"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo item"; } }

        public override string ToolTipEditar { get { return "Editar um item existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um item existente"; } }

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItem();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O item \"{novoItem.Descricao}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            int idSelecionado = TabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if(itemSelecionado == null )
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um item selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaItem.Item = itemSelecionado;

            DialogResult resultado = telaItem.ShowDialog();

            if( resultado != DialogResult.OK ) 
                return;

            Item itemEditado = telaItem.Item;

            repositorioItem.Editar(itemSelecionado.Id, itemEditado);

            CarregarItem();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O item \"{itemEditado.Descricao}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = TabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um item selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
               $"Você deseja realmente excluir o item \"{itemSelecionado.Descricao}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (resposta != DialogResult.Yes)
                return;

            repositorioItem.Excluir(itemSelecionado.Id);

            CarregarItem();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O item \"{itemSelecionado.Descricao}\" foi excluido com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (TabelaItem == null)
                TabelaItem = new TabelaItemControl();

            CarregarItem();

            return TabelaItem;
        }

        private void CarregarItem()
        {
            List<Item> contatos = repositorioItem.SelecionarTodos();

            TabelaItem.AtualizarRegistros(contatos);
        }
    }
}
