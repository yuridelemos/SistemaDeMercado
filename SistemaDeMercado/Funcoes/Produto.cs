using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class Produto
    {
        public string Nome;
        public string Setor;
        public double EAN;
        public double Preco;

        public Produto(string nome, string setor, double ean, double preco)
        {
            this.Nome = nome;
            this.Setor = setor;
            this.EAN = ean;
            this.Preco = preco;
        }
        public Produto() { }

        public void Gravar()
        {
            var produtos = Produto.LerProdutos();
            produtos.Add(this);
            if (File.Exists(caminhoBase()))
            {
                StreamWriter sw = new StreamWriter(caminhoBase());
                sw.WriteLine("nome;setor;ean;preco");
                foreach (Produto p in produtos)
                {
                    var linha = p.Nome + ";" + p.Setor + ";" + p.EAN + ";" + p.Preco + ";";
                    sw.WriteLine(linha);
                }
                sw.Close();
            }
        }

        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeProdutos"];
        }

        public static List<Produto> LerProdutos()
        {
            var produtos = new List<Produto>();
            if (File.Exists(caminhoBase()))
            {
                using(StreamReader arquivo = File.OpenText(caminhoBase()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var produtoArquivos = linha.Split(';');
                        var produto = new Produto
                        {
                            Nome = produtoArquivos[0],
                            Setor = produtoArquivos[1],
                            EAN = double.Parse(produtoArquivos[2]),
                            Preco = double.Parse(produtoArquivos[3])
                        };
                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }
    }
}
