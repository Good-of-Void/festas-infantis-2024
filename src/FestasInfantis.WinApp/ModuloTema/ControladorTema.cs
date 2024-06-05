using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    internal class ControladorTema : ControladorBase
    {
        private IRepositorioItem RepositorioItem;
        private IRepositorioTema RepositorioTema;
        private TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioTema repositorioTema,IRepositorioItem repositorioItem)
        {
            RepositorioItem = repositorioItem;
            RepositorioTema = repositorioTema;
        }

        public override string TipoCadastro { get { return "Tema"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema existente"; } }

        public override void Adicionar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();
            telaTema.repositorioItem = RepositorioItem;

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;
            Tema novoTema = telaTema.Tema;

            RepositorioTema.Cadastrar(novoTema);

            CarregarTema();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O tema \"{novoTema.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();
            telaTema.repositorioItem = RepositorioItem;

            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado = RepositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um item selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTema.Tema = temaSelecionado;

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema temaEditado = telaTema.Tema;

            RepositorioTema.Editar(temaSelecionado.Id, temaEditado);

            CarregarTema();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O tema \"{temaEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTema.ObterRegistroSelecionado();

            Tema temaSelecionado = RepositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um tema selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
               $"Você deseja realmente excluir o tema \"{temaSelecionado.Nome}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (resposta != DialogResult.Yes)
                return;

            RepositorioTema.Excluir(temaSelecionado.Id);

            CarregarTema();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O tema \"{temaSelecionado.Nome}\" foi excluido com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTema();

            return tabelaTema;
        }
        private void CarregarTema()
        {
            List<Tema> temas = RepositorioTema.SelecionarTodos();

            tabelaTema.AtualizarRegistros(temas);
        }
    }
}
