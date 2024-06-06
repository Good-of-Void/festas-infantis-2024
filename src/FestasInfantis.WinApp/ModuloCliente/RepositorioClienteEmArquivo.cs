using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    internal class RepositorioClienteEmArquivo : RepositorioBaseEmArquivo <Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }
        protected override List<Cliente> ObterRegistros()
        {
            return contexto.Clientes;
        }
    }
}
