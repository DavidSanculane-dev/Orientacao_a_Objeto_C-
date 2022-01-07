using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjecto_CSharp._03ExercicioEscolar
{
    public class Aluno
    {
        //Atributos

        public string nome;
        public double nota1, nota2;

        //Métodos
        
        //Media
        public double media()
        {
            return (nota1 + nota2) / 2;
        }
        //Situação
        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }

        //Mensagem
        public void mensage()
        {
            double obterMedia = media();

            string obterSituacao = situacao(obterMedia);

            Console.WriteLine(nome+" está " +obterSituacao+ " com média " +obterMedia);
            Console.ReadKey();
        }

    }
}
