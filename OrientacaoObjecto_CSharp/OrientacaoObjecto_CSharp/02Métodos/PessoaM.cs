using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjecto_CSharp._02Métodos
{
     public class PessoaM
    {

        //Metodos 01
        public void apresentar()
        {
            Console.WriteLine("Ola");
            Console.ReadKey();
        }

        //Metodos 02
        public void apresentar(string nome)
        {
            Console.WriteLine("Ola! Eu chamo-me: " +nome);
            Console.ReadKey();
        }


        //Metodos 03
        public void apresentar(string nome, int idade)
        {
            Console.WriteLine("Ola Sou " +nome+ " e tenho " +idade+ " anos de idade.");
            Console.ReadKey();
        }

    }
}
