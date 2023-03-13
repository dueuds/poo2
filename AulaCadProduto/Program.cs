using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCadProduto
{
  internal class Program
  {
        Produto p;

        EntradaDados entradaDados;

        public Program()
        {
            entradaDados = new EntradaDados();
            p = new Produto
            {
                Codigo = entradaDados.LeInteiro("Informe o Codigo"),
                Descricao = entradaDados.LeString("Informe a descrição"),
                Valor = entradaDados.LeDouble("Informe o valor")
            };
            Console.WriteLine(p.ToString());
            p.Reajuste(10);
        }
    static void Main(string[] args)
    {
            Program tst = new Program();
            Console.ReadLine();
    }
  }
}
