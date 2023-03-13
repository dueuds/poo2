using System.Web;

namespace AulaCadProduto
{
    public class Produto
    {
        private int codigo;
        private string descricao;
        private double valor;

        public Produto()
        {
            codigo = 0;
            descricao = "";
            valor = 0.0;
        }
        public Produto(int codigo, string descricao, double valor)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.valor = valor;
        }
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }
        public double Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }
        public void Reajuste(int perc)
        {
            valor = valor + (valor * (perc / 100));
        }
        public override string ToString()
        {
            return codigo + ", " + descricao + ", " + valor;
        }
    }
}
