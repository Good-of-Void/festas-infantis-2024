﻿using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    internal class RepositorioTemaEmArquivo : RepositorioBaseEmArquivo<Item> , IRepositorioItem
    {
        public RepositorioTemaEmArquivo() : base("Itens.json")
        {

        }
    }
}
