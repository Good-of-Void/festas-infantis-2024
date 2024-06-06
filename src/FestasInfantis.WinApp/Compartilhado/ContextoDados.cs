using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.Compartilhado
{
    public class ContextoDados
    {
        public List<Aluguel> Alugueis { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Item> Itens { get; set; }
        public List<Tema> Temas { get; set; }

        private string caminho = $"C:\\temp\\FestasInfantis\\dados.json";

        public ContextoDados()
        {
            Alugueis = new List<Aluguel>();
            Clientes = new List<Cliente>();
            Itens = new List<Item>();
            Temas = new List<Tema>();
        }
        public ContextoDados(bool carregarDados) : this()
        {         
            if (carregarDados)
                CarregarDados();           
        }
        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

            if (ctx == null) return;

            Alugueis = ctx.Alugueis;
            Clientes = ctx.Clientes;
            Itens = ctx.Itens;
            Temas = ctx.Temas;
        }
    }
}
