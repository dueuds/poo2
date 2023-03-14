using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCadProduto
{
    public class Menu
    {
        EntradaDados entrada;
        Produto p;
        CadastroProduto cad;
        public Menu()
        {
            entrada = new EntradaDados();
            cad = new CadastroProduto();
        }
        private void Opcoes()
        {
            Console.WriteLine("1 - Inserir Dados");
            Console.WriteLine("2 - Apresentar Dados");
            Console.WriteLine("3 - Média de valores");
            Console.WriteLine("0 - sair");
        }

        public void MenuOpcoes()
        {
            int opc = 0;

            Opcoes();
            opc = entrada.LeInteiro("Informe a sua opção:\n");

            while (opc != 0)
            {
                switch (opc)
                {
                    case 0:
                        break;
                    case 1:
                        LeProduto();
                        break;
                    case 2:
                        EscreveDados();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Opcoes();
                opc = entrada.LeInteiro("Informe a sua opção");
            }
        }

        private void LeProduto()
        {
            p = new Produto
            {
                Codigo = entrada.LeInteiro("Informe o Codigo"),
                Descricao = entrada.LeString("Informe a descrição"),
                Valor = entrada.LeDouble("Informe o valor")
            };
            cad.InsereDados(p);
        }

        private void EscreveDados()
        {
            for (int i = 0; i < cad.Tamanho(); i++)
            {
                p = cad.GetProduto(i);
                Console.WriteLine(p.ToString());
            }
        }

        private void MediaProdutos()
        { 
            int tam = cad.Tamanho();
            double total = 0;

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine();
                total = cad.GetProduto(i).Valor;
            }
        }
    }
}
