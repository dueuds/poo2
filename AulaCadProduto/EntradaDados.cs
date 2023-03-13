using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCadProduto
{
    public class EntradaDados
    {
        public EntradaDados()
        {
            
        }
        public int LeInteiro(string msg)
        {
            string aux;
            int res = 0;
            bool ok = false;

            do
            {
                Console.WriteLine(msg); 
                aux = Console.ReadLine();
                if (int.TryParse(aux, out res))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Número inválido, tente novamente");
                }
            } while (ok == false);


            res = int.Parse(aux);
            return res;
        }
        public double LeDouble(string msg)
        {
            string aux;
            double res = 0;
            bool ok = false;

            do
            {
                Console.WriteLine(msg);
                aux = Console.ReadLine();
                if (double.TryParse(aux, out res))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Número inválido, tente novamente");
                }
            } while (ok == false);


            res = double.Parse(aux);
            return res;
        }
        public string LeString(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
    }
}
