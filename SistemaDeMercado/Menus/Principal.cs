using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    class Principal
    {
        public const int MENU_PRODUTO       = 1;
        public const int MENU_CLIENTE       = 2;
        public const int MENU_VENDEDOR      = 3;
        public const int REALIZAR_VENDA     = 4;
        public const int FINALIZAR_PROGRAMA = 0;
        public static void Menu()
        {
            while (true)
            {
                string mensagem =
                    "============== Menu Principal ==============\n" +
                    "(1) - Menu de Produtos\n" +
                    "(2) - Menu de Clientes\n" +
                    "(3) - Menu do Vendedor\n" +
                    "(4) - Realizar Venda\n" +
                    "(0) - Finalizar programa\n";

                Console.Write(mensagem + "========================: ");
                int OpcaoMenu = int.Parse(Console.ReadLine());
                switch (OpcaoMenu)
                {
                    case MENU_PRODUTO:
                        Produto.Menu();
                        break;
                    case MENU_CLIENTE:
                        break;
                    case MENU_VENDEDOR:
                        break;
                    case REALIZAR_VENDA:
                        break;
                    case FINALIZAR_PROGRAMA:
                        return;
                    default:
                        Console.WriteLine("Opção escolhida é inválida, por favor tente novamente.");
                        break;
                }
            }
        }
    }
}
