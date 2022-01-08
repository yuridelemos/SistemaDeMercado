using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    class Produto
    {
        public const int CADASTRAR_PRODUTO = 1;
        public const int LISTAR_PRODUTOS   = 2;
        public const int DELETAR_PRODUTOS  = 3;
        public const int RETORNAR          = 0;
        public static void Menu()
        {
            string mensagemObjeto = "=============== Menu de Objetos ===============\n" +
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
                    produto.
                    break;
                case LISTAR_PRODUTOS:
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
