using OrientacaoObjecto_CSharp._01Conceitos;
using OrientacaoObjecto_CSharp._02Métodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjecto_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.nome = "David";
            obj.idade = 32;
            obj.mensagem();

            PessoaM ob = new PessoaM();
            ob.apresentar("Conde", 32);
        }
    }
}
