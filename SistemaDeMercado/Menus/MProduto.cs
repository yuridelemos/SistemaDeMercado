using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    class MProduto
    {
        public const int CADASTRAR_PRODUTO = 1;
        public const int LISTAR_PRODUTOS   = 2;
        public const int DELETAR_PRODUTOS  = 3;
        public const int RETORNAR          = 0;
        public static void Menu()
        {
            Console.WriteLine("=============== Menu de Objetos ===============");

            while(true)
            {
                string mensagemObjeto =
                "(1) - Cadastrar produto\n" +
                "(2) - Listar produtos\n" +
                "(3) - Deletar produtos\n" +
                "(0) - Retornar para o menu principal\n";

                Console.Write(mensagemObjeto + "========================: "); ;
                int escolhaObjeto = int.Parse(Console.ReadLine());

                switch (escolhaObjeto)
                {
                    case CADASTRAR_PRODUTO:
                        Produto produto = new Produto();

                        Console.WriteLine("Digite o nome do produto: ");
                        produto.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o setor do produto: ");
                        produto.Setor = Console.ReadLine();

                        Console.WriteLine("Digite o código de barras do produto: ");
                        produto.EAN = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o preco do produto: ");
                        produto.Preco = double.Parse(Console.ReadLine());

                        produto.Gravar();
                        break;

                    case LISTAR_PRODUTOS:
                        var produtos = Produto.LerProdutos();
                        foreach(Produto p in produtos)
                        {
                            Console.WriteLine(p.Nome);
                            Console.WriteLine(p.Setor);
                            Console.WriteLine(p.EAN);
                            Console.WriteLine("R$ " + p.Preco);
                            Console.WriteLine("======================");
                        }
                        break;

                    case DELETAR_PRODUTOS:
                        break;

                    case RETORNAR:
                        return;

                    default:
                        Console.WriteLine("Opção digitada é inválida, tente novamente.");
                        break;
                }
            }
        }
    }
}
