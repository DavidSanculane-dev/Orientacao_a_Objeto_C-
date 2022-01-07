using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjecto_CSharp._01Conceitos
{
    public class Pessoa
    {
        //Atributos
        public string nome;
        public int idade;

        //Ação
        public void mensagem()
        {
            Console.WriteLine("Ola! O meu nome é: " + nome + " e tenho " + idade + " anos.");
            Console.ReadKey();
        }
    }
}
