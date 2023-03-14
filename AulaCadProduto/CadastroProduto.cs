using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCadProduto
{
    public class CadastroProduto
    {
        private Produto[] cadastro;
        private int pos = 0;
        const int TAM = 5;

        public CadastroProduto()
        {
            cadastro = new Produto[TAM];
        }
        public void InsereDados(int cod, string descricao, double valor)
        {
            if (pos < TAM)
            {
                Produto p = new Produto(cod, descricao, valor);
                cadastro[pos] = p;
                pos++;
            }
        }
        public void InsereDados(Produto p)
        {
            if (pos < TAM)
            {
                cadastro[pos] = p;
                pos++;
            }
        }
        public int Tamanho()
        {
            return pos;
        }

        public Produto GetProduto(int posicao)
        {
            Produto p = null;
            if (posicao >= 0 && posicao < pos)
            {
                p = cadastro[posicao];
            }
            return p;
        }
    }
}
