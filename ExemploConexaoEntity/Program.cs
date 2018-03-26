using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConexaoEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ExemploModelContainer ctx = new ExemploModelContainer())
            {
                var pessoas = from p in ctx.PessoasSet
                              select p.Id;
                var listPessoas = pessoas.ToList();

                foreach (int id in listPessoas)
                {
                    Console.WriteLine(id);
                }
            }
        }
    }
}
