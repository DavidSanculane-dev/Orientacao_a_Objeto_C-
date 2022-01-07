using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjecto_CSharp._06Encapsulamento
{
    public class AlunoEnca
    {

        private double nota1;
        private double nota2;

        private double media()
        {
            return (nota1 + nota2) / 2;
        }

        public void mensag()
        {
            Console.WriteLine("Informa a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informa a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A sua média é: " +media());
            Console.ReadKey();
        }

    }
}
